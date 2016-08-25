using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace UARTDHT
{
    public partial class Form1 : Form
    {
        internal bool isServerStart = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            ThreadFeelDHT.Start(this);

            foreach (IPAddress ipaddress in Dns.GetHostByName(Dns.GetHostName()).AddressList)
                cbTCP.Items.Add(ipaddress.ToString());  // Заполнение списка cbTCP адресами локального хоста.
            cbTCP.SelectedIndex = 0;
            //Загрузка конфигурации из директории программы. 
            bool isServerStart = false;
            System.Data.DataSet ds = new System.Data.DataSet();
            try
            {
                ds.ReadXmlSchema(Application.StartupPath + "\\UARTDHT.cfg");
                cbTCP.Text = (string)ds.ExtendedProperties["tcp"];
                numPort.Value = decimal.Parse((string)ds.ExtendedProperties["tcpPort"]);
                isServerStart = Convert.ToBoolean(ds.ExtendedProperties["isServerStart"]);
                numTCrit.Value = decimal.Parse((string)ds.ExtendedProperties["tCrit"]);
                numHCrit.Value = decimal.Parse((string)ds.ExtendedProperties["hCrit"]);
            }
            catch { }
            if (isServerStart)
            {
                BlockStartServer();
                ThreadServer.Start(this, cbTCP.Text, (int)numPort.Value);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
            //Сохранение конфигурации в директории программы.
            System.Data.DataSet ds = new System.Data.DataSet();
            ds.ExtendedProperties["tcp"] = cbTCP.Text;
            ds.ExtendedProperties["tcpPort"] = numPort.Value;
            ds.ExtendedProperties["isServerStart"] = ThreadServer.IsAlive;
            ds.ExtendedProperties["tCrit"] = numTCrit.Value;
            ds.ExtendedProperties["hCrit"] = numHCrit.Value;
            ds.WriteXmlSchema(Application.StartupPath + "\\UARTDHT.cfg");
        }

        private void BlockStartServer()
        {
            isServerStart = true;
            cbTCP.Enabled = false;
            numPort.Enabled = false;
            btnStartTCPListener.Enabled = false;
        }
        private void UnBlockStartServer()
        {
            isServerStart = false;
            cbTCP.Enabled = true;
            numPort.Enabled = true;
            btnStartTCPListener.Enabled = true;
        }

        private void btnStartTCPListener_Click(object sender, EventArgs e)
        { 
            BlockStartServer();
            ThreadServer.Start(this, cbTCP.Text, (int)numPort.Value);
        }

        private void btnStopTCPListener_Click(object sender, EventArgs e)
        {
            UnBlockStartServer();
        }

        private void timerThreadInspect_Tick(object sender, EventArgs e)
        {
            if (!ThreadFeelDHT.IsAlive)
            {
                labInfoPorts.ForeColor = Color.Red;
                labInfoPorts.Text = "Ошибка! Поток ThreadFeelDHT завалился!";
            }
            if ((!ThreadServer.IsAlive) && (isServerStart == true))
            {
                labInfoServer.Text = "Ошибка! Поток ThreadServer завалился!";
                UnBlockStartServer();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) Hide();
        }
    }
}
