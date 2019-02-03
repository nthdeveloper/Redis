namespace SetSample
{
    partial class FrmSetSample
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
            this.numRedisPort = new System.Windows.Forms.NumericUpDown();
            this.txtRedisHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFromSet = new System.Windows.Forms.Button();
            this.btnDeleteSet = new System.Windows.Forms.Button();
            this.btnReadAllSetItems = new System.Windows.Forms.Button();
            this.lbxSetItems = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.txtSetNewItem = new System.Windows.Forms.TextBox();
            this.btnAddToSet = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpRemoveList = new System.Windows.Forms.GroupBox();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpRemoveList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.numRedisPort);
            this.grpConnection.Controls.Add(this.txtRedisHost);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(14, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(214, 83);
            this.grpConnection.TabIndex = 6;
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
            // btnRemoveFromSet
            // 
            this.btnRemoveFromSet.Location = new System.Drawing.Point(150, 22);
            this.btnRemoveFromSet.Name = "btnRemoveFromSet";
            this.btnRemoveFromSet.Size = new System.Drawing.Size(76, 55);
            this.btnRemoveFromSet.TabIndex = 12;
            this.btnRemoveFromSet.Text = "Remove Selected Item";
            this.btnRemoveFromSet.UseVisualStyleBackColor = true;
            this.btnRemoveFromSet.Click += new System.EventHandler(this.btnRemoveFromSet_Click);
            // 
            // btnDeleteSet
            // 
            this.btnDeleteSet.Location = new System.Drawing.Point(6, 32);
            this.btnDeleteSet.Name = "btnDeleteSet";
            this.btnDeleteSet.Size = new System.Drawing.Size(140, 23);
            this.btnDeleteSet.TabIndex = 11;
            this.btnDeleteSet.Text = "Delete Set";
            this.btnDeleteSet.UseVisualStyleBackColor = true;
            this.btnDeleteSet.Click += new System.EventHandler(this.btnDeleteSet_Click);
            // 
            // btnReadAllSetItems
            // 
            this.btnReadAllSetItems.Location = new System.Drawing.Point(6, 149);
            this.btnReadAllSetItems.Name = "btnReadAllSetItems";
            this.btnReadAllSetItems.Size = new System.Drawing.Size(140, 23);
            this.btnReadAllSetItems.TabIndex = 10;
            this.btnReadAllSetItems.Text = "Read All Items";
            this.btnReadAllSetItems.UseVisualStyleBackColor = true;
            this.btnReadAllSetItems.Click += new System.EventHandler(this.btnReadAllSetItems_Click);
            // 
            // lbxSetItems
            // 
            this.lbxSetItems.FormattingEnabled = true;
            this.lbxSetItems.Location = new System.Drawing.Point(6, 22);
            this.lbxSetItems.Name = "lbxSetItems";
            this.lbxSetItems.Size = new System.Drawing.Size(140, 121);
            this.lbxSetItems.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Set Name";
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
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(65, 19);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(140, 20);
            this.txtSetName.TabIndex = 4;
            // 
            // txtSetNewItem
            // 
            this.txtSetNewItem.Location = new System.Drawing.Point(65, 45);
            this.txtSetNewItem.Name = "txtSetNewItem";
            this.txtSetNewItem.Size = new System.Drawing.Size(140, 20);
            this.txtSetNewItem.TabIndex = 7;
            // 
            // btnAddToSet
            // 
            this.btnAddToSet.Location = new System.Drawing.Point(65, 71);
            this.btnAddToSet.Name = "btnAddToSet";
            this.btnAddToSet.Size = new System.Drawing.Size(140, 23);
            this.btnAddToSet.TabIndex = 5;
            this.btnAddToSet.Text = "Add to Set";
            this.btnAddToSet.UseVisualStyleBackColor = true;
            this.btnAddToSet.Click += new System.EventHandler(this.btnAddToSet_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.txtSetName);
            this.grpAdd.Controls.Add(this.label6);
            this.grpAdd.Controls.Add(this.txtSetNewItem);
            this.grpAdd.Controls.Add(this.btnAddToSet);
            this.grpAdd.Controls.Add(this.label5);
            this.grpAdd.Location = new System.Drawing.Point(14, 101);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(214, 104);
            this.grpAdd.TabIndex = 16;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "(2) Add";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxSetItems);
            this.groupBox1.Controls.Add(this.btnReadAllSetItems);
            this.groupBox1.Controls.Add(this.btnRemoveFromSet);
            this.groupBox1.Location = new System.Drawing.Point(236, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 193);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(3) Retrieve";
            // 
            // grpRemoveList
            // 
            this.grpRemoveList.Controls.Add(this.btnDeleteSet);
            this.grpRemoveList.Location = new System.Drawing.Point(14, 211);
            this.grpRemoveList.Name = "grpRemoveList";
            this.grpRemoveList.Size = new System.Drawing.Size(216, 71);
            this.grpRemoveList.TabIndex = 18;
            this.grpRemoveList.TabStop = false;
            this.grpRemoveList.Text = "(4) Delete Set";
            // 
            // FrmSetSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 290);
            this.Controls.Add(this.grpRemoveList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmSetSample";
            this.Text = "Set Samples";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpRemoveList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveFromSet;
        private System.Windows.Forms.Button btnDeleteSet;
        private System.Windows.Forms.Button btnReadAllSetItems;
        private System.Windows.Forms.ListBox lbxSetItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.TextBox txtSetNewItem;
        private System.Windows.Forms.Button btnAddToSet;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grpRemoveList;
    }
}

