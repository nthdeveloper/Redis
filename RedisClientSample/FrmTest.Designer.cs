namespace RedisClientSample
{
    partial class FrmTest
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
            this.btnSimpleSet = new System.Windows.Forms.Button();
            this.grpSimpleGetSet = new System.Windows.Forms.GroupBox();
            this.txtSimpleGetValue = new System.Windows.Forms.TextBox();
            this.txtSimpleGetKey = new System.Windows.Forms.TextBox();
            this.btnSimpleGet = new System.Windows.Forms.Button();
            this.txtSimpleSetValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSimpleSetKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.numRedisPort = new System.Windows.Forms.NumericUpDown();
            this.txtRedisHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.btnReadAllListItems = new System.Windows.Forms.Button();
            this.lbxListItems = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtListNewItem = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpIncrementDecrement = new System.Windows.Forms.GroupBox();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCounterValue = new System.Windows.Forms.TextBox();
            this.txtCounterName = new System.Windows.Forms.TextBox();
            this.btnCreateCounter = new System.Windows.Forms.Button();
            this.grpSimpleGetSet.SuspendLayout();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.grpList.SuspendLayout();
            this.grpIncrementDecrement.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSimpleSet
            // 
            this.btnSimpleSet.Location = new System.Drawing.Point(6, 38);
            this.btnSimpleSet.Name = "btnSimpleSet";
            this.btnSimpleSet.Size = new System.Drawing.Size(51, 23);
            this.btnSimpleSet.TabIndex = 0;
            this.btnSimpleSet.Text = "Set";
            this.btnSimpleSet.UseVisualStyleBackColor = true;
            this.btnSimpleSet.Click += new System.EventHandler(this.btnSimpleSet_Click);
            // 
            // grpSimpleGetSet
            // 
            this.grpSimpleGetSet.Controls.Add(this.txtSimpleGetValue);
            this.grpSimpleGetSet.Controls.Add(this.txtSimpleGetKey);
            this.grpSimpleGetSet.Controls.Add(this.btnSimpleGet);
            this.grpSimpleGetSet.Controls.Add(this.txtSimpleSetValue);
            this.grpSimpleGetSet.Controls.Add(this.label4);
            this.grpSimpleGetSet.Controls.Add(this.txtSimpleSetKey);
            this.grpSimpleGetSet.Controls.Add(this.label3);
            this.grpSimpleGetSet.Controls.Add(this.btnSimpleSet);
            this.grpSimpleGetSet.Location = new System.Drawing.Point(12, 102);
            this.grpSimpleGetSet.Name = "grpSimpleGetSet";
            this.grpSimpleGetSet.Size = new System.Drawing.Size(366, 100);
            this.grpSimpleGetSet.TabIndex = 1;
            this.grpSimpleGetSet.TabStop = false;
            this.grpSimpleGetSet.Text = "(2) Simple Set/Get";
            // 
            // txtSimpleGetValue
            // 
            this.txtSimpleGetValue.Location = new System.Drawing.Point(216, 64);
            this.txtSimpleGetValue.Name = "txtSimpleGetValue";
            this.txtSimpleGetValue.Size = new System.Drawing.Size(140, 20);
            this.txtSimpleGetValue.TabIndex = 8;
            // 
            // txtSimpleGetKey
            // 
            this.txtSimpleGetKey.Location = new System.Drawing.Point(65, 66);
            this.txtSimpleGetKey.Name = "txtSimpleGetKey";
            this.txtSimpleGetKey.Size = new System.Drawing.Size(140, 20);
            this.txtSimpleGetKey.TabIndex = 7;
            // 
            // btnSimpleGet
            // 
            this.btnSimpleGet.Location = new System.Drawing.Point(6, 64);
            this.btnSimpleGet.Name = "btnSimpleGet";
            this.btnSimpleGet.Size = new System.Drawing.Size(51, 23);
            this.btnSimpleGet.TabIndex = 6;
            this.btnSimpleGet.Text = "Get";
            this.btnSimpleGet.UseVisualStyleBackColor = true;
            this.btnSimpleGet.Click += new System.EventHandler(this.btnSimpleGet_Click);
            // 
            // txtSimpleSetValue
            // 
            this.txtSimpleSetValue.Location = new System.Drawing.Point(216, 38);
            this.txtSimpleSetValue.Name = "txtSimpleSetValue";
            this.txtSimpleSetValue.Size = new System.Drawing.Size(140, 20);
            this.txtSimpleSetValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Value";
            // 
            // txtSimpleSetKey
            // 
            this.txtSimpleSetKey.Location = new System.Drawing.Point(65, 40);
            this.txtSimpleSetKey.Name = "txtSimpleSetKey";
            this.txtSimpleSetKey.Size = new System.Drawing.Size(140, 20);
            this.txtSimpleSetKey.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Key";
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.numRedisPort);
            this.grpConnection.Controls.Add(this.txtRedisHost);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(12, 13);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(311, 83);
            this.grpConnection.TabIndex = 2;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "(1) Redis Server Connection";
            // 
            // numRedisPort
            // 
            this.numRedisPort.Location = new System.Drawing.Point(65, 45);
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
            this.txtRedisHost.Location = new System.Drawing.Point(65, 20);
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
            // grpList
            // 
            this.grpList.Controls.Add(this.btnReadAllListItems);
            this.grpList.Controls.Add(this.lbxListItems);
            this.grpList.Controls.Add(this.label6);
            this.grpList.Controls.Add(this.txtListNewItem);
            this.grpList.Controls.Add(this.btnAddToList);
            this.grpList.Controls.Add(this.txtListName);
            this.grpList.Controls.Add(this.label5);
            this.grpList.Location = new System.Drawing.Point(12, 208);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(366, 203);
            this.grpList.TabIndex = 3;
            this.grpList.TabStop = false;
            this.grpList.Text = "(3) List";
            // 
            // btnReadAllListItems
            // 
            this.btnReadAllListItems.Location = new System.Drawing.Point(216, 146);
            this.btnReadAllListItems.Name = "btnReadAllListItems";
            this.btnReadAllListItems.Size = new System.Drawing.Size(140, 23);
            this.btnReadAllListItems.TabIndex = 10;
            this.btnReadAllListItems.Text = "Read All Items";
            this.btnReadAllListItems.UseVisualStyleBackColor = true;
            this.btnReadAllListItems.Click += new System.EventHandler(this.btnReadAllListItems_Click);
            // 
            // lbxListItems
            // 
            this.lbxListItems.FormattingEnabled = true;
            this.lbxListItems.Location = new System.Drawing.Point(216, 19);
            this.lbxListItems.Name = "lbxListItems";
            this.lbxListItems.Size = new System.Drawing.Size(140, 121);
            this.lbxListItems.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "New Item";
            // 
            // txtListNewItem
            // 
            this.txtListNewItem.Location = new System.Drawing.Point(65, 45);
            this.txtListNewItem.Name = "txtListNewItem";
            this.txtListNewItem.Size = new System.Drawing.Size(140, 20);
            this.txtListNewItem.TabIndex = 7;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(65, 71);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(140, 23);
            this.btnAddToList.TabIndex = 5;
            this.btnAddToList.Text = "Add to List";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // txtListName
            // 
            this.txtListName.Location = new System.Drawing.Point(65, 19);
            this.txtListName.Name = "txtListName";
            this.txtListName.Size = new System.Drawing.Size(140, 20);
            this.txtListName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "List Name";
            // 
            // grpIncrementDecrement
            // 
            this.grpIncrementDecrement.Controls.Add(this.btnDecrement);
            this.grpIncrementDecrement.Controls.Add(this.btnIncrement);
            this.grpIncrementDecrement.Controls.Add(this.label8);
            this.grpIncrementDecrement.Controls.Add(this.label7);
            this.grpIncrementDecrement.Controls.Add(this.txtCounterValue);
            this.grpIncrementDecrement.Controls.Add(this.txtCounterName);
            this.grpIncrementDecrement.Controls.Add(this.btnCreateCounter);
            this.grpIncrementDecrement.Location = new System.Drawing.Point(384, 102);
            this.grpIncrementDecrement.Name = "grpIncrementDecrement";
            this.grpIncrementDecrement.Size = new System.Drawing.Size(248, 171);
            this.grpIncrementDecrement.TabIndex = 4;
            this.grpIncrementDecrement.TabStop = false;
            this.grpIncrementDecrement.Text = "(4) Increment/Decrement";
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(65, 135);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(140, 23);
            this.btnDecrement.TabIndex = 9;
            this.btnDecrement.Text = "Decrement";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(65, 106);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(140, 23);
            this.btnIncrement.TabIndex = 8;
            this.btnIncrement.Text = "Increment";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Name";
            // 
            // txtCounterValue
            // 
            this.txtCounterValue.Location = new System.Drawing.Point(65, 50);
            this.txtCounterValue.Name = "txtCounterValue";
            this.txtCounterValue.Size = new System.Drawing.Size(140, 20);
            this.txtCounterValue.TabIndex = 5;
            this.txtCounterValue.Text = "100";
            // 
            // txtCounterName
            // 
            this.txtCounterName.Location = new System.Drawing.Point(65, 24);
            this.txtCounterName.Name = "txtCounterName";
            this.txtCounterName.Size = new System.Drawing.Size(140, 20);
            this.txtCounterName.TabIndex = 4;
            this.txtCounterName.Text = "simpleCounter";
            // 
            // btnCreateCounter
            // 
            this.btnCreateCounter.Location = new System.Drawing.Point(65, 77);
            this.btnCreateCounter.Name = "btnCreateCounter";
            this.btnCreateCounter.Size = new System.Drawing.Size(140, 23);
            this.btnCreateCounter.TabIndex = 1;
            this.btnCreateCounter.Text = "Create";
            this.btnCreateCounter.UseVisualStyleBackColor = true;
            this.btnCreateCounter.Click += new System.EventHandler(this.btnCreateCounter_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 423);
            this.Controls.Add(this.grpIncrementDecrement);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.grpSimpleGetSet);
            this.Name = "FrmTest";
            this.Text = "Redis Tests";
            this.grpSimpleGetSet.ResumeLayout(false);
            this.grpSimpleGetSet.PerformLayout();
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.grpIncrementDecrement.ResumeLayout(false);
            this.grpIncrementDecrement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimpleSet;
        private System.Windows.Forms.GroupBox grpSimpleGetSet;
        private System.Windows.Forms.TextBox txtSimpleGetValue;
        private System.Windows.Forms.TextBox txtSimpleGetKey;
        private System.Windows.Forms.Button btnSimpleGet;
        private System.Windows.Forms.TextBox txtSimpleSetValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSimpleSetKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Button btnReadAllListItems;
        private System.Windows.Forms.ListBox lbxListItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtListNewItem;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.TextBox txtListName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpIncrementDecrement;
        private System.Windows.Forms.Button btnDecrement;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCounterValue;
        private System.Windows.Forms.TextBox txtCounterName;
        private System.Windows.Forms.Button btnCreateCounter;
    }
}

