namespace easyERP
{
    partial class SelectIndate_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectIndate_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.finishDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.factoryName_label = new System.Windows.Forms.Label();
            this.factoryNo_label = new System.Windows.Forms.Label();
            this.SelectinDate_button = new System.Windows.Forms.Button();
            this.SelectOutDate_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_two;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // startDate_dateTimePicker
            // 
            this.startDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDate_dateTimePicker.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDate_dateTimePicker.Location = new System.Drawing.Point(205, 61);
            this.startDate_dateTimePicker.Name = "startDate_dateTimePicker";
            this.startDate_dateTimePicker.Size = new System.Drawing.Size(169, 30);
            this.startDate_dateTimePicker.TabIndex = 100;
            this.startDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // finishDate_dateTimePicker
            // 
            this.finishDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finishDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.finishDate_dateTimePicker.Font = new System.Drawing.Font("新細明體", 14.25F);
            this.finishDate_dateTimePicker.Location = new System.Drawing.Point(205, 147);
            this.finishDate_dateTimePicker.Name = "finishDate_dateTimePicker";
            this.finishDate_dateTimePicker.Size = new System.Drawing.Size(169, 30);
            this.finishDate_dateTimePicker.TabIndex = 98;
            this.finishDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // factoryName_label
            // 
            this.factoryName_label.AutoSize = true;
            this.factoryName_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryName_label.ForeColor = System.Drawing.Color.Red;
            this.factoryName_label.Location = new System.Drawing.Point(71, 150);
            this.factoryName_label.Name = "factoryName_label";
            this.factoryName_label.Size = new System.Drawing.Size(124, 27);
            this.factoryName_label.TabIndex = 102;
            this.factoryName_label.Text = "結束日期";
            // 
            // factoryNo_label
            // 
            this.factoryNo_label.AutoSize = true;
            this.factoryNo_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryNo_label.ForeColor = System.Drawing.Color.Red;
            this.factoryNo_label.Location = new System.Drawing.Point(71, 61);
            this.factoryNo_label.Name = "factoryNo_label";
            this.factoryNo_label.Size = new System.Drawing.Size(124, 27);
            this.factoryNo_label.TabIndex = 101;
            this.factoryNo_label.Text = "起始日期";
            // 
            // SelectinDate_button
            // 
            this.SelectinDate_button.Font = new System.Drawing.Font("標楷體", 12F);
            this.SelectinDate_button.Location = new System.Drawing.Point(95, 213);
            this.SelectinDate_button.Name = "SelectinDate_button";
            this.SelectinDate_button.Size = new System.Drawing.Size(100, 45);
            this.SelectinDate_button.TabIndex = 103;
            this.SelectinDate_button.Text = "進貨日期查詢";
            this.SelectinDate_button.UseVisualStyleBackColor = true;
            this.SelectinDate_button.Click += new System.EventHandler(this.SelectinDate_button_Click);
            // 
            // SelectOutDate_button
            // 
            this.SelectOutDate_button.Font = new System.Drawing.Font("標楷體", 12F);
            this.SelectOutDate_button.Location = new System.Drawing.Point(250, 213);
            this.SelectOutDate_button.Name = "SelectOutDate_button";
            this.SelectOutDate_button.Size = new System.Drawing.Size(100, 45);
            this.SelectOutDate_button.TabIndex = 104;
            this.SelectOutDate_button.Text = "出貨日期查詢";
            this.SelectOutDate_button.UseVisualStyleBackColor = true;
            this.SelectOutDate_button.Click += new System.EventHandler(this.SelectOutDate_button_Click);
            // 
            // SelectIndate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.SelectOutDate_button);
            this.Controls.Add(this.SelectinDate_button);
            this.Controls.Add(this.factoryName_label);
            this.Controls.Add(this.factoryNo_label);
            this.Controls.Add(this.startDate_dateTimePicker);
            this.Controls.Add(this.finishDate_dateTimePicker);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectIndate_Form";
            this.Text = "easyERP-進出貨日期查詢";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker startDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker finishDate_dateTimePicker;
        private System.Windows.Forms.Label factoryName_label;
        private System.Windows.Forms.Label factoryNo_label;
        public System.Windows.Forms.Button SelectinDate_button;
        public System.Windows.Forms.Button SelectOutDate_button;
    }
}