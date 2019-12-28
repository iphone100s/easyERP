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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectMember_button = new System.Windows.Forms.Button();
            this.select_dataGridView = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.easyERP_Member = new System.Windows.Forms.BindingSource(this.components);
            this.eRPDataSet3 = new easyERP.ERPDataSet3();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.UpdateMember_button = new System.Windows.Forms.Button();
            this.memberTableAdapter1 = new easyERP.ERPDataSet3TableAdapters.MemberTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IInsertMember_button = new System.Windows.Forms.Button();
            this.DeleteMember_button = new System.Windows.Forms.Button();
            this.status_comboBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.memberName_textBox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.memberAccount_textbox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.memberID_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP_Member)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(417, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "員工系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(984, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "請輸入帳號密碼";
            // 
            // SelectMember_button
            // 
            this.SelectMember_button.Location = new System.Drawing.Point(663, 61);
            this.SelectMember_button.Name = "SelectMember_button";
            this.SelectMember_button.Size = new System.Drawing.Size(114, 43);
            this.SelectMember_button.TabIndex = 9;
            this.SelectMember_button.Text = "查詢";
            this.SelectMember_button.UseVisualStyleBackColor = true;
            this.SelectMember_button.Click += new System.EventHandler(this.SelectMember_button_Click);
            // 
            // select_dataGridView
            // 
            this.select_dataGridView.AllowUserToAddRows = false;
            this.select_dataGridView.AllowUserToDeleteRows = false;
            this.select_dataGridView.AutoGenerateColumns = false;
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
            this.permissionNameDataGridViewTextBoxColumn});
            this.select_dataGridView.DataSource = this.easyERP_Member;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.select_dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.select_dataGridView.Location = new System.Drawing.Point(53, 323);
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
            this.select_dataGridView.Size = new System.Drawing.Size(545, 170);
            this.select_dataGridView.TabIndex = 10;
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
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "狀態";
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            this.permissionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // easyERP_Member
            // 
            this.easyERP_Member.DataMember = "Member";
            this.easyERP_Member.DataSource = this.eRPDataSet3;
            // 
            // eRPDataSet3
            // 
            this.eRPDataSet3.DataSetName = "ERPDataSet3";
            this.eRPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(53, 523);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPage.TabIndex = 11;
            this.btnFirstPage.Text = "第一頁";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(148, 523);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPage.TabIndex = 12;
            this.btnPreviousPage.Text = "<<上一頁";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(381, 523);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 23);
            this.btnNextPage.TabIndex = 13;
            this.btnNextPage.Text = "下一頁>>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.BtnNextPage_Click);
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbCurrentPage.Location = new System.Drawing.Point(255, 523);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(96, 27);
            this.lbCurrentPage.TabIndex = 15;
            this.lbCurrentPage.Text = "第  頁";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalPage.Location = new System.Drawing.Point(502, 622);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(96, 27);
            this.lbTotalPage.TabIndex = 16;
            this.lbTotalPage.Text = "共  頁";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(778, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "請輸入要修改帳號密碼";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudPageSize);
            this.groupBox1.Location = new System.Drawing.Point(53, 578);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定分頁";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(302, 44);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 28;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(258, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 27);
            this.label13.TabIndex = 29;
            this.label13.Text = "列";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(6, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 27);
            this.label12.TabIndex = 28;
            this.label12.Text = "每頁";
            // 
            // nudPageSize
            // 
            this.nudPageSize.Location = new System.Drawing.Point(125, 47);
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(120, 22);
            this.nudPageSize.TabIndex = 0;
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(498, 514);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 28;
            this.btnLastPage.Text = "最後頁";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // UpdateMember_button
            // 
            this.UpdateMember_button.Location = new System.Drawing.Point(663, 227);
            this.UpdateMember_button.Name = "UpdateMember_button";
            this.UpdateMember_button.Size = new System.Drawing.Size(114, 57);
            this.UpdateMember_button.TabIndex = 29;
            this.UpdateMember_button.Text = "修改";
            this.UpdateMember_button.UseVisualStyleBackColor = true;
            this.UpdateMember_button.Click += new System.EventHandler(this.UpdateMember_button_Click);
            // 
            // memberTableAdapter1
            // 
            this.memberTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_four;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1218, 703);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // IInsertMember_button
            // 
            this.IInsertMember_button.Location = new System.Drawing.Point(673, 314);
            this.IInsertMember_button.Name = "IInsertMember_button";
            this.IInsertMember_button.Size = new System.Drawing.Size(104, 52);
            this.IInsertMember_button.TabIndex = 41;
            this.IInsertMember_button.Text = "新增";
            this.IInsertMember_button.UseVisualStyleBackColor = true;
            this.IInsertMember_button.Click += new System.EventHandler(this.IInsertMember_button_Click);
            // 
            // DeleteMember_button
            // 
            this.DeleteMember_button.Location = new System.Drawing.Point(663, 143);
            this.DeleteMember_button.Name = "DeleteMember_button";
            this.DeleteMember_button.Size = new System.Drawing.Size(114, 50);
            this.DeleteMember_button.TabIndex = 44;
            this.DeleteMember_button.Text = "刪除";
            this.DeleteMember_button.UseVisualStyleBackColor = true;
            this.DeleteMember_button.Click += new System.EventHandler(this.DeleteMember_button_Click);
            // 
            // status_comboBox
            // 
            this.status_comboBox.FormattingEnabled = true;
            this.status_comboBox.Location = new System.Drawing.Point(164, 220);
            this.status_comboBox.Name = "status_comboBox";
            this.status_comboBox.Size = new System.Drawing.Size(121, 20);
            this.status_comboBox.TabIndex = 52;
            this.status_comboBox.SelectedIndexChanged += new System.EventHandler(this.Status_comboBox_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(60, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 27);
            this.label17.TabIndex = 51;
            this.label17.Text = "職等";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(57, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 27);
            this.label18.TabIndex = 50;
            this.label18.Text = "姓名";
            // 
            // memberName_textBox
            // 
            this.memberName_textBox.Location = new System.Drawing.Point(140, 114);
            this.memberName_textBox.Name = "memberName_textBox";
            this.memberName_textBox.Size = new System.Drawing.Size(100, 22);
            this.memberName_textBox.TabIndex = 49;
            this.memberName_textBox.TextChanged += new System.EventHandler(this.MemberName_textBox_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(60, 166);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 27);
            this.label19.TabIndex = 48;
            this.label19.Text = "密碼";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(59, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 27);
            this.label20.TabIndex = 47;
            this.label20.Text = "帳號";
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(152, 166);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 22);
            this.password_textBox.TabIndex = 46;
            // 
            // memberAccount_textbox
            // 
            this.memberAccount_textbox.Location = new System.Drawing.Point(145, 61);
            this.memberAccount_textbox.Name = "memberAccount_textbox";
            this.memberAccount_textbox.Size = new System.Drawing.Size(100, 22);
            this.memberAccount_textbox.TabIndex = 45;
            this.memberAccount_textbox.TextChanged += new System.EventHandler(this.MemberAccount_textbox_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(76, 261);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 27);
            this.label21.TabIndex = 54;
            this.label21.Text = "ID";
            // 
            // memberID_textBox
            // 
            this.memberID_textBox.Location = new System.Drawing.Point(159, 261);
            this.memberID_textBox.Name = "memberID_textBox";
            this.memberID_textBox.Size = new System.Drawing.Size(100, 22);
            this.memberID_textBox.TabIndex = 53;
            this.memberID_textBox.TextChanged += new System.EventHandler(this.MemberID_textBox_TextChanged);
            // 
            // Memer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 698);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.memberID_textBox);
            this.Controls.Add(this.status_comboBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.memberName_textBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.memberAccount_textbox);
            this.Controls.Add(this.DeleteMember_button);
            this.Controls.Add(this.IInsertMember_button);
            this.Controls.Add(this.UpdateMember_button);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.select_dataGridView);
            this.Controls.Add(this.SelectMember_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView select_dataGridView;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPageSize;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button UpdateMember_button;
        private ERPDataSet3 eRPDataSet3;
        private System.Windows.Forms.BindingSource easyERP_Member;
        private ERPDataSet3TableAdapters.MemberTableAdapter memberTableAdapter1;
        private System.Windows.Forms.Button IInsertMember_button;
        private System.Windows.Forms.Button DeleteMember_button;
        public System.Windows.Forms.Button SelectMember_button;
        private System.Windows.Forms.ComboBox status_comboBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox memberName_textBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox memberAccount_textbox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox memberID_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
    }
}