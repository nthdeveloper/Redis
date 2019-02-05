namespace PubSubSample
{
    partial class FrmPubSubSample
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
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.numRedisPort = new System.Windows.Forms.NumericUpDown();
            this.txtRedisHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSubscribeByPattern = new System.Windows.Forms.Button();
            this.txtChannelPattern = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimpleSubscribe = new System.Windows.Forms.Button();
            this.txtSimpleChannelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtPublishChannelName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUnsubscribeByPattern = new System.Windows.Forms.Button();
            this.txtUnsubscribeChannelPattern = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSimpleUnsubscribe = new System.Windows.Forms.Button();
            this.txtUnsubscribeChannelName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMessages = new System.Windows.Forms.TextBox();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.btnDisconnect);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.numRedisPort);
            this.grpConnection.Controls.Add(this.txtRedisHost);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(401, 83);
            this.grpConnection.TabIndex = 7;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "(1) Redis Server Connection";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(224, 45);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(140, 23);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(224, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(140, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // numRedisPort
            // 
            this.numRedisPort.Location = new System.Drawing.Point(89, 45);
            this.numRedisPort.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numRedisPort.Name = "numRedisPort";
            this.numRedisPort.Size = new System.Drawing.Size(120, 20);
            this.numRedisPort.TabIndex = 3;
            this.numRedisPort.Value = new decimal(new int[] {
            6379,
            0,
            0,
            0});
            // 
            // txtRedisHost
            // 
            this.txtRedisHost.Location = new System.Drawing.Point(89, 20);
            this.txtRedisHost.Name = "txtRedisHost";
            this.txtRedisHost.Size = new System.Drawing.Size(120, 20);
            this.txtRedisHost.TabIndex = 2;
            this.txtRedisHost.Text = "127.0.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSubscribeByPattern);
            this.groupBox1.Controls.Add(this.txtChannelPattern);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSimpleSubscribe);
            this.groupBox1.Controls.Add(this.txtSimpleChannelName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 83);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(2) Subscribe";
            // 
            // btnSubscribeByPattern
            // 
            this.btnSubscribeByPattern.Location = new System.Drawing.Point(224, 50);
            this.btnSubscribeByPattern.Name = "btnSubscribeByPattern";
            this.btnSubscribeByPattern.Size = new System.Drawing.Size(140, 23);
            this.btnSubscribeByPattern.TabIndex = 17;
            this.btnSubscribeByPattern.Text = "Subscribe by Pattern";
            this.btnSubscribeByPattern.UseVisualStyleBackColor = true;
            this.btnSubscribeByPattern.Click += new System.EventHandler(this.btnSubscribeByPattern_Click);
            // 
            // txtChannelPattern
            // 
            this.txtChannelPattern.Location = new System.Drawing.Point(89, 50);
            this.txtChannelPattern.Name = "txtChannelPattern";
            this.txtChannelPattern.Size = new System.Drawing.Size(120, 20);
            this.txtChannelPattern.TabIndex = 16;
            this.txtChannelPattern.Text = "*news*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Pattern";
            // 
            // btnSimpleSubscribe
            // 
            this.btnSimpleSubscribe.Location = new System.Drawing.Point(224, 21);
            this.btnSimpleSubscribe.Name = "btnSimpleSubscribe";
            this.btnSimpleSubscribe.Size = new System.Drawing.Size(140, 23);
            this.btnSimpleSubscribe.TabIndex = 14;
            this.btnSimpleSubscribe.Text = "Simple Subscribe";
            this.btnSimpleSubscribe.UseVisualStyleBackColor = true;
            this.btnSimpleSubscribe.Click += new System.EventHandler(this.btnSimpleSubscribe_Click);
            // 
            // txtSimpleChannelName
            // 
            this.txtSimpleChannelName.Location = new System.Drawing.Point(89, 21);
            this.txtSimpleChannelName.Name = "txtSimpleChannelName";
            this.txtSimpleChannelName.Size = new System.Drawing.Size(120, 20);
            this.txtSimpleChannelName.TabIndex = 13;
            this.txtSimpleChannelName.Text = "sports_news";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Channel Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMessage);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnPublish);
            this.groupBox2.Controls.Add(this.txtPublishChannelName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 89);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "(3) Publish";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(89, 50);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(120, 20);
            this.txtMessage.TabIndex = 16;
            this.txtMessage.Text = "message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Message";
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(215, 21);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(120, 49);
            this.btnPublish.TabIndex = 14;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtPublishChannelName
            // 
            this.txtPublishChannelName.Location = new System.Drawing.Point(89, 21);
            this.txtPublishChannelName.Name = "txtPublishChannelName";
            this.txtPublishChannelName.Size = new System.Drawing.Size(120, 20);
            this.txtPublishChannelName.TabIndex = 13;
            this.txtPublishChannelName.Text = "sports_news";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Channel Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUnsubscribeByPattern);
            this.groupBox3.Controls.Add(this.txtUnsubscribeChannelPattern);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnSimpleUnsubscribe);
            this.groupBox3.Controls.Add(this.txtUnsubscribeChannelName);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 83);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "(5) Unsubscribe";
            // 
            // btnUnsubscribeByPattern
            // 
            this.btnUnsubscribeByPattern.Location = new System.Drawing.Point(224, 50);
            this.btnUnsubscribeByPattern.Name = "btnUnsubscribeByPattern";
            this.btnUnsubscribeByPattern.Size = new System.Drawing.Size(140, 23);
            this.btnUnsubscribeByPattern.TabIndex = 17;
            this.btnUnsubscribeByPattern.Text = "Unsubscribe by Pattern";
            this.btnUnsubscribeByPattern.UseVisualStyleBackColor = true;
            this.btnUnsubscribeByPattern.Click += new System.EventHandler(this.btnUnsubscribeByPattern_Click);
            // 
            // txtUnsubscribeChannelPattern
            // 
            this.txtUnsubscribeChannelPattern.Location = new System.Drawing.Point(89, 50);
            this.txtUnsubscribeChannelPattern.Name = "txtUnsubscribeChannelPattern";
            this.txtUnsubscribeChannelPattern.Size = new System.Drawing.Size(120, 20);
            this.txtUnsubscribeChannelPattern.TabIndex = 16;
            this.txtUnsubscribeChannelPattern.Text = "*news*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pattern";
            // 
            // btnSimpleUnsubscribe
            // 
            this.btnSimpleUnsubscribe.Location = new System.Drawing.Point(224, 21);
            this.btnSimpleUnsubscribe.Name = "btnSimpleUnsubscribe";
            this.btnSimpleUnsubscribe.Size = new System.Drawing.Size(140, 23);
            this.btnSimpleUnsubscribe.TabIndex = 14;
            this.btnSimpleUnsubscribe.Text = "Simple Unsubscribe";
            this.btnSimpleUnsubscribe.UseVisualStyleBackColor = true;
            this.btnSimpleUnsubscribe.Click += new System.EventHandler(this.btnSimpleUnsubscribe_Click);
            // 
            // txtUnsubscribeChannelName
            // 
            this.txtUnsubscribeChannelName.Location = new System.Drawing.Point(89, 21);
            this.txtUnsubscribeChannelName.Name = "txtUnsubscribeChannelName";
            this.txtUnsubscribeChannelName.Size = new System.Drawing.Size(120, 20);
            this.txtUnsubscribeChannelName.TabIndex = 13;
            this.txtUnsubscribeChannelName.Text = "sports_news";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Channel Name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMessages);
            this.groupBox4.Location = new System.Drawing.Point(419, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 356);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "(4) Get Messages";
            // 
            // txtMessages
            // 
            this.txtMessages.Location = new System.Drawing.Point(6, 22);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(336, 317);
            this.txtMessages.TabIndex = 0;
            // 
            // FrmPubSubSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 381);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmPubSubSample";
            this.Text = "Pub/Sub Sample";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSubscribeByPattern;
        private System.Windows.Forms.TextBox txtChannelPattern;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSimpleSubscribe;
        private System.Windows.Forms.TextBox txtSimpleChannelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.TextBox txtPublishChannelName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnsubscribeByPattern;
        private System.Windows.Forms.TextBox txtUnsubscribeChannelPattern;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSimpleUnsubscribe;
        private System.Windows.Forms.TextBox txtUnsubscribeChannelName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMessages;
    }
}

