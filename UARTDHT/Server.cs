using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UARTDHT
{
  static class ThreadServer
  {
    private static Thread threadServer;
    private static Form1 myForm;
    private static string serverAddress;
    private static int serverPort;
    delegate void DelegateForm1();

    public static bool IsAlive
    {
      get
      {
        if (threadServer != null) return threadServer.IsAlive;
        return false;
      }
    }

    public static void Start(Form1 sender, string serverAddress, int serverPort)
    {
      myForm = sender;
      ThreadServer.serverAddress = serverAddress;
      ThreadServer.serverPort = serverPort;
      threadServer = new Thread(ServerWork);
      threadServer.IsBackground = true;
      threadServer.Start();
    }

    private static void ServerWork()
    {
      string strLabInfoServer = "";
      DelegateForm1 delegateForm1LabInfoServer = delegate { myForm.labInfoServer.Text = strLabInfoServer; };
      TcpListener listener = null;
      try
      {
        strLabInfoServer = "Запуск сервера на " + serverAddress + ":" + serverPort;
        myForm.Invoke(delegateForm1LabInfoServer);
        listener = new TcpListener(IPAddress.Parse(serverAddress), serverPort);

        listener.Start();
        strLabInfoServer += "\nСервер запущен.";
        myForm.Invoke(delegateForm1LabInfoServer);

        while (myForm.isServerStart)
        {
          Thread.Sleep(9); // Пауза, чтобы не грузить поток.
          if (!listener.Pending()) continue;
          TcpClient client = listener.AcceptTcpClient();
          NetworkStream stream = client.GetStream();
          string message;
          if (!ThreadFeelDHT.BDHTTestOk) message = "Датчик на сервере не обнаружен.";
          else
          {
            message = "Датчик на сервере обнаружен. T=" + ThreadFeelDHT.T + ", H=" + ThreadFeelDHT.H + ".\n";
            int t; int h;

            if ((!int.TryParse(ThreadFeelDHT.T, out t)) || (!int.TryParse(ThreadFeelDHT.H, out h)))
              message += "Ошибка преобразования ThreadFeelDHT.T или ThreadFeelDHT.H из string в int!";
            else
            {
              if (t >= myForm.numTCrit.Value) message += "Критическая температура! ";
              if (h >= myForm.numHCrit.Value) message += "Критическая влажность!";
            }
          }
          byte[] data = new byte[256]; // Буфер для отправляемых данных (символ Unicode - 2 байта).
          data = Encoding.Unicode.GetBytes(message);
          stream.Write(data, 0, data.Length);//*/
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        if (listener != null)
        {
          listener.Stop();
          strLabInfoServer = "Сервер остановлен.";
          myForm.Invoke(delegateForm1LabInfoServer);
        }
      }


    }

  }
}