using System.Linq;
using System.Threading;
using System.Text.RegularExpressions;

namespace UARTDHT
{
    static class ThreadFeelDHT
    {
        private static bool bDHTTestOk = false;
        public static bool BDHTTestOk { get { return bDHTTestOk; } }
        private static string t = "?", h = "?";
        public static string T { get { return t; } }
        public static string H { get { return h; } }
        private static Thread threadDHT;
        private static Form1 myForm;
        delegate void DelegateForm1();

        public static void Start(Form1 sender)
        {
            myForm = sender;
            threadDHT = new Thread(ThreadPortsFeel);
            threadDHT.IsBackground = true;
            threadDHT.Start();
        }

        public static bool IsAlive
        {
            get
            {
                if (threadDHT != null) return threadDHT.IsAlive;
                return false;
            }
        }

        private static void ThreadPortsFeel()
        {
            try
            {
                long cycleCount = 0;
                string strFromUART, strOutLabel, strOutTextBox = "";
                string[] myPort;
                DelegateForm1 delegateForm1TextBox = delegate { myForm.textBoxMsgPorts.Text = strOutTextBox; }; // Делегат для отображения инфы о портах.

                while (true)
                {
                    myPort = System.IO.Ports.SerialPort.GetPortNames(); // в массив помещаем доступные порты 
                    strOutLabel = "Попытка поиска: " + (++cycleCount).ToString() + ". Найдено портов: " + myPort.Count().ToString();
                    myForm.Invoke(new DelegateForm1(() => myForm.labInfoPorts.Text = strOutLabel));
                    strOutTextBox = "";
                    myForm.Invoke(delegateForm1TextBox);
                    if (myPort.Count() == 0)
                    {
                        strOutTextBox = "COM портов не найдено.";
                        myForm.Invoke(delegateForm1TextBox);
                    }
                    try
                    {
                        for (int i = 0; i < myPort.Count(); i++)
                        {
                            myForm.serialPort1.Close();
                            strOutTextBox += "\r\n" + myPort[i] + " - ";
                            myForm.Invoke(delegateForm1TextBox);
                            try
                            {
                                myForm.serialPort1.PortName = myPort[i];
                                myForm.serialPort1.Open();
                            }
                            catch
                            {
                                strOutTextBox += "соединение с портом отсутствует.";
                                myForm.Invoke(delegateForm1TextBox);
                                continue;
                            }

                            Thread.Sleep(3000);

                            if (myForm.serialPort1.BytesToRead == 0)
                            {
                                strOutTextBox += "соединение есть, UART - молчит";
                                myForm.Invoke(delegateForm1TextBox);
                                continue;
                            }

                            strFromUART = "";
                            while (myForm.serialPort1.BytesToRead > 0)
                                strFromUART += (char)myForm.serialPort1.ReadByte();

                            if (strFromUART.IndexOf("DHT") >= 0)
                            {
                                strOutTextBox += "Устройство по UART обнаружено.";
                                if (strFromUART.IndexOf("ERROR") >= 0) strOutTextBox += " Ошибка датчика.";
                                else
                                {
                                    strOutTextBox += " Датчик найден.";
                                    bDHTTestOk = true;
                                }
                                myForm.Invoke(delegateForm1TextBox);
                                if (bDHTTestOk) ThreadUARTFeel(); // Начинаем читать температуру и влажность.   
                            }
                            else strOutTextBox += "Cоединение есть. Данные по UART не верные.";
                            myForm.Invoke(delegateForm1TextBox);
                        }
                    }
                    catch { }
                    Thread.Sleep(3000);
                }
            }
            catch { }
            finally
            {
                Finalization();
            }
        }

        private static void ThreadUARTFeel()
        {
            try
            {
                string strFromUART, strOutLabelT, strOutLabelH;
                myForm.Invoke(new DelegateForm1(() => myForm.labInfoPorts.Text = "Чтение данных с датчика."));

                Regex regexTH = new Regex(@"DHT\sT=(-?\d+)\sH=(\d+)");
                while (true)
                {
                    Thread.Sleep(1500);

                    if (myForm.serialPort1.BytesToRead == 0) break;
                    strFromUART = "";
                    while (myForm.serialPort1.BytesToRead > 0)
                        strFromUART += (char)myForm.serialPort1.ReadByte();
                    //strFromUART = "DHT T=-22 H=55";
                    t = regexTH.Match(strFromUART).Groups[1].Value;
                    h = regexTH.Match(strFromUART).Groups[2].Value;
                    strOutLabelT = "T=" + t;
                    strOutLabelH = "H=" + h;
                    if (strOutLabelT == "T=") break;
                    myForm.Invoke(new DelegateForm1(() => myForm.labT.Text = strOutLabelT));
                    myForm.Invoke(new DelegateForm1(() => myForm.labH.Text = strOutLabelH));
                }
            }
            catch { }
            finally
            {
                Finalization();
            }
        }

        private static void Finalization()
        {
            bDHTTestOk = false;
            t = "?"; h = "?";
            myForm.Invoke(new DelegateForm1(() => myForm.labT.Text = "T=?"));
            myForm.Invoke(new DelegateForm1(() => myForm.labH.Text = "H=?"));
        }
    }
}
