namespace easyERP
{
    partial class selectMemer_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectMemer_Form));
            this.pictureBox_one = new System.Windows.Forms.PictureBox();
            this.label_title_one = new System.Windows.Forms.Label();
            this.label_title_two = new System.Windows.Forms.Label();
            this.useraccount_textBox = new System.Windows.Forms.TextBox();
            this.selectMember_button = new System.Windows.Forms.Button();
            this.label_title_three = new System.Windows.Forms.Label();
            this.label_title_four = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.updateMember_button = new System.Windows.Forms.Button();
            this.select_dataGridView = new System.Windows.Forms.DataGridView();
            this.memberAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyERP_Member = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet1 = new easyERP.ERPDataSet1();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eRPDataSet = new easyERP.ERPDataSet();
            this.memberTableAdapter = new easyERP.ERPDataSetTableAdapters.MemberTableAdapter();
            this.memberTableAdapter1 = new easyERP.ERPDataSet1TableAdapters.MemberTableAdapter();
            this.update_password_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update_useraccount_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.update_id_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.update_username_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_one)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP_Member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_one
            // 
            this.pictureBox_one.Image = global::easyERP.Properties.Resources.view_four;
            this.pictureBox_one.Location = new System.Drawing.Point(1, -2);
            this.pictureBox_one.Name = "pictureBox_one";
            this.pictureBox_one.Size = new System.Drawing.Size(1030, 742);
            this.pictureBox_one.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_one.TabIndex = 0;
            this.pictureBox_one.TabStop = false;
            // 
            // label_title_one
            // 
            this.label_title_one.AutoSize = true;
            this.label_title_one.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label_title_one.ForeColor = System.Drawing.Color.Maroon;
            this.label_title_one.Location = new System.Drawing.Point(349, 18);
            this.label_title_one.Name = "label_title_one";
            this.label_title_one.Size = new System.Drawing.Size(193, 29);
            this.label_title_one.TabIndex = 1;
            this.label_title_one.Text = "員工查詢系統";
            // 
            // label_title_two
            // 
            this.label_title_two.AutoSize = true;
            this.label_title_two.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label_title_two.ForeColor = System.Drawing.Color.Maroon;
            this.label_title_two.Location = new System.Drawing.Point(331, 63);
            this.label_title_two.Name = "label_title_two";
            this.label_title_two.Size = new System.Drawing.Size(223, 29);
            this.label_title_two.TabIndex = 2;
            this.label_title_two.Text = "請輸入帳號密碼";
            // 
            // useraccount_textBox
            // 
            this.useraccount_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.useraccount_textBox.Location = new System.Drawing.Point(258, 117);
            this.useraccount_textBox.Multiline = true;
            this.useraccount_textBox.Name = "useraccount_textBox";
            this.useraccount_textBox.Size = new System.Drawing.Size(150, 29);
            this.useraccount_textBox.TabIndex = 3;
            this.useraccount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectMember_button
            // 
            this.selectMember_button.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectMember_button.Location = new System.Drawing.Point(732, 101);
            this.selectMember_button.Name = "selectMember_button";
            this.selectMember_button.Size = new System.Drawing.Size(133, 45);
            this.selectMember_button.TabIndex = 5;
            this.selectMember_button.Text = "查詢";
            this.selectMember_button.UseVisualStyleBackColor = true;
            this.selectMember_button.Click += new System.EventHandler(this.SelectMember_button_Click);
            // 
            // label_title_three
            // 
            this.label_title_three.AutoSize = true;
            this.label_title_three.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label_title_three.ForeColor = System.Drawing.Color.Maroon;
            this.label_title_three.Location = new System.Drawing.Point(179, 117);
            this.label_title_three.Name = "label_title_three";
            this.label_title_three.Size = new System.Drawing.Size(73, 29);
            this.label_title_three.TabIndex = 8;
            this.label_title_three.Text = "帳號";
            // 
            // label_title_four
            // 
            this.label_title_four.AutoSize = true;
            this.label_title_four.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label_title_four.ForeColor = System.Drawing.Color.Maroon;
            this.label_title_four.Location = new System.Drawing.Point(451, 117);
            this.label_title_four.Name = "label_title_four";
            this.label_title_four.Size = new System.Drawing.Size(73, 29);
            this.label_title_four.TabIndex = 9;
            this.label_title_four.Text = "密碼";
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.password_textBox.Location = new System.Drawing.Point(530, 117);
            this.password_textBox.Multiline = true;
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(150, 29);
            this.password_textBox.TabIndex = 10;
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updateMember_button
            // 
            this.updateMember_button.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.updateMember_button.Location = new System.Drawing.Point(848, 663);
            this.updateMember_button.Name = "updateMember_button";
            this.updateMember_button.Size = new System.Drawing.Size(133, 45);
            this.updateMember_button.TabIndex = 11;
            this.updateMember_button.Text = "修改";
            this.updateMember_button.UseVisualStyleBackColor = true;
            this.updateMember_button.Click += new System.EventHandler(this.UpdateMember_button_Click);
            // 
            // select_dataGridView
            // 
            this.select_dataGridView.AllowUserToAddRows = false;
            this.select_dataGridView.AllowUserToDeleteRows = false;
            this.select_dataGridView.AutoGenerateColumns = false;
            this.select_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.select_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberAccountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.permissionNameDataGridViewTextBoxColumn});
            this.select_dataGridView.DataSource = this.easyERP_Member;
            this.select_dataGridView.Location = new System.Drawing.Point(49, 162);
            this.select_dataGridView.Name = "select_dataGridView";
            this.select_dataGridView.ReadOnly = true;
            this.select_dataGridView.RowTemplate.Height = 24;
            this.select_dataGridView.Size = new System.Drawing.Size(450, 184);
            this.select_dataGridView.TabIndex = 13;
            this.select_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Select_dataGridView_CellContentClick);
            // 
            // memberAccountDataGridViewTextBoxColumn
            // 
            this.memberAccountDataGridViewTextBoxColumn.DataPropertyName = "memberAccount";
            this.memberAccountDataGridViewTextBoxColumn.HeaderText = "帳號";
            this.memberAccountDataGridViewTextBoxColumn.Name = "memberAccountDataGridViewTextBoxColumn";
            this.memberAccountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密碼";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // permissionNameDataGridViewTextBoxColumn
            // 
            this.permissionNameDataGridViewTextBoxColumn.DataPropertyName = "permissionName";
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "狀態";
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            this.permissionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // easyERP_Member
            // 
            this.easyERP_Member.DataMember = "Member";
            this.easyERP_Member.DataSource = this.eRPDataSet1;
            this.easyERP_Member.CurrentChanged += new System.EventHandler(this.MemberBindingSource1_CurrentChanged);
            // 
            // eRPDataSet1
            // 
            this.eRPDataSet1.DataSetName = "ERPDataSet1";
            this.eRPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFirstPage.Location = new System.Drawing.Point(19, 364);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(98, 32);
            this.btnFirstPage.TabIndex = 14;
            this.btnFirstPage.Text = "第一頁";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPreviousPage.Location = new System.Drawing.Point(153, 364);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(98, 32);
            this.btnPreviousPage.TabIndex = 15;
            this.btnPreviousPage.Text = "<<上一頁";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNextPage.Location = new System.Drawing.Point(401, 364);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(98, 32);
            this.btnNextPage.TabIndex = 16;
            this.btnNextPage.Text = "下一頁>>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastPage.Location = new System.Drawing.Point(530, 369);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(98, 32);
            this.btnLastPage.TabIndex = 17;
            this.btnLastPage.Text = "最後頁";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSet.Location = new System.Drawing.Point(285, 38);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(98, 32);
            this.btnSet.TabIndex = 18;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // nudPageSize
            // 
            this.nudPageSize.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nudPageSize.Location = new System.Drawing.Point(87, 42);
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(73, 30);
            this.nudPageSize.TabIndex = 19;
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.Maroon;
            this.lbCurrentPage.Location = new System.Drawing.Point(275, 367);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(103, 29);
            this.lbCurrentPage.TabIndex = 20;
            this.lbCurrentPage.Text = "第  頁";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(8, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "每頁";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.Maroon;
            this.lbTotalPage.Location = new System.Drawing.Point(555, 459);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(73, 29);
            this.lbTotalPage.TabIndex = 23;
            this.lbTotalPage.Text = "共頁";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudPageSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(26, 423);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定分頁";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(193, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "列";
            // 
            // eRPDataSet
            // 
            this.eRPDataSet.DataSetName = "ERPDataSet";
         this.eRPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // update_password_textBox
            // 
            this.update_password_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_password_textBox.Location = new System.Drawing.Point(374, 615);
            this.update_password_textBox.Multiline = true;
            this.update_password_textBox.Name = "update_password_textBox";
            this.update_password_textBox.Size = new System.Drawing.Size(150, 29);
            this.update_password_textBox.TabIndex = 28;
            this.update_password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(295, 615);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 27;
            this.label2.Text = "密碼";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(23, 615);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "帳號";
            // 
            // update_useraccount_textBox
            // 
            this.update_useraccount_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_useraccount_textBox.Location = new System.Drawing.Point(102, 615);
            this.update_useraccount_textBox.Multiline = true;
            this.update_useraccount_textBox.Name = "update_useraccount_textBox";
            this.update_useraccount_textBox.Size = new System.Drawing.Size(150, 29);
            this.update_useraccount_textBox.TabIndex = 25;
            this.update_useraccount_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(21, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "請輸入要修改帳號密碼";
            // 
            // update_id_textBox
            // 
            this.update_id_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_id_textBox.Location = new System.Drawing.Point(511, 670);
            this.update_id_textBox.Multiline = true;
            this.update_id_textBox.Name = "update_id_textBox";
            this.update_id_textBox.Size = new System.Drawing.Size(150, 29);
            this.update_id_textBox.TabIndex = 30;
            this.update_id_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(451, 667);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 21.75F);
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(22, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "姓名";
            // 
            // update_username_textBox
            // 
            this.update_username_textBox.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.update_username_textBox.Location = new System.Drawing.Point(101, 670);
            this.update_username_textBox.Multiline = true;
            this.update_username_textBox.Name = "update_username_textBox";
            this.update_username_textBox.Size = new System.Drawing.Size(150, 29);
            this.update_username_textBox.TabIndex = 32;
            this.update_username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // selectMemer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1030, 738);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.update_username_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.update_id_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_password_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.update_useraccount_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.select_dataGridView);
            this.Controls.Add(this.updateMember_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.label_title_four);
            this.Controls.Add(this.label_title_three);
            this.Controls.Add(this.selectMember_button);
            this.Controls.Add(this.useraccount_textBox);
            this.Controls.Add(this.label_title_two);
            this.Controls.Add(this.label_title_one);
            this.Controls.Add(this.pictureBox_one);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectMemer_Form";
            this.Text = "easyERP-員工查詢系統";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectMemer_Form_FormClosed);
            this.Load += new System.EventHandler(this.SelectMemer_Form_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_one)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP_Member)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_one;
        private System.Windows.Forms.Label label_title_one;
        private System.Windows.Forms.Label label_title_two;
        private System.Windows.Forms.TextBox useraccount_textBox;
        private System.Windows.Forms.Button selectMember_button;
        private System.Windows.Forms.Label label_title_three;
        private System.Windows.Forms.Label label_title_four;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button updateMember_button;
        private System.Windows.Forms.DataGridView select_dataGridView;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nudPageSize;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
#pragma warning disable CS0246 // 找不到類型或命名空間名稱 'ERPDataSet' (是否遺漏了 using 指示詞或組件參考?)
        private ERPDataSet eRPDataSet;
#pragma warning restore CS0246 // 找不到類型或命名空間名稱 'ERPDataSet' (是否遺漏了 using 指示詞或組件參考?)
#pragma warning disable CS0246 // 找不到類型或命名空間名稱 'ERPDataSetTableAdapters' (是否遺漏了 using 指示詞或組件參考?)
        private ERPDataSetTableAdapters.MemberTableAdapter memberTableAdapter;
#pragma warning restore CS0246 // 找不到類型或命名空間名稱 'ERPDataSetTableAdapters' (是否遺漏了 using 指示詞或組件參考?)
        private ERPDataSet1 eRPDataSet1;
        private System.Windows.Forms.BindingSource easyERP_Member;
        private ERPDataSet1TableAdapters.MemberTableAdapter memberTableAdapter1;
        private System.Windows.Forms.TextBox update_password_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox update_useraccount_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox update_id_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox update_username_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
    }
}