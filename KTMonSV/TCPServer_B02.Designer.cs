namespace KTMonSV
{
    partial class TCPServer_B02
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbHienThi = new System.Windows.Forms.ListBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(36, 377);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(507, 22);
            this.txtNhap.TabIndex = 6;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            this.txtNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNhap_KeyDown);
            // 
            // lbHienThi
            // 
            this.lbHienThi.FormattingEnabled = true;
            this.lbHienThi.HorizontalScrollbar = true;
            this.lbHienThi.ItemHeight = 16;
            this.lbHienThi.Location = new System.Drawing.Point(36, 60);
            this.lbHienThi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbHienThi.Name = "lbHienThi";
            this.lbHienThi.Size = new System.Drawing.Size(632, 308);
            this.lbHienThi.TabIndex = 9;
            this.lbHienThi.SelectedIndexChanged += new System.EventHandler(this.lbHienThi_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(572, 11);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(97, 42);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(552, 375);
            this.btnGui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(117, 25);
            this.btnGui.TabIndex = 7;
            this.btnGui.Text = "Gửi";
            this.btnGui.UseVisualStyleBackColor = true;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(36, 11);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(97, 42);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 417);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbHienThi);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ListBox lbHienThi;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnStart;
    }
}

