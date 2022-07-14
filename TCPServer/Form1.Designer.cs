namespace TCPServer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(88, 9);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(322, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(335, 288);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(88, 38);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfo.Size = new System.Drawing.Size(322, 216);
            this.txtInfo.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(254, 288);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message :";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(88, 260);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(322, 23);
            this.txtMessage.TabIndex = 5;
            // 
            // lstClientIP
            // 
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 15;
            this.lstClientIP.Location = new System.Drawing.Point(416, 38);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(207, 274);
            this.lstClientIP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client IP :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstClientIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIP);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIP;
        private Label label1;
        private Button btnStart;
        private TextBox txtInfo;
        private Button btnSend;
        private Label label2;
        private TextBox txtMessage;
        private ListBox lstClientIP;
        private Label label3;
    }
}