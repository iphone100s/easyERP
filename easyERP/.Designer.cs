namespace easyERP
{
    partial class SelectOutdate_Form
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
            this.startDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectOutDate_button = new System.Windows.Forms.Button();
            this.finishDate_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // startDate_dateTimePicker
            // 
            this.startDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDate_dateTimePicker.Location = new System.Drawing.Point(62, 34);
            this.startDate_dateTimePicker.Name = "startDate_dateTimePicker";
            this.startDate_dateTimePicker.Size = new System.Drawing.Size(169, 22);
            this.startDate_dateTimePicker.TabIndex = 99;
            this.startDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // SelectOutDate_button
            // 
            this.SelectOutDate_button.Location = new System.Drawing.Point(90, 138);
            this.SelectOutDate_button.Name = "SelectOutDate_button";
            this.SelectOutDate_button.Size = new System.Drawing.Size(100, 45);
            this.SelectOutDate_button.TabIndex = 98;
            this.SelectOutDate_button.Text = "出貨日期查詢";
            this.SelectOutDate_button.UseVisualStyleBackColor = true;
            this.SelectOutDate_button.Click += new System.EventHandler(this.SelectOutDate_button_Click);
            // 
            // finishDate_dateTimePicker
            // 
            this.finishDate_dateTimePicker.CalendarFont = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.finishDate_dateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.finishDate_dateTimePicker.Location = new System.Drawing.Point(62, 92);
            this.finishDate_dateTimePicker.Name = "finishDate_dateTimePicker";
            this.finishDate_dateTimePicker.Size = new System.Drawing.Size(169, 22);
            this.finishDate_dateTimePicker.TabIndex = 97;
            this.finishDate_dateTimePicker.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // SelectOutdate_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 204);
            this.Controls.Add(this.startDate_dateTimePicker);
            this.Controls.Add(this.SelectOutDate_button);
            this.Controls.Add(this.finishDate_dateTimePicker);
            this.Name = "SelectOutdate_Form";
            this.Text = "SelectOutdate_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate_dateTimePicker;
        public System.Windows.Forms.Button SelectOutDate_button;
        private System.Windows.Forms.DateTimePicker finishDate_dateTimePicker;
    }
}