namespace easyERP
{
    partial class Memer_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Memer_Form));
            this.Employee_label = new System.Windows.Forms.Label();
            this.SelectMember_button = new System.Windows.Forms.Button();
            this.select_dataGridView = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberErrorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyERP_Member = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet3 = new easyERP.ERPDataSet3();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.UpdateMember_button = new System.Windows.Forms.Button();
            this.memberTableAdapter = new easyERP.ERPDataSet3TableAdapters.MemberTableAdapter();
            this.IInsertMember_button = new System.Windows.Forms.Button();
            this.DeleteMember_button = new System.Windows.Forms.Button();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.permissionName_label = new System.Windows.Forms.Label();
            this.memberName_label = new System.Windows.Forms.Label();
            this.memberName_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.memberAccount_label = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.memberAccount_textbox = new System.Windows.Forms.TextBox();
            this.memberID_label = new System.Windows.Forms.Label();
            this.memberID_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.error_comboBox = new System.Windows.Forms.ComboBox();
            this.error_label = new System.Windows.Forms.Label();
            this.ExportExcel_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP_Member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Employee_label
            // 
            this.Employee_label.AutoSize = true;
            this.Employee_label.Font = new System.Drawing.Font("標楷體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Employee_label.ForeColor = System.Drawing.Color.Red;
            this.Employee_label.Location = new System.Drawing.Point(297, 19);
            this.Employee_label.Name = "Employee_label";
            this.Employee_label.Size = new System.Drawing.Size(335, 32);
            this.Employee_label.TabIndex = 5;
            this.Employee_label.Text = "員工新增修改查詢系統";
            // 
            // SelectMember_button
            // 
            this.SelectMember_button.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectMember_button.Location = new System.Drawing.Point(131, 227);
            this.SelectMember_button.Name = "SelectMember_button";
            this.SelectMember_button.Size = new System.Drawing.Size(100, 45);
            this.SelectMember_button.TabIndex = 9;
            this.SelectMember_button.Text = "查詢";
            this.SelectMember_button.UseVisualStyleBackColor = true;
            this.SelectMember_button.Click += new System.EventHandler(this.SelectMember_button_Click);
            // 
            // select_dataGridView
            // 
            this.select_dataGridView.AllowUserToAddRows = false;
            this.select_dataGridView.AllowUserToDeleteRows = false;
            this.select_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.select_dataGridView.AutoGenerateColumns = false;
            this.select_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.select_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.select_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.select_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.select_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberAccountDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.permissionNameDataGridViewTextBoxColumn,
            this.memberErrorName});
            this.select_dataGridView.DataSource = this.easyERP_Member;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.select_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.select_dataGridView.Location = new System.Drawing.Point(53, 288);
            this.select_dataGridView.Name = "select_dataGridView";
            this.select_dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.select_dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.select_dataGridView.RowTemplate.Height = 24;
            this.select_dataGridView.Size = new System.Drawing.Size(800, 240);
            this.select_dataGridView.TabIndex = 10;
            this.select_dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Select_dataGridView_CellMouseClick);
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "員工ID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberAccountDataGridViewTextBoxColumn
            // 
            this.memberAccountDataGridViewTextBoxColumn.DataPropertyName = "memberAccount";
            this.memberAccountDataGridViewTextBoxColumn.HeaderText = "帳號";
            this.memberAccountDataGridViewTextBoxColumn.Name = "memberAccountDataGridViewTextBoxColumn";
            this.memberAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密碼";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionNameDataGridViewTextBoxColumn
            // 
            this.permissionNameDataGridViewTextBoxColumn.DataPropertyName = "permissionName";
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "職等";
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            this.permissionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberErrorName
            // 
            this.memberErrorName.DataPropertyName = "memberErrorName";
            this.memberErrorName.HeaderText = "狀態";
            this.memberErrorName.Name = "memberErrorName";
            this.memberErrorName.ReadOnly = true;
            // 
            // easyERP_Member
            // 
            this.easyERP_Member.DataMember = "Member";
            this.easyERP_Member.DataSource = this.eRPDataSet3;
            this.easyERP_Member.CurrentChanged += new System.EventHandler(this.EasyERP_Member_CurrentChanged);
            // 
            // eRPDataSet3
            // 
            this.eRPDataSet3.DataSetName = "ERPDataSet3";
            this.eRPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnFirstPage.Font = new System.Drawing.Font("標楷體", 11.25F);
            this.btnFirstPage.Location = new System.Drawing.Point(150, 548);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(95, 40);
            this.btnFirstPage.TabIndex = 11;
            this.btnFirstPage.Text = "第一頁";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnPreviousPage.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPreviousPage.Location = new System.Drawing.Point(275, 548);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(95, 40);
            this.btnPreviousPage.TabIndex = 12;
            this.btnPreviousPage.Text = "<<上一頁";
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnNextPage.Font = new System.Drawing.Font("標楷體", 11.25F);
            this.btnNextPage.Location = new System.Drawing.Point(579, 548);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(95, 40);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "下一頁>>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.Red;
            this.lbCurrentPage.Location = new System.Drawing.Point(424, 559);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(103, 29);
            this.lbCurrentPage.TabIndex = 15;
            this.lbCurrentPage.Text = "第  頁";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.Red;
            this.lbTotalPage.Location = new System.Drawing.Point(673, 658);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(103, 29);
            this.lbTotalPage.TabIndex = 16;
            this.lbTotalPage.Text = "共  頁";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudPageSize);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(131, 605);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 111);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定分頁";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "!請先設定分頁才可查詢";
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("標楷體", 11.25F);
            this.btnSet.Location = new System.Drawing.Point(341, 40);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(107, 42);
            this.btnSet.TabIndex = 28;
            this.btnSet.Text = "設  定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(245, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "列";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(27, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "每頁";
            // 
            // nudPageSize
            // 
            this.nudPageSize.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPageSize.Location = new System.Drawing.Point(101, 30);
            this.nudPageSize.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(127, 25);
            this.nudPageSize.TabIndex = 0;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.SystemColors.Control;
            this.btnLastPage.Font = new System.Drawing.Font("標楷體", 11.25F);
            this.btnLastPage.Location = new System.Drawing.Point(697, 548);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(95, 40);
            this.btnLastPage.TabIndex = 28;
            this.btnLastPage.Text = "最後頁";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // UpdateMember_button
            // 
            this.UpdateMember_button.Font = new System.Drawing.Font("標楷體", 14.25F);
            this.UpdateMember_button.Location = new System.Drawing.Point(261, 227);
            this.UpdateMember_button.Name = "UpdateMember_button";
            this.UpdateMember_button.Size = new System.Drawing.Size(100, 45);
            this.UpdateMember_button.TabIndex = 29;
            this.UpdateMember_button.Text = "修改";
            this.UpdateMember_button.UseVisualStyleBackColor = true;
            this.UpdateMember_button.Click += new System.EventHandler(this.UpdateMember_button_Click);
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // IInsertMember_button
            // 
            this.IInsertMember_button.Font = new System.Drawing.Font("標楷體", 14.25F);
            this.IInsertMember_button.Location = new System.Drawing.Point(523, 227);
            this.IInsertMember_button.Name = "IInsertMember_button";
            this.IInsertMember_button.Size = new System.Drawing.Size(100, 45);
            this.IInsertMember_button.TabIndex = 41;
            this.IInsertMember_button.Text = "新增";
            this.IInsertMember_button.UseVisualStyleBackColor = true;
            this.IInsertMember_button.Click += new System.EventHandler(this.IInsertMember_button_Click);
            // 
            // DeleteMember_button
            // 
            this.DeleteMember_button.Font = new System.Drawing.Font("標楷體", 14.25F);
            this.DeleteMember_button.Location = new System.Drawing.Point(393, 227);
            this.DeleteMember_button.Name = "DeleteMember_button";
            this.DeleteMember_button.Size = new System.Drawing.Size(100, 45);
            this.DeleteMember_button.TabIndex = 44;
            this.DeleteMember_button.Text = "刪除";
            this.DeleteMember_button.UseVisualStyleBackColor = true;
            this.DeleteMember_button.Click += new System.EventHandler(this.DeleteMember_button_Click);
            // 
            // status_comboBox
            // 
            this.status_comboBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.status_comboBox.ForeColor = System.Drawing.Color.Red;
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Location = new System.Drawing.Point(268, 183);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(153, 24);
            this.status_comboBox.TabIndex = 52;
            // 
            // permissionName_label
            // 
            this.permissionName_label.AutoSize = true;
            this.permissionName_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.permissionName_label.ForeColor = System.Drawing.Color.Red;
            this.permissionName_label.Location = new System.Drawing.Point(192, 183);
            this.permissionName_label.Name = "permissionName_label";
            this.permissionName_label.Size = new System.Drawing.Size(68, 27);
            this.permissionName_label.TabIndex = 51;
            this.permissionName_label.Text = "職等";
            // 
            // memberName_label
            // 
            this.memberName_label.AutoSize = true;
            this.memberName_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberName_label.ForeColor = System.Drawing.Color.Red;
            this.memberName_label.Location = new System.Drawing.Point(495, 126);
            this.memberName_label.Name = "memberName_label";
            this.memberName_label.Size = new System.Drawing.Size(68, 27);
            this.memberName_label.TabIndex = 50;
            this.memberName_label.Text = "姓名";
            // 
            // memberName_textBox
            // 
            this.memberName_textBox.Font = new System.Drawing.Font("新細明體", 14.25F);
            this.memberName_textBox.ForeColor = System.Drawing.Color.Red;
            this.memberName_textBox.Location = new System.Drawing.Point(569, 126);
            this.memberName_textBox.MaxLength = 10;
            this.memberName_textBox.Multiline = true;
            this.memberName_textBox.Name = "memberName_textBox";
            this.memberName_textBox.Size = new System.Drawing.Size(153, 27);
            this.memberName_textBox.TabIndex = 49;
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Password_label.ForeColor = System.Drawing.Color.Red;
            this.Password_label.Location = new System.Drawing.Point(192, 126);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(68, 27);
            this.Password_label.TabIndex = 48;
            this.Password_label.Text = "密碼";
            // 
            // memberAccount_label
            // 
            this.memberAccount_label.AutoSize = true;
            this.memberAccount_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberAccount_label.ForeColor = System.Drawing.Color.Red;
            this.memberAccount_label.Location = new System.Drawing.Point(192, 70);
            this.memberAccount_label.Name = "memberAccount_label";
            this.memberAccount_label.Size = new System.Drawing.Size(68, 27);
            this.memberAccount_label.TabIndex = 47;
            this.memberAccount_label.Text = "帳號";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("新細明體", 14.25F);
            this.password_textBox.ForeColor = System.Drawing.Color.Red;
            this.password_textBox.Location = new System.Drawing.Point(268, 126);
            this.password_textBox.MaxLength = 10;
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(153, 27);
            this.password_textBox.TabIndex = 46;
            // 
            // memberAccount_textbox
            // 
            this.memberAccount_textbox.BackColor = System.Drawing.SystemColors.Window;
            this.memberAccount_textbox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberAccount_textbox.ForeColor = System.Drawing.Color.Red;
            this.memberAccount_textbox.Location = new System.Drawing.Point(268, 70);
            this.memberAccount_textbox.MaxLength = 10;
            this.memberAccount_textbox.Multiline = true;
            this.memberAccount_textbox.Name = "memberAccount_textbox";
            this.memberAccount_textbox.Size = new System.Drawing.Size(153, 27);
            this.memberAccount_textbox.TabIndex = 45;
            // 
            // memberID_label
            // 
            this.memberID_label.AutoSize = true;
            this.memberID_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.memberID_label.ForeColor = System.Drawing.Color.Red;
            this.memberID_label.Location = new System.Drawing.Point(495, 70);
            this.memberID_label.Name = "memberID_label";
            this.memberID_label.Size = new System.Drawing.Size(96, 27);
            this.memberID_label.TabIndex = 54;
            this.memberID_label.Text = "員工ID";
            // 
            // memberID_textBox
            // 
            this.memberID_textBox.Font = new System.Drawing.Font("新細明體", 14.25F);
            this.memberID_textBox.ForeColor = System.Drawing.Color.Red;
            this.memberID_textBox.Location = new System.Drawing.Point(597, 68);
            this.memberID_textBox.MaxLength = 10;
            this.memberID_textBox.Multiline = true;
            this.memberID_textBox.Name = "memberID_textBox";
            this.memberID_textBox.Size = new System.Drawing.Size(153, 27);
            this.memberID_textBox.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_four;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 744);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // error_comboBox
            // 
            this.error_comboBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.error_comboBox.ForeColor = System.Drawing.Color.Red;
            this.error_comboBox.FormattingEnabled = true;
            this.error_comboBox.Location = new System.Drawing.Point(571, 183);
            this.error_comboBox.Name = "error_comboBox";
            this.error_comboBox.Size = new System.Drawing.Size(153, 24);
            this.error_comboBox.TabIndex = 56;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(495, 183);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(68, 27);
            this.error_label.TabIndex = 55;
            this.error_label.Text = "狀態";
            // 
            // ExportExcel_button
            // 
            this.ExportExcel_button.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExportExcel_button.Location = new System.Drawing.Point(650, 227);
            this.ExportExcel_button.Name = "ExportExcel_button";
            this.ExportExcel_button.Size = new System.Drawing.Size(100, 45);
            this.ExportExcel_button.TabIndex = 58;
            this.ExportExcel_button.Text = "匯出EXCEL表單";
            this.ExportExcel_button.UseVisualStyleBackColor = true;
            this.ExportExcel_button.Click += new System.EventHandler(this.ExportExcel_button_Click);
            // 
            // Memer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 738);
            this.Controls.Add(this.ExportExcel_button);
            this.Controls.Add(this.error_comboBox);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.memberID_label);
            this.Controls.Add(this.memberID_textBox);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.permissionName_label);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.memberName_label);
            this.Controls.Add(this.memberName_textBox);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.memberAccount_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.memberAccount_textbox);
            this.Controls.Add(this.DeleteMember_button);
            this.Controls.Add(this.IInsertMember_button);
            this.Controls.Add(this.UpdateMember_button);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.select_dataGridView);
            this.Controls.Add(this.SelectMember_button);
            this.Controls.Add(this.Employee_label);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Memer_Form";
            this.Text = "easyERP-員工系統";
            this.Load += new System.EventHandler(this.SelectMemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP_Member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Employee_label;
        private System.Windows.Forms.DataGridView select_dataGridView;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPageSize;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button UpdateMember_button;
        private ERPDataSet3 eRPDataSet3;
        private System.Windows.Forms.BindingSource easyERP_Member;
        private ERPDataSet3TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Button IInsertMember_button;
        private System.Windows.Forms.Button DeleteMember_button;
        public System.Windows.Forms.Button SelectMember_button;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Label permissionName_label;
        private System.Windows.Forms.Label memberName_label;
        private System.Windows.Forms.TextBox memberName_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label memberAccount_label;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox memberAccount_textbox;
        private System.Windows.Forms.Label memberID_label;
        private System.Windows.Forms.TextBox memberID_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox error_comboBox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberErrorName;
        private System.Windows.Forms.Button ExportExcel_button;
    }
}