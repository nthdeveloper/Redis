namespace HashSample
{
    partial class FrmHashSample
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
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHashName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.btnGetByKey = new System.Windows.Forms.Button();
            this.txtItemKey = new System.Windows.Forms.TextBox();
            this.btnReadAllItems = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRemoveList = new System.Windows.Forms.GroupBox();
            this.btnDeleteHash = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.grpAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.grpRemoveList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.numRedisPort);
            this.grpConnection.Controls.Add(this.txtRedisHost);
            this.grpConnection.Controls.Add(this.label2);
            this.grpConnection.Controls.Add(this.label1);
            this.grpConnection.Location = new System.Drawing.Point(12, 12);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(225, 83);
            this.grpConnection.TabIndex = 4;
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
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.btnUpdate);
            this.grpAdd.Controls.Add(this.txtHashName);
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.label6);
            this.grpAdd.Controls.Add(this.txtValue);
            this.grpAdd.Controls.Add(this.btnAdd);
            this.grpAdd.Controls.Add(this.txtKey);
            this.grpAdd.Controls.Add(this.label5);
            this.grpAdd.Location = new System.Drawing.Point(12, 101);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(225, 180);
            this.grpAdd.TabIndex = 5;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "(2) Add";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(73, 78);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(140, 20);
            this.txtValue.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(73, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(73, 52);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(140, 20);
            this.txtKey.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Key";
            // 
            // txtHashName
            // 
            this.txtHashName.Location = new System.Drawing.Point(73, 26);
            this.txtHashName.Name = "txtHashName";
            this.txtHashName.Size = new System.Drawing.Size(140, 20);
            this.txtHashName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hash Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveSelectedItem);
            this.groupBox1.Controls.Add(this.dgvEntries);
            this.groupBox1.Controls.Add(this.btnGetByKey);
            this.groupBox1.Controls.Add(this.txtItemKey);
            this.groupBox1.Controls.Add(this.btnReadAllItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 347);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(3) Retrieve";
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(8, 292);
            this.btnRemoveSelectedItem.Name = "btnRemoveSelectedItem";
            this.btnRemoveSelectedItem.Size = new System.Drawing.Size(163, 23);
            this.btnRemoveSelectedItem.TabIndex = 13;
            this.btnRemoveSelectedItem.Text = "Remove Selected Item";
            this.btnRemoveSelectedItem.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedItem.Click += new System.EventHandler(this.btnRemoveSelectedItem_Click);
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.AllowUserToOrderColumns = true;
            this.dgvEntries.AllowUserToResizeRows = false;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colValue});
            this.dgvEntries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEntries.Location = new System.Drawing.Point(8, 92);
            this.dgvEntries.MultiSelect = false;
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.RowHeadersVisible = false;
            this.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntries.ShowEditingIcon = false;
            this.dgvEntries.Size = new System.Drawing.Size(346, 194);
            this.dgvEntries.TabIndex = 12;
            // 
            // btnGetByKey
            // 
            this.btnGetByKey.Location = new System.Drawing.Point(177, 58);
            this.btnGetByKey.Name = "btnGetByKey";
            this.btnGetByKey.Size = new System.Drawing.Size(111, 23);
            this.btnGetByKey.TabIndex = 11;
            this.btnGetByKey.Text = "Get by Key";
            this.btnGetByKey.UseVisualStyleBackColor = true;
            this.btnGetByKey.Click += new System.EventHandler(this.btnGetByKey_Click);
            // 
            // txtItemKey
            // 
            this.txtItemKey.Location = new System.Drawing.Point(46, 61);
            this.txtItemKey.Name = "txtItemKey";
            this.txtItemKey.Size = new System.Drawing.Size(125, 20);
            this.txtItemKey.TabIndex = 4;
            // 
            // btnReadAllItems
            // 
            this.btnReadAllItems.Location = new System.Drawing.Point(8, 22);
            this.btnReadAllItems.Name = "btnReadAllItems";
            this.btnReadAllItems.Size = new System.Drawing.Size(163, 23);
            this.btnReadAllItems.TabIndex = 10;
            this.btnReadAllItems.Text = "Read All Items";
            this.btnReadAllItems.UseVisualStyleBackColor = true;
            this.btnReadAllItems.Click += new System.EventHandler(this.btnReadAllItems_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key";
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "Key";
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Width = 150;
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 150;
            // 
            // grpRemoveList
            // 
            this.grpRemoveList.Controls.Add(this.btnDeleteHash);
            this.grpRemoveList.Location = new System.Drawing.Point(12, 288);
            this.grpRemoveList.Name = "grpRemoveList";
            this.grpRemoveList.Size = new System.Drawing.Size(225, 71);
            this.grpRemoveList.TabIndex = 11;
            this.grpRemoveList.TabStop = false;
            this.grpRemoveList.Text = "(4) Delete Hash";
            // 
            // btnDeleteHash
            // 
            this.btnDeleteHash.Location = new System.Drawing.Point(12, 32);
            this.btnDeleteHash.Name = "btnDeleteHash";
            this.btnDeleteHash.Size = new System.Drawing.Size(193, 23);
            this.btnDeleteHash.TabIndex = 5;
            this.btnDeleteHash.Text = "Delete Hash";
            this.btnDeleteHash.UseVisualStyleBackColor = true;
            this.btnDeleteHash.Click += new System.EventHandler(this.btnDeleteHash_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(73, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 23);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmHashSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 371);
            this.Controls.Add(this.grpRemoveList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmHashSample";
            this.Text = "Hash Sample";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.grpRemoveList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.TextBox txtHashName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveSelectedItem;
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.Button btnGetByKey;
        private System.Windows.Forms.TextBox txtItemKey;
        private System.Windows.Forms.Button btnReadAllItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox grpRemoveList;
        private System.Windows.Forms.Button btnDeleteHash;
        private System.Windows.Forms.Button btnUpdate;
    }
}

