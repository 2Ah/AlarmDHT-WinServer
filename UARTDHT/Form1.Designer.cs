namespace UARTDHT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerThreadInspect = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxMsgPorts = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labH = new System.Windows.Forms.Label();
            this.labT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labInfoPorts = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTCP = new System.Windows.Forms.ComboBox();
            this.btnStopTCPListener = new System.Windows.Forms.Button();
            this.labInfoServer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.btnStartTCPListener = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numHCrit = new System.Windows.Forms.NumericUpDown();
            this.numTCrit = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHCrit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCrit)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 38400;
            // 
            // timerThreadInspect
            // 
            this.timerThreadInspect.Enabled = true;
            this.timerThreadInspect.Interval = 3000;
            this.timerThreadInspect.Tick += new System.EventHandler(this.timerThreadInspect_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 205);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxMsgPorts);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(342, 179);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Датчик";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxMsgPorts
            // 
            this.textBoxMsgPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMsgPorts.Location = new System.Drawing.Point(3, 24);
            this.textBoxMsgPorts.Multiline = true;
            this.textBoxMsgPorts.Name = "textBoxMsgPorts";
            this.textBoxMsgPorts.ReadOnly = true;
            this.textBoxMsgPorts.Size = new System.Drawing.Size(336, 108);
            this.textBoxMsgPorts.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labH);
            this.panel2.Controls.Add(this.labT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 44);
            this.panel2.TabIndex = 9;
            // 
            // labH
            // 
            this.labH.AutoSize = true;
            this.labH.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labH.ForeColor = System.Drawing.Color.Blue;
            this.labH.Location = new System.Drawing.Point(190, 6);
            this.labH.Name = "labH";
            this.labH.Size = new System.Drawing.Size(73, 36);
            this.labH.TabIndex = 9;
            this.labH.Text = "H=?";
            // 
            // labT
            // 
            this.labT.AutoSize = true;
            this.labT.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labT.Location = new System.Drawing.Point(35, 6);
            this.labT.Name = "labT";
            this.labT.Size = new System.Drawing.Size(70, 36);
            this.labT.TabIndex = 8;
            this.labT.Text = "T=?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labInfoPorts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 21);
            this.panel1.TabIndex = 8;
            // 
            // labInfoPorts
            // 
            this.labInfoPorts.AutoSize = true;
            this.labInfoPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInfoPorts.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labInfoPorts.Location = new System.Drawing.Point(2, -1);
            this.labInfoPorts.Name = "labInfoPorts";
            this.labInfoPorts.Size = new System.Drawing.Size(185, 17);
            this.labInfoPorts.TabIndex = 5;
            this.labInfoPorts.Text = "Список найденных портов:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTCP);
            this.tabPage2.Controls.Add(this.btnStopTCPListener);
            this.tabPage2.Controls.Add(this.labInfoServer);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numPort);
            this.tabPage2.Controls.Add(this.btnStartTCPListener);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(342, 179);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сервер";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTCP
            // 
            this.cbTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTCP.Items.AddRange(new object[] {
            "127.0.0.1"});
            this.cbTCP.Location = new System.Drawing.Point(6, 22);
            this.cbTCP.Name = "cbTCP";
            this.cbTCP.Size = new System.Drawing.Size(108, 21);
            this.cbTCP.TabIndex = 7;
            // 
            // btnStopTCPListener
            // 
            this.btnStopTCPListener.Location = new System.Drawing.Point(268, 20);
            this.btnStopTCPListener.Name = "btnStopTCPListener";
            this.btnStopTCPListener.Size = new System.Drawing.Size(70, 23);
            this.btnStopTCPListener.TabIndex = 6;
            this.btnStopTCPListener.Text = "Остановка";
            this.btnStopTCPListener.UseVisualStyleBackColor = true;
            this.btnStopTCPListener.Click += new System.EventHandler(this.btnStopTCPListener_Click);
            // 
            // labInfoServer
            // 
            this.labInfoServer.AutoSize = true;
            this.labInfoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labInfoServer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labInfoServer.Location = new System.Drawing.Point(8, 46);
            this.labInfoServer.Name = "labInfoServer";
            this.labInfoServer.Size = new System.Drawing.Size(141, 17);
            this.labInfoServer.TabIndex = 5;
            this.labInfoServer.Text = "Сервер остановлен.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Порт:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Интерфейс:";
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(117, 23);
            this.numPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(69, 20);
            this.numPort.TabIndex = 2;
            this.numPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // btnStartTCPListener
            // 
            this.btnStartTCPListener.Location = new System.Drawing.Point(192, 20);
            this.btnStartTCPListener.Name = "btnStartTCPListener";
            this.btnStartTCPListener.Size = new System.Drawing.Size(70, 23);
            this.btnStartTCPListener.TabIndex = 0;
            this.btnStartTCPListener.Text = "Запуск";
            this.btnStartTCPListener.UseVisualStyleBackColor = true;
            this.btnStartTCPListener.Click += new System.EventHandler(this.btnStartTCPListener_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.numHCrit);
            this.tabPage3.Controls.Add(this.numTCrit);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(342, 179);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Настройки";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Критическая влажность :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Критическая температура :";
            // 
            // numHCrit
            // 
            this.numHCrit.Location = new System.Drawing.Point(161, 36);
            this.numHCrit.Name = "numHCrit";
            this.numHCrit.Size = new System.Drawing.Size(72, 20);
            this.numHCrit.TabIndex = 1;
            // 
            // numTCrit
            // 
            this.numTCrit.Location = new System.Drawing.Point(161, 10);
            this.numTCrit.Name = "numTCrit";
            this.numTCrit.Size = new System.Drawing.Size(72, 20);
            this.numTCrit.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "UARTDHT (server)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 205);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UARTDHT - Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHCrit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTCrit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.IO.Ports.SerialPort serialPort1;
        internal System.Windows.Forms.Timer timerThreadInspect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.NumericUpDown numHCrit;
        internal System.Windows.Forms.NumericUpDown numTCrit;
        internal System.Windows.Forms.Label labInfoServer;
        private System.Windows.Forms.ComboBox cbTCP;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Button btnStartTCPListener;
        private System.Windows.Forms.Button btnStopTCPListener;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label labInfoPorts;
        internal System.Windows.Forms.TextBox textBoxMsgPorts;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label labH;
        internal System.Windows.Forms.Label labT;
    }
}

