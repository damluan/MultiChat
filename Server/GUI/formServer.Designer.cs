namespace Server
{
    partial class formServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txt_chatLog = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.txt_inputPrivate = new System.Windows.Forms.TextBox();
            this.Private = new System.Windows.Forms.Button();
            this.ServerSetting = new System.Windows.Forms.GroupBox();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.txt_PORT = new System.Windows.Forms.TextBox();
            this.txt_IPAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clientOnline = new System.Windows.Forms.GroupBox();
            this.Message = new System.Windows.Forms.GroupBox();
            this.ChatLog = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip.SuspendLayout();
            this.ServerSetting.SuspendLayout();
            this.clientOnline.SuspendLayout();
            this.Message.SuspendLayout();
            this.ChatLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(32, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txt_chatLog
            // 
            this.txt_chatLog.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_chatLog.Location = new System.Drawing.Point(6, 16);
            this.txt_chatLog.Multiline = true;
            this.txt_chatLog.Name = "txt_chatLog";
            this.txt_chatLog.ReadOnly = true;
            this.txt_chatLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_chatLog.Size = new System.Drawing.Size(305, 452);
            this.txt_chatLog.TabIndex = 1;
            this.txt_chatLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(249, 160);
            this.listBox1.TabIndex = 3;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disconnectToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(134, 26);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(243, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chat Server";
            // 
            // btnServerStop
            // 
            this.btnServerStop.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnServerStop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnServerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServerStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServerStop.ForeColor = System.Drawing.Color.White;
            this.btnServerStop.Location = new System.Drawing.Point(157, 120);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(75, 23);
            this.btnServerStop.TabIndex = 7;
            this.btnServerStop.Text = "Stop Server";
            this.btnServerStop.UseVisualStyleBackColor = false;
            this.btnServerStop.Click += new System.EventHandler(this.btnServerStop_Click);
            // 
            // txt_inputPrivate
            // 
            this.txt_inputPrivate.Location = new System.Drawing.Point(6, 20);
            this.txt_inputPrivate.Multiline = true;
            this.txt_inputPrivate.Name = "txt_inputPrivate";
            this.txt_inputPrivate.Size = new System.Drawing.Size(251, 63);
            this.txt_inputPrivate.TabIndex = 8;
            // 
            // Private
            // 
            this.Private.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Private.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Private.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Private.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Private.ForeColor = System.Drawing.Color.White;
            this.Private.Location = new System.Drawing.Point(105, 89);
            this.Private.Name = "Private";
            this.Private.Size = new System.Drawing.Size(59, 23);
            this.Private.TabIndex = 9;
            this.Private.Text = "Send";
            this.Private.UseVisualStyleBackColor = false;
            this.Private.Click += new System.EventHandler(this.Private_Click);
            // 
            // ServerSetting
            // 
            this.ServerSetting.Controls.Add(this.txt_Size);
            this.ServerSetting.Controls.Add(this.txt_PORT);
            this.ServerSetting.Controls.Add(this.txt_IPAddress);
            this.ServerSetting.Controls.Add(this.label5);
            this.ServerSetting.Controls.Add(this.btnServerStop);
            this.ServerSetting.Controls.Add(this.label4);
            this.ServerSetting.Controls.Add(this.label3);
            this.ServerSetting.Controls.Add(this.btnStart);
            this.ServerSetting.Location = new System.Drawing.Point(12, 30);
            this.ServerSetting.Name = "ServerSetting";
            this.ServerSetting.Size = new System.Drawing.Size(264, 156);
            this.ServerSetting.TabIndex = 10;
            this.ServerSetting.TabStop = false;
            this.ServerSetting.Text = "Server Settings";
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
            // clientOnline
            // 
            this.clientOnline.Controls.Add(this.listBox1);
            this.clientOnline.Location = new System.Drawing.Point(12, 192);
            this.clientOnline.Name = "clientOnline";
            this.clientOnline.Size = new System.Drawing.Size(264, 188);
            this.clientOnline.TabIndex = 11;
            this.clientOnline.TabStop = false;
            this.clientOnline.Text = "Clients Online";
            // 
            // Message
            // 
            this.Message.Controls.Add(this.txt_inputPrivate);
            this.Message.Controls.Add(this.Private);
            this.Message.Location = new System.Drawing.Point(12, 386);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(264, 118);
            this.Message.TabIndex = 12;
            this.Message.TabStop = false;
            this.Message.Text = "Message";
            // 
            // ChatLog
            // 
            this.ChatLog.Controls.Add(this.txt_chatLog);
            this.ChatLog.Location = new System.Drawing.Point(294, 30);
            this.ChatLog.Name = "ChatLog";
            this.ChatLog.Size = new System.Drawing.Size(322, 474);
            this.ChatLog.TabIndex = 13;
            this.ChatLog.TabStop = false;
            this.ChatLog.Text = "Chat Log";
            // 
            // formServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(628, 516);
            this.Controls.Add(this.ChatLog);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.clientOnline);
            this.Controls.Add(this.ServerSetting);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(501, 467);
            this.Name = "formServer";
            this.Text = "Server";
            this.contextMenuStrip.ResumeLayout(false);
            this.ServerSetting.ResumeLayout(false);
            this.ServerSetting.PerformLayout();
            this.clientOnline.ResumeLayout(false);
            this.Message.ResumeLayout(false);
            this.Message.PerformLayout();
            this.ChatLog.ResumeLayout(false);
            this.ChatLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txt_chatLog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.TextBox txt_inputPrivate;
        private System.Windows.Forms.Button Private;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.GroupBox ServerSetting;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.TextBox txt_PORT;
        private System.Windows.Forms.TextBox txt_IPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox clientOnline;
        private System.Windows.Forms.GroupBox Message;
        private System.Windows.Forms.GroupBox ChatLog;
    }
}

