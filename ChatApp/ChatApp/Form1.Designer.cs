
namespace ChatApp
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
            this.groupBoxMe = new System.Windows.Forms.GroupBox();
            this.tbLocalPort = new System.Windows.Forms.TextBox();
            this.tbLocalIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxFriend = new System.Windows.Forms.GroupBox();
            this.tbDestinationPort = new System.Windows.Forms.TextBox();
            this.tbDestinationIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.groupBoxMe.SuspendLayout();
            this.groupBoxFriend.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMe
            // 
            this.groupBoxMe.Controls.Add(this.tbLocalPort);
            this.groupBoxMe.Controls.Add(this.tbLocalIP);
            this.groupBoxMe.Controls.Add(this.label2);
            this.groupBoxMe.Controls.Add(this.label1);
            this.groupBoxMe.Location = new System.Drawing.Point(26, 28);
            this.groupBoxMe.Name = "groupBoxMe";
            this.groupBoxMe.Size = new System.Drawing.Size(368, 159);
            this.groupBoxMe.TabIndex = 0;
            this.groupBoxMe.TabStop = false;
            this.groupBoxMe.Text = "Me";
            // 
            // tbLocalPort
            // 
            this.tbLocalPort.Location = new System.Drawing.Point(131, 83);
            this.tbLocalPort.Name = "tbLocalPort";
            this.tbLocalPort.Size = new System.Drawing.Size(125, 27);
            this.tbLocalPort.TabIndex = 5;
            // 
            // tbLocalIP
            // 
            this.tbLocalIP.Location = new System.Drawing.Point(131, 36);
            this.tbLocalIP.Name = "tbLocalIP";
            this.tbLocalIP.Size = new System.Drawing.Size(125, 27);
            this.tbLocalIP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ip Address:";
            // 
            // groupBoxFriend
            // 
            this.groupBoxFriend.Controls.Add(this.tbDestinationPort);
            this.groupBoxFriend.Controls.Add(this.tbDestinationIP);
            this.groupBoxFriend.Controls.Add(this.label4);
            this.groupBoxFriend.Controls.Add(this.label3);
            this.groupBoxFriend.Location = new System.Drawing.Point(538, 43);
            this.groupBoxFriend.Name = "groupBoxFriend";
            this.groupBoxFriend.Size = new System.Drawing.Size(395, 144);
            this.groupBoxFriend.TabIndex = 1;
            this.groupBoxFriend.TabStop = false;
            this.groupBoxFriend.Text = "Friend";
            // 
            // tbDestinationPort
            // 
            this.tbDestinationPort.Location = new System.Drawing.Point(162, 72);
            this.tbDestinationPort.Name = "tbDestinationPort";
            this.tbDestinationPort.Size = new System.Drawing.Size(125, 27);
            this.tbDestinationPort.TabIndex = 3;
            // 
            // tbDestinationIP
            // 
            this.tbDestinationIP.Location = new System.Drawing.Point(162, 28);
            this.tbDestinationIP.Name = "tbDestinationIP";
            this.tbDestinationIP.Size = new System.Drawing.Size(125, 27);
            this.tbDestinationIP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Port Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ip Address:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(977, 85);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(69, 487);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(820, 27);
            this.tbMessage.TabIndex = 3;
            // 
            // lbMessage
            // 
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 20;
            this.lbMessage.Location = new System.Drawing.Point(69, 217);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(937, 244);
            this.lbMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(912, 485);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 29);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 566);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBoxFriend);
            this.Controls.Add(this.groupBoxMe);
            this.Name = "Form1";
            this.Text = " Chat Apps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMe.ResumeLayout(false);
            this.groupBoxMe.PerformLayout();
            this.groupBoxFriend.ResumeLayout(false);
            this.groupBoxFriend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMe;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.GroupBox groupBoxFriend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocalPort;
        private System.Windows.Forms.TextBox tbLocalIP;
        private System.Windows.Forms.TextBox tbDestinationPort;
        private System.Windows.Forms.TextBox tbDestinationIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnSend;
    }
}

