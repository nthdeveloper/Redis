namespace SortedSetSample
{
    partial class FrmSortedSetSample
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedItem = new System.Windows.Forms.Button();
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.btnGetByKey = new System.Windows.Forms.Button();
            this.txtGetItemKey = new System.Windows.Forms.TextBox();
            this.btnReadAllItems = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.grpRemoveList = new System.Windows.Forms.GroupBox();
            this.btnDeleteSortedSet = new System.Windows.Forms.Button();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.numItemScore = new System.Windows.Forms.NumericUpDown();
            this.btnIncrementScore = new System.Windows.Forms.Button();
            this.txtSortedSetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToSortedSet = new System.Windows.Forms.Button();
            this.txtItemKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numStartIndex = new System.Windows.Forms.NumericUpDown();
            this.numEndIndex = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGetRangeByIndex = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGetRangeByScore = new System.Windows.Forms.Button();
            this.numEndScore = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numStartScore = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetHighestScoredItem = new System.Windows.Forms.Button();
            this.btnGetLowestScoredItem = new System.Windows.Forms.Button();
            this.numItemCount = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.grpRemoveList.SuspendLayout();
            this.grpAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemScore)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndIndex)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartScore)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).BeginInit();
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
            this.grpConnection.TabIndex = 7;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnRemoveSelectedItem);
            this.groupBox1.Controls.Add(this.dgvEntries);
            this.groupBox1.Controls.Add(this.btnReadAllItems);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 431);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "(3) Retrieve";
            // 
            // btnRemoveSelectedItem
            // 
            this.btnRemoveSelectedItem.Location = new System.Drawing.Point(266, 353);
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
            this.dgvEntries.Location = new System.Drawing.Point(266, 19);
            this.dgvEntries.MultiSelect = false;
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.RowHeadersVisible = false;
            this.dgvEntries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntries.ShowEditingIcon = false;
            this.dgvEntries.Size = new System.Drawing.Size(302, 328);
            this.dgvEntries.TabIndex = 12;
            // 
            // btnGetByKey
            // 
            this.btnGetByKey.Location = new System.Drawing.Point(191, 22);
            this.btnGetByKey.Name = "btnGetByKey";
            this.btnGetByKey.Size = new System.Drawing.Size(51, 23);
            this.btnGetByKey.TabIndex = 11;
            this.btnGetByKey.Text = "Get";
            this.btnGetByKey.UseVisualStyleBackColor = true;
            this.btnGetByKey.Click += new System.EventHandler(this.btnGetByKey_Click);
            // 
            // txtGetItemKey
            // 
            this.txtGetItemKey.Location = new System.Drawing.Point(47, 24);
            this.txtGetItemKey.Name = "txtGetItemKey";
            this.txtGetItemKey.Size = new System.Drawing.Size(138, 20);
            this.txtGetItemKey.TabIndex = 4;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Key";
            // 
            // grpRemoveList
            // 
            this.grpRemoveList.Controls.Add(this.btnDeleteSortedSet);
            this.grpRemoveList.Location = new System.Drawing.Point(12, 288);
            this.grpRemoveList.Name = "grpRemoveList";
            this.grpRemoveList.Size = new System.Drawing.Size(225, 71);
            this.grpRemoveList.TabIndex = 16;
            this.grpRemoveList.TabStop = false;
            this.grpRemoveList.Text = "(4) Delete Set";
            // 
            // btnDeleteSortedSet
            // 
            this.btnDeleteSortedSet.Location = new System.Drawing.Point(12, 32);
            this.btnDeleteSortedSet.Name = "btnDeleteSortedSet";
            this.btnDeleteSortedSet.Size = new System.Drawing.Size(193, 23);
            this.btnDeleteSortedSet.TabIndex = 5;
            this.btnDeleteSortedSet.Text = "Delete Set";
            this.btnDeleteSortedSet.UseVisualStyleBackColor = true;
            this.btnDeleteSortedSet.Click += new System.EventHandler(this.btnDeleteSortedSet_Click);
            // 
            // grpAdd
            // 
            this.grpAdd.Controls.Add(this.numItemScore);
            this.grpAdd.Controls.Add(this.btnIncrementScore);
            this.grpAdd.Controls.Add(this.txtSortedSetName);
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.label4);
            this.grpAdd.Controls.Add(this.btnAddToSortedSet);
            this.grpAdd.Controls.Add(this.txtItemKey);
            this.grpAdd.Controls.Add(this.label7);
            this.grpAdd.Location = new System.Drawing.Point(12, 101);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(225, 180);
            this.grpAdd.TabIndex = 15;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "(2) Add";
            // 
            // numItemScore
            // 
            this.numItemScore.Location = new System.Drawing.Point(73, 77);
            this.numItemScore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numItemScore.Name = "numItemScore";
            this.numItemScore.Size = new System.Drawing.Size(140, 20);
            this.numItemScore.TabIndex = 12;
            // 
            // btnIncrementScore
            // 
            this.btnIncrementScore.Location = new System.Drawing.Point(73, 144);
            this.btnIncrementScore.Name = "btnIncrementScore";
            this.btnIncrementScore.Size = new System.Drawing.Size(140, 23);
            this.btnIncrementScore.TabIndex = 11;
            this.btnIncrementScore.Text = "Increment Score";
            this.btnIncrementScore.UseVisualStyleBackColor = true;
            this.btnIncrementScore.Click += new System.EventHandler(this.btnIncrementScore_Click);
            // 
            // txtSortedSetName
            // 
            this.txtSortedSetName.Location = new System.Drawing.Point(73, 26);
            this.txtSortedSetName.Name = "txtSortedSetName";
            this.txtSortedSetName.Size = new System.Drawing.Size(140, 20);
            this.txtSortedSetName.TabIndex = 10;
            this.txtSortedSetName.Text = "gamers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Set Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Score";
            // 
            // btnAddToSortedSet
            // 
            this.btnAddToSortedSet.Location = new System.Drawing.Point(73, 107);
            this.btnAddToSortedSet.Name = "btnAddToSortedSet";
            this.btnAddToSortedSet.Size = new System.Drawing.Size(140, 23);
            this.btnAddToSortedSet.TabIndex = 5;
            this.btnAddToSortedSet.Text = "Add";
            this.btnAddToSortedSet.UseVisualStyleBackColor = true;
            this.btnAddToSortedSet.Click += new System.EventHandler(this.btnAddToSortedSet_Click);
            // 
            // txtItemKey
            // 
            this.txtItemKey.Location = new System.Drawing.Point(73, 52);
            this.txtItemKey.Name = "txtItemKey";
            this.txtItemKey.Size = new System.Drawing.Size(140, 20);
            this.txtItemKey.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Key";
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "Key";
            this.colKey.HeaderText = "Key";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Width = 125;
            // 
            // colValue
            // 
            this.colValue.DataPropertyName = "Value";
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            this.colValue.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGetItemKey);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnGetByKey);
            this.groupBox2.Location = new System.Drawing.Point(8, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 54);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Single Item by Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGetRangeByIndex);
            this.groupBox3.Controls.Add(this.numEndIndex);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.numStartIndex);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 101);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Range by Index";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Start Index";
            // 
            // numStartIndex
            // 
            this.numStartIndex.Location = new System.Drawing.Point(84, 23);
            this.numStartIndex.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStartIndex.Name = "numStartIndex";
            this.numStartIndex.Size = new System.Drawing.Size(103, 20);
            this.numStartIndex.TabIndex = 13;
            // 
            // numEndIndex
            // 
            this.numEndIndex.Location = new System.Drawing.Point(84, 48);
            this.numEndIndex.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numEndIndex.Name = "numEndIndex";
            this.numEndIndex.Size = new System.Drawing.Size(103, 20);
            this.numEndIndex.TabIndex = 15;
            this.numEndIndex.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "End Index";
            // 
            // btnGetRangeByIndex
            // 
            this.btnGetRangeByIndex.Location = new System.Drawing.Point(84, 73);
            this.btnGetRangeByIndex.Name = "btnGetRangeByIndex";
            this.btnGetRangeByIndex.Size = new System.Drawing.Size(51, 23);
            this.btnGetRangeByIndex.TabIndex = 16;
            this.btnGetRangeByIndex.Text = "Get";
            this.btnGetRangeByIndex.UseVisualStyleBackColor = true;
            this.btnGetRangeByIndex.Click += new System.EventHandler(this.btnGetRangeByIndex_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGetRangeByScore);
            this.groupBox4.Controls.Add(this.numEndScore);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numStartScore);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(8, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 101);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Range by Score";
            // 
            // btnGetRangeByScore
            // 
            this.btnGetRangeByScore.Location = new System.Drawing.Point(84, 73);
            this.btnGetRangeByScore.Name = "btnGetRangeByScore";
            this.btnGetRangeByScore.Size = new System.Drawing.Size(51, 23);
            this.btnGetRangeByScore.TabIndex = 16;
            this.btnGetRangeByScore.Text = "Get";
            this.btnGetRangeByScore.UseVisualStyleBackColor = true;
            this.btnGetRangeByScore.Click += new System.EventHandler(this.btnGetRangeByScore_Click);
            // 
            // numEndScore
            // 
            this.numEndScore.Location = new System.Drawing.Point(84, 48);
            this.numEndScore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numEndScore.Name = "numEndScore";
            this.numEndScore.Size = new System.Drawing.Size(103, 20);
            this.numEndScore.TabIndex = 15;
            this.numEndScore.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "End Score";
            // 
            // numStartScore
            // 
            this.numStartScore.Location = new System.Drawing.Point(84, 23);
            this.numStartScore.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numStartScore.Name = "numStartScore";
            this.numStartScore.Size = new System.Drawing.Size(103, 20);
            this.numStartScore.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Start Score";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.numItemCount);
            this.groupBox5.Controls.Add(this.btnGetLowestScoredItem);
            this.groupBox5.Controls.Add(this.btnGetHighestScoredItem);
            this.groupBox5.Location = new System.Drawing.Point(8, 337);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 88);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Highest/Lowest";
            // 
            // btnGetHighestScoredItem
            // 
            this.btnGetHighestScoredItem.Location = new System.Drawing.Point(81, 21);
            this.btnGetHighestScoredItem.Name = "btnGetHighestScoredItem";
            this.btnGetHighestScoredItem.Size = new System.Drawing.Size(163, 23);
            this.btnGetHighestScoredItem.TabIndex = 11;
            this.btnGetHighestScoredItem.Text = "Get (n) Highest Scored Item";
            this.btnGetHighestScoredItem.UseVisualStyleBackColor = true;
            this.btnGetHighestScoredItem.Click += new System.EventHandler(this.btnGetHighestScoredItem_Click);
            // 
            // btnGetLowestScoredItem
            // 
            this.btnGetLowestScoredItem.Location = new System.Drawing.Point(81, 50);
            this.btnGetLowestScoredItem.Name = "btnGetLowestScoredItem";
            this.btnGetLowestScoredItem.Size = new System.Drawing.Size(163, 23);
            this.btnGetLowestScoredItem.TabIndex = 12;
            this.btnGetLowestScoredItem.Text = "Get (n) Lowest Scored Item";
            this.btnGetLowestScoredItem.UseVisualStyleBackColor = true;
            this.btnGetLowestScoredItem.Click += new System.EventHandler(this.btnGetLowestScoredItem_Click);
            // 
            // numItemCount
            // 
            this.numItemCount.Location = new System.Drawing.Point(28, 24);
            this.numItemCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numItemCount.Name = "numItemCount";
            this.numItemCount.Size = new System.Drawing.Size(45, 20);
            this.numItemCount.TabIndex = 14;
            this.numItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "n";
            // 
            // FrmSortedSetSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpRemoveList);
            this.Controls.Add(this.grpAdd);
            this.Controls.Add(this.grpConnection);
            this.Name = "FrmSortedSetSample";
            this.Text = "Sorted Set Samples";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRedisPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.grpRemoveList.ResumeLayout(false);
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemScore)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndIndex)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEndScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartScore)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.NumericUpDown numRedisPort;
        private System.Windows.Forms.TextBox txtRedisHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveSelectedItem;
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.Button btnGetByKey;
        private System.Windows.Forms.TextBox txtGetItemKey;
        private System.Windows.Forms.Button btnReadAllItems;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpRemoveList;
        private System.Windows.Forms.Button btnDeleteSortedSet;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.NumericUpDown numItemScore;
        private System.Windows.Forms.Button btnIncrementScore;
        private System.Windows.Forms.TextBox txtSortedSetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToSortedSet;
        private System.Windows.Forms.TextBox txtItemKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGetRangeByIndex;
        private System.Windows.Forms.NumericUpDown numEndIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numStartIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetRangeByScore;
        private System.Windows.Forms.NumericUpDown numEndScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numStartScore;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnGetLowestScoredItem;
        private System.Windows.Forms.Button btnGetHighestScoredItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numItemCount;
    }
}

