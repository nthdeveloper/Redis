namespace RedisTypedClientSample
{
    partial class FrmTypedClientyTest
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
            this.grpList = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReadAllItems = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetById = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPerson = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.grpList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
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
            this.grpConnection.TabIndex = 3;
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
            this.grpList.Controls.Add(this.label6);
            this.grpList.Controls.Add(this.txtSurname);
            this.grpList.Controls.Add(this.btnAdd);
            this.grpList.Controls.Add(this.txtName);
            this.grpList.Controls.Add(this.label5);
            this.grpList.Location = new System.Drawing.Point(12, 101);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(225, 203);
            this.grpList.TabIndex = 4;
            this.grpList.TabStop = false;
            this.grpList.Text = "(2) Add";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(65, 45);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(140, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 75);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(140, 20);
            this.txtName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPerson);
            this.groupBox1.Controls.Add(this.btnGetById);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.btnReadAllItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 292);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(3) Retrieve";
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(177, 58);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(111, 23);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "Get by Id";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(46, 61);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(125, 20);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id";
            // 
            // dgvPerson
            // 
            this.dgvPerson.AllowUserToAddRows = false;
            this.dgvPerson.AllowUserToDeleteRows = false;
            this.dgvPerson.AllowUserToOrderColumns = true;
            this.dgvPerson.AllowUserToResizeRows = false;
            this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colSurname});
            this.dgvPerson.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPerson.Location = new System.Drawing.Point(8, 92);
            this.dgvPerson.Name = "dgvPerson";
            this.dgvPerson.RowHeadersVisible = false;
            this.dgvPerson.ShowEditingIcon = false;
            this.dgvPerson.Size = new System.Drawing.Size(346, 194);
            this.dgvPerson.TabIndex = 12;
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.ReadOnly = true;
            // 
            // FrmTypedClientyTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 313);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmTypedClientyTest";
            this.Text = "Typed Client Test";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReadAllItems;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSurname;
    }
}

