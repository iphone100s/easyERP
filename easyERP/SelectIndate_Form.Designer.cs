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
            this.finishDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectinDate_button = new System.Windows.Forms.Button();
            this.startDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // finishDate_dateTimePicker
            // 
            this.finishDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finishDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.finishDate_dateTimePicker.Location = new System.Drawing.Point(68, 101);
            this.finishDate_dateTimePicker.Name = "finishDate_dateTimePicker";
            this.finishDate_dateTimePicker.Size = new System.Drawing.Size(169, 22);
            this.finishDate_dateTimePicker.TabIndex = 76;
            this.finishDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // SelectinDate_button
            // 
            this.SelectinDate_button.Location = new System.Drawing.Point(98, 135);
            this.SelectinDate_button.Name = "SelectinDate_button";
            this.SelectinDate_button.Size = new System.Drawing.Size(100, 45);
            this.SelectinDate_button.TabIndex = 95;
            this.SelectinDate_button.Text = "進貨日期查詢";
            this.SelectinDate_button.UseVisualStyleBackColor = true;
            this.SelectinDate_button.Click += new System.EventHandler(this.SelectinDate_button_Click);
            // 
            // startDate_dateTimePicker
            // 
            this.startDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDate_dateTimePicker.Location = new System.Drawing.Point(68, 43);
            this.startDate_dateTimePicker.Name = "startDate_dateTimePicker";
            this.startDate_dateTimePicker.Size = new System.Drawing.Size(169, 22);
            this.startDate_dateTimePicker.TabIndex = 96;
            this.startDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // SelectIndate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 192);
            this.Controls.Add(this.startDate_dateTimePicker);
            this.Controls.Add(this.SelectinDate_button);
            this.Controls.Add(this.finishDate_dateTimePicker);
            this.Name = "SelectIndate_Form";
            this.Text = "SelectIndate_Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker finishDate_dateTimePicker;
        private System.Windows.Forms.DateTimePicker startDate_dateTimePicker;
        public System.Windows.Forms.Button SelectinDate_button;
    }
}