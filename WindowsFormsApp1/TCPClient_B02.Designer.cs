namespace KTMonCL
{
    partial class TCPClient_B02
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
            this.lbPort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHienThi = new System.Windows.Forms.ListBox();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(480, 86);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(34, 16);
            this.lbPort.TabIndex = 26;
            this.lbPort.Text = "Port:";
            this.lbPort.Click += new System.EventHandler(this.lbPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Địa chỉ IP:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbHienThi
            // 
            this.lbHienThi.FormattingEnabled = true;
            this.lbHienThi.HorizontalScrollbar = true;
            this.lbHienThi.ItemHeight = 16;
            this.lbHienThi.Location = new System.Drawing.Point(98, 122);
            this.lbHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(607, 260);
            this.lbHienThi.TabIndex = 24;
            this.lbHienThi.SelectedIndexChanged += new System.EventHandler(this.lbHienThi_SelectedIndexChanged);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(98, 390);
            this.txtSend.Margin = new System.Windows.Forms.Padding(4);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(485, 22);
            this.txtSend.TabIndex = 21;
            this.txtSend.TextChanged += new System.EventHandler(this.txtSend_TextChanged);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(527, 82);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(177, 22);
            this.txtPort.TabIndex = 19;
            this.txtPort.TextChanged += new System.EventHandler(this.txtPort_TextChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(176, 82);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(263, 22);
            this.txtIP.TabIndex = 18;
            this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(592, 390);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(113, 25);
            this.btnGui.TabIndex = 22;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click_1);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(98, 36);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(167, 39);
            this.btnConnect.TabIndex = 20;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(539, 36);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(167, 39);
            this.btnDisconnect.TabIndex = 23;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click_1);
            // 
            // TCPClient_B02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Name = "TCPClient_B02";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Clientt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbHienThi;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

