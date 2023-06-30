namespace Client
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            this.history = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.privateChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnect = new System.Windows.Forms.Button();
            this.indicator = new System.Windows.Forms.Panel();
            this.btnClr = new System.Windows.Forms.Button();
            this.ServerSetting = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_PORT = new System.Windows.Forms.TextBox();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ChatLog = new System.Windows.Forms.GroupBox();
            this.clientOnline = new System.Windows.Forms.GroupBox();
            this.Message = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.ServerSetting.SuspendLayout();
            this.ChatLog.SuspendLayout();
            this.clientOnline.SuspendLayout();
            this.Message.SuspendLayout();
            this.SuspendLayout();
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(6, 19);
            this.history.Multiline = true;
            this.history.Name = "history";
            this.history.ReadOnly = true;
            this.history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history.Size = new System.Drawing.Size(310, 420);
            this.history.TabIndex = 0;
            this.history.TextChanged += new System.EventHandler(this.history_TextChanged);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(6, 19);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(252, 64);
            this.input.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(85, 89);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(252, 160);
            this.listBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.privateChatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // privateChatToolStripMenuItem
            // 
            this.privateChatToolStripMenuItem.Name = "privateChatToolStripMenuItem";
            this.privateChatToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.privateChatToolStripMenuItem.Text = "Private Chat";
            this.privateChatToolStripMenuItem.Click += new System.EventHandler(this.privateChatToolStripMenuItem_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(72, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "btn_Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // indicator
            // 
            this.indicator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.indicator.Location = new System.Drawing.Point(12, 12);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 11);
            this.indicator.TabIndex = 6;
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(130, 445);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(54, 21);
            this.btnClr.TabIndex = 7;
            this.btnClr.Text = "Reset";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // ServerSetting
            // 
            this.ServerSetting.Controls.Add(this.btnDisconnect);
            this.ServerSetting.Controls.Add(this.txt_Size);
            this.ServerSetting.Controls.Add(this.txt_PORT);
            this.ServerSetting.Controls.Add(this.txt_IPAddress);
            this.ServerSetting.Controls.Add(this.label5);
            this.ServerSetting.Controls.Add(this.btnConnect);
            this.ServerSetting.Controls.Add(this.label4);
            this.ServerSetting.Controls.Add(this.label3);
            this.ServerSetting.Location = new System.Drawing.Point(28, 12);
            this.ServerSetting.Name = "ServerSetting";
            this.ServerSetting.Size = new System.Drawing.Size(264, 156);
            this.ServerSetting.TabIndex = 11;
            this.ServerSetting.TabStop = false;
            this.ServerSetting.Text = "Server Settings";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(153, 120);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(72, 23);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // txt_Size
            // 
            this.txt_Size.Location = new System.Drawing.Point(76, 83);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(165, 20);
            this.txt_Size.TabIndex = 12;
            this.txt_Size.Text = "1024";
            // 
            // txt_PORT
            // 
            this.txt_PORT.Location = new System.Drawing.Point(76, 51);
            this.txt_PORT.Name = "txt_PORT";
            this.txt_PORT.Size = new System.Drawing.Size(165, 20);
            this.txt_PORT.TabIndex = 11;
            this.txt_PORT.Text = "5000";
            // 
            // txt_IPAddress
            // 
            this.txt_IPAddress.Location = new System.Drawing.Point(76, 19);
            this.txt_IPAddress.Name = "txt_IPAddress";
            this.txt_IPAddress.Size = new System.Drawing.Size(165, 20);
            this.txt_IPAddress.TabIndex = 10;
            this.txt_IPAddress.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(6, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Buffer Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP Address";
            // 
            // ChatLog
            // 
            this.ChatLog.Controls.Add(this.history);
            this.ChatLog.Controls.Add(this.btnClr);
            this.ChatLog.Location = new System.Drawing.Point(298, 12);
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.Size = new System.Drawing.Size(322, 474);
            this.ChatLog.TabIndex = 14;
            this.ChatLog.TabStop = false;
            this.ChatLog.Text = "Chat Log";
            // 
            // clientOnline
            // 
            this.clientOnline.Controls.Add(this.listBox1);
            this.clientOnline.Location = new System.Drawing.Point(28, 174);
            this.clientOnline.Name = "clientOnline";
            this.clientOnline.Size = new System.Drawing.Size(264, 188);
            this.clientOnline.TabIndex = 15;
            this.clientOnline.TabStop = false;
            this.clientOnline.Text = "Friends";
            // 
            // Message
            // 
            this.Message.Controls.Add(this.input);
            this.Message.Controls.Add(this.btnSend);
            this.Message.Location = new System.Drawing.Point(28, 368);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(264, 118);
            this.Message.TabIndex = 16;
            this.Message.TabStop = false;
            this.Message.Text = "Message";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 495);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.clientOnline);
            this.Controls.Add(this.ChatLog);
            this.Controls.Add(this.ServerSetting);
            this.Controls.Add(this.indicator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "formMain";
            this.Text = "Client ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ServerSetting.ResumeLayout(false);
            this.ServerSetting.PerformLayout();
            this.ChatLog.ResumeLayout(false);
            this.ChatLog.PerformLayout();
            this.clientOnline.ResumeLayout(false);
            this.Message.ResumeLayout(false);
            this.Message.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox history;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem privateChatToolStripMenuItem;
        private System.Windows.Forms.Panel indicator;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.GroupBox ServerSetting;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_PORT;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox ChatLog;
        private System.Windows.Forms.GroupBox clientOnline;
        private System.Windows.Forms.GroupBox Message;
        private System.Windows.Forms.Button btnDisconnect;
    }
}

