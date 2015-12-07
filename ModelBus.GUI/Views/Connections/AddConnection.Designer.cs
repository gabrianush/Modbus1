namespace ModBus.GUI
{
    partial class AddConnection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbSerial = new System.Windows.Forms.GroupBox();
            this.nudSerialTimeOut = new System.Windows.Forms.NumericUpDown();
            this.buttonAddSerialConnection = new System.Windows.Forms.Button();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.cmbBaudeRate = new System.Windows.Forms.ComboBox();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTcp = new System.Windows.Forms.GroupBox();
            this.nudTcpTimeOut = new System.Windows.Forms.NumericUpDown();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.buttonAddTCPConnection = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtxtIP = new System.Windows.Forms.MaskedTextBox();
            this.grbSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerialTimeOut)).BeginInit();
            this.grbTcp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTcpTimeOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSerial
            // 
            this.grbSerial.Controls.Add(this.nudSerialTimeOut);
            this.grbSerial.Controls.Add(this.buttonAddSerialConnection);
            this.grbSerial.Controls.Add(this.cmbParity);
            this.grbSerial.Controls.Add(this.cmbStopBits);
            this.grbSerial.Controls.Add(this.cmbDataBits);
            this.grbSerial.Controls.Add(this.cmbBaudeRate);
            this.grbSerial.Controls.Add(this.cmbPortName);
            this.grbSerial.Controls.Add(this.label6);
            this.grbSerial.Controls.Add(this.label5);
            this.grbSerial.Controls.Add(this.label4);
            this.grbSerial.Controls.Add(this.label3);
            this.grbSerial.Controls.Add(this.label2);
            this.grbSerial.Controls.Add(this.label1);
            this.grbSerial.Location = new System.Drawing.Point(12, 12);
            this.grbSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSerial.Name = "grbSerial";
            this.grbSerial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbSerial.Size = new System.Drawing.Size(544, 117);
            this.grbSerial.TabIndex = 0;
            this.grbSerial.TabStop = false;
            this.grbSerial.Text = "Serial Connection";
            // 
            // nudSerialTimeOut
            // 
            this.nudSerialTimeOut.Location = new System.Drawing.Point(453, 50);
            this.nudSerialTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSerialTimeOut.Name = "nudSerialTimeOut";
            this.nudSerialTimeOut.Size = new System.Drawing.Size(75, 22);
            this.nudSerialTimeOut.TabIndex = 13;
            // 
            // buttonAddSerialConnection
            // 
            this.buttonAddSerialConnection.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddSerialConnection.Location = new System.Drawing.Point(187, 84);
            this.buttonAddSerialConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddSerialConnection.Name = "buttonAddSerialConnection";
            this.buttonAddSerialConnection.Size = new System.Drawing.Size(173, 23);
            this.buttonAddSerialConnection.TabIndex = 12;
            this.buttonAddSerialConnection.Text = "Add Serial Connection";
            this.buttonAddSerialConnection.UseVisualStyleBackColor = true;
            this.buttonAddSerialConnection.Click += new System.EventHandler(this.buttonAddSerialConnection_Click);
            // 
            // cmbParity
            // 
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(365, 50);
            this.cmbParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(75, 24);
            this.cmbParity.TabIndex = 10;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(279, 50);
            this.cmbStopBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(75, 24);
            this.cmbStopBits.TabIndex = 9;
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(192, 50);
            this.cmbDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(75, 24);
            this.cmbDataBits.TabIndex = 8;
            // 
            // cmbBaudeRate
            // 
            this.cmbBaudeRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudeRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBaudeRate.FormattingEnabled = true;
            this.cmbBaudeRate.Location = new System.Drawing.Point(105, 50);
            this.cmbBaudeRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBaudeRate.Name = "cmbBaudeRate";
            this.cmbBaudeRate.Size = new System.Drawing.Size(75, 24);
            this.cmbBaudeRate.TabIndex = 7;
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(19, 50);
            this.cmbPortName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(75, 24);
            this.cmbPortName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Timeout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial";
            // 
            // grbTcp
            // 
            this.grbTcp.Controls.Add(this.nudTcpTimeOut);
            this.grbTcp.Controls.Add(this.nudPort);
            this.grbTcp.Controls.Add(this.buttonAddTCPConnection);
            this.grbTcp.Controls.Add(this.label9);
            this.grbTcp.Controls.Add(this.label8);
            this.grbTcp.Controls.Add(this.label7);
            this.grbTcp.Controls.Add(this.mtxtIP);
            this.grbTcp.Location = new System.Drawing.Point(12, 153);
            this.grbTcp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTcp.Name = "grbTcp";
            this.grbTcp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTcp.Size = new System.Drawing.Size(544, 89);
            this.grbTcp.TabIndex = 1;
            this.grbTcp.TabStop = false;
            this.grbTcp.Text = "TCP Connection";
            // 
            // nudTcpTimeOut
            // 
            this.nudTcpTimeOut.Location = new System.Drawing.Point(281, 44);
            this.nudTcpTimeOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTcpTimeOut.Name = "nudTcpTimeOut";
            this.nudTcpTimeOut.Size = new System.Drawing.Size(75, 22);
            this.nudTcpTimeOut.TabIndex = 14;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(193, 44);
            this.nudPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(75, 22);
            this.nudPort.TabIndex = 7;
            // 
            // buttonAddTCPConnection
            // 
            this.buttonAddTCPConnection.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAddTCPConnection.Location = new System.Drawing.Point(369, 44);
            this.buttonAddTCPConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddTCPConnection.Name = "buttonAddTCPConnection";
            this.buttonAddTCPConnection.Size = new System.Drawing.Size(159, 23);
            this.buttonAddTCPConnection.TabIndex = 6;
            this.buttonAddTCPConnection.Text = "Add TCP Connection";
            this.buttonAddTCPConnection.UseVisualStyleBackColor = true;
            this.buttonAddTCPConnection.Click += new System.EventHandler(this.buttonAddTCPConnection_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Timeout";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "IP Address";
            // 
            // mtxtIP
            // 
            this.mtxtIP.Location = new System.Drawing.Point(19, 44);
            this.mtxtIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtxtIP.Mask = "###.###.###.###";
            this.mtxtIP.Name = "mtxtIP";
            this.mtxtIP.Size = new System.Drawing.Size(161, 22);
            this.mtxtIP.TabIndex = 0;
            this.mtxtIP.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxIP_TypeValidationCompleted);
            // 
            // AddConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 254);
            this.Controls.Add(this.grbTcp);
            this.Controls.Add(this.grbSerial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddConnection";
            this.Text = "Add Connection";
            this.Load += new System.EventHandler(this.AddConnection_Load);
            this.grbSerial.ResumeLayout(false);
            this.grbSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerialTimeOut)).EndInit();
            this.grbTcp.ResumeLayout(false);
            this.grbTcp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTcpTimeOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.ComboBox cmbBaudeRate;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Button buttonAddSerialConnection;
        private System.Windows.Forms.GroupBox grbTcp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtIP;
        private System.Windows.Forms.Button buttonAddTCPConnection;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.NumericUpDown nudSerialTimeOut;
        private System.Windows.Forms.NumericUpDown nudTcpTimeOut;
    }
}