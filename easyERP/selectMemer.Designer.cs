namespace easyERP
{
    partial class selectMemer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectMemer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.useraccount_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectMember_button = new System.Windows.Forms.Button();
            this.select_dataGridView = new System.Windows.Forms.DataGridView();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.update_password_textBox = new System.Windows.Forms.TextBox();
            this.update_useraccount_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.update_username_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.update_id_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.UpdateMember_button = new System.Windows.Forms.Button();
            this.eRPDataSet2 = new easyERP.ERPDataSet2();
            this.easyERP = new System.Windows.Forms.BindingSource(this.components);
            this.memberTableAdapter = new easyERP.ERPDataSet2TableAdapters.MemberTableAdapter();
            this.memberAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_four;
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1004, 703);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // useraccount_textBox
            // 
            this.useraccount_textBox.Location = new System.Drawing.Point(173, 138);
            this.useraccount_textBox.Name = "useraccount_textBox";
            this.useraccount_textBox.Size = new System.Drawing.Size(100, 22);
            this.useraccount_textBox.TabIndex = 3;
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(397, 133);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(100, 22);
            this.password_textBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(379, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "員工查詢系統";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(366, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "請輸入帳號密碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(99, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "帳號";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(314, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "密碼";
            // 
            // SelectMember_button
            // 
            this.SelectMember_button.Location = new System.Drawing.Point(611, 132);
            this.SelectMember_button.Name = "SelectMember_button";
            this.SelectMember_button.Size = new System.Drawing.Size(75, 23);
            this.SelectMember_button.TabIndex = 9;
            this.SelectMember_button.Text = "查詢";
            this.SelectMember_button.UseVisualStyleBackColor = true;
            this.SelectMember_button.Click += new System.EventHandler(this.SelectMember_button_Click);
            // 
            // select_dataGridView
            // 
            this.select_dataGridView.AutoGenerateColumns = false;
            this.select_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.select_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberAccountDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.permissionNameDataGridViewTextBoxColumn});
            this.select_dataGridView.DataSource = this.easyERP;
            this.select_dataGridView.Location = new System.Drawing.Point(84, 186);
            this.select_dataGridView.Name = "select_dataGridView";
            this.select_dataGridView.RowTemplate.Height = 24;
            this.select_dataGridView.Size = new System.Drawing.Size(441, 150);
            this.select_dataGridView.TabIndex = 10;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Location = new System.Drawing.Point(53, 362);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 23);
            this.btnFirstPage.TabIndex = 11;
            this.btnFirstPage.Text = "第一頁";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.BtnFirstPage_Click);
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.Location = new System.Drawing.Point(198, 362);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousPage.TabIndex = 12;
            this.btnPreviousPage.Text = "<<上一頁";
            this.btnPreviousPage.UseVisualStyleBackColor = true;
            this.btnPreviousPage.Click += new System.EventHandler(this.BtnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(422, 362);
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
            this.lbCurrentPage.Location = new System.Drawing.Point(314, 362);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(96, 27);
            this.lbCurrentPage.TabIndex = 15;
            this.lbCurrentPage.Text = "第  頁";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbTotalPage.Location = new System.Drawing.Point(543, 425);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(96, 27);
            this.lbTotalPage.TabIndex = 16;
            this.lbTotalPage.Text = "共  頁";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(48, 533);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(292, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "請輸入要修改帳號密碼";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(275, 584);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "密碼";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(60, 587);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 27);
            this.label9.TabIndex = 20;
            this.label9.Text = "帳號";
            // 
            // update_password_textBox
            // 
            this.update_password_textBox.Location = new System.Drawing.Point(358, 584);
            this.update_password_textBox.Name = "update_password_textBox";
            this.update_password_textBox.Size = new System.Drawing.Size(100, 22);
            this.update_password_textBox.TabIndex = 19;
            // 
            // update_useraccount_textBox
            // 
            this.update_useraccount_textBox.Location = new System.Drawing.Point(134, 589);
            this.update_useraccount_textBox.Name = "update_useraccount_textBox";
            this.update_useraccount_textBox.Size = new System.Drawing.Size(100, 22);
            this.update_useraccount_textBox.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(48, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "姓名";
            // 
            // update_username_textBox
            // 
            this.update_username_textBox.Location = new System.Drawing.Point(131, 639);
            this.update_username_textBox.Name = "update_username_textBox";
            this.update_username_textBox.Size = new System.Drawing.Size(100, 22);
            this.update_username_textBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(342, 634);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 27);
            this.label11.TabIndex = 25;
            this.label11.Text = "ID";
            // 
            // update_id_textBox
            // 
            this.update_id_textBox.Location = new System.Drawing.Point(425, 634);
            this.update_id_textBox.Name = "update_id_textBox";
            this.update_id_textBox.Size = new System.Drawing.Size(100, 22);
            this.update_id_textBox.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.nudPageSize);
            this.groupBox1.Location = new System.Drawing.Point(95, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 100);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "設定分頁";
            // 
            // nudPageSize
            // 
            this.nudPageSize.Location = new System.Drawing.Point(125, 47);
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(120, 22);
            this.nudPageSize.TabIndex = 0;
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
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(321, 42);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 28;
            this.btnSet.Text = "設定";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Location = new System.Drawing.Point(520, 362);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 23);
            this.btnLastPage.TabIndex = 28;
            this.btnLastPage.Text = "最後頁";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.BtnLastPage_Click);
            // 
            // UpdateMember_button
            // 
            this.UpdateMember_button.Location = new System.Drawing.Point(576, 606);
            this.UpdateMember_button.Name = "UpdateMember_button";
            this.UpdateMember_button.Size = new System.Drawing.Size(75, 23);
            this.UpdateMember_button.TabIndex = 29;
            this.UpdateMember_button.Text = "查詢";
            this.UpdateMember_button.UseVisualStyleBackColor = true;
            this.UpdateMember_button.Click += new System.EventHandler(this.UpdateMember_button_Click);
            // 
            // eRPDataSet2
            // 
            this.eRPDataSet2.DataSetName = "ERPDataSet2";
            this.eRPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // easyERP
            // 
            this.easyERP.DataMember = "Member";
            this.easyERP.DataSource = this.eRPDataSet2;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // memberAccountDataGridViewTextBoxColumn
            // 
            this.memberAccountDataGridViewTextBoxColumn.DataPropertyName = "memberAccount";
            this.memberAccountDataGridViewTextBoxColumn.HeaderText = "帳號";
            this.memberAccountDataGridViewTextBoxColumn.Name = "memberAccountDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "密碼";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            // 
            // permissionNameDataGridViewTextBoxColumn
            // 
            this.permissionNameDataGridViewTextBoxColumn.DataPropertyName = "permissionName";
            this.permissionNameDataGridViewTextBoxColumn.HeaderText = "狀態";
            this.permissionNameDataGridViewTextBoxColumn.Name = "permissionNameDataGridViewTextBoxColumn";
            // 
            // selectMemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 698);
            this.Controls.Add(this.UpdateMember_button);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.update_id_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.update_username_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.update_password_textBox);
            this.Controls.Add(this.update_useraccount_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPreviousPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.select_dataGridView);
            this.Controls.Add(this.SelectMember_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.useraccount_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "selectMemer";
            this.Text = "easyERP-員工新增修改系統";
            this.Load += new System.EventHandler(this.SelectMemer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.select_dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eRPDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easyERP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox useraccount_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectMember_button;
        private System.Windows.Forms.DataGridView select_dataGridView;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPreviousPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox update_password_textBox;
        private System.Windows.Forms.TextBox update_useraccount_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox update_username_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox update_id_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudPageSize;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button UpdateMember_button;
        private ERPDataSet2 eRPDataSet2;
        private System.Windows.Forms.BindingSource easyERP;
        private ERPDataSet2TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permissionNameDataGridViewTextBoxColumn;
    }
}