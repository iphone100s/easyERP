namespace easyERP
{
    partial class SelectPrice_Form
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
            this.SelectunTaxed_button = new System.Windows.Forms.Button();
            this.SelecttaxIncluded_button = new System.Windows.Forms.Button();
            this.taxIncluded_textBox = new System.Windows.Forms.TextBox();
            this.untaxed_textBox = new System.Windows.Forms.TextBox();
            this.taxIncluded_label = new System.Windows.Forms.Label();
            this.untaxed_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SelectunTaxed_button
            // 
            this.SelectunTaxed_button.Location = new System.Drawing.Point(79, 250);
            this.SelectunTaxed_button.Name = "SelectunTaxed_button";
            this.SelectunTaxed_button.Size = new System.Drawing.Size(100, 45);
            this.SelectunTaxed_button.TabIndex = 100;
            this.SelectunTaxed_button.Text = "未稅金額查詢";
            this.SelectunTaxed_button.UseVisualStyleBackColor = true;
            this.SelectunTaxed_button.Click += new System.EventHandler(this.SelectunTaxed_button_Click);
            // 
            // SelecttaxIncluded_button
            // 
            this.SelecttaxIncluded_button.Location = new System.Drawing.Point(280, 250);
            this.SelecttaxIncluded_button.Name = "SelecttaxIncluded_button";
            this.SelecttaxIncluded_button.Size = new System.Drawing.Size(100, 45);
            this.SelecttaxIncluded_button.TabIndex = 99;
            this.SelecttaxIncluded_button.Text = "含稅金額查詢";
            this.SelecttaxIncluded_button.UseVisualStyleBackColor = true;
            this.SelecttaxIncluded_button.Click += new System.EventHandler(this.SelecttaxIncluded_button_Click);
            // 
            // taxIncluded_textBox
            // 
            this.taxIncluded_textBox.Location = new System.Drawing.Point(217, 131);
            this.taxIncluded_textBox.Multiline = true;
            this.taxIncluded_textBox.Name = "taxIncluded_textBox";
            this.taxIncluded_textBox.Size = new System.Drawing.Size(109, 27);
            this.taxIncluded_textBox.TabIndex = 98;
            // 
            // untaxed_textBox
            // 
            this.untaxed_textBox.Location = new System.Drawing.Point(217, 104);
            this.untaxed_textBox.Multiline = true;
            this.untaxed_textBox.Name = "untaxed_textBox";
            this.untaxed_textBox.Size = new System.Drawing.Size(109, 27);
            this.untaxed_textBox.TabIndex = 97;
            // 
            // taxIncluded_label
            // 
            this.taxIncluded_label.AutoSize = true;
            this.taxIncluded_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.taxIncluded_label.Location = new System.Drawing.Point(87, 131);
            this.taxIncluded_label.Name = "taxIncluded_label";
            this.taxIncluded_label.Size = new System.Drawing.Size(124, 27);
            this.taxIncluded_label.TabIndex = 96;
            this.taxIncluded_label.Text = "含稅金額";
            // 
            // untaxed_label
            // 
            this.untaxed_label.AutoSize = true;
            this.untaxed_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.untaxed_label.Location = new System.Drawing.Point(87, 104);
            this.untaxed_label.Name = "untaxed_label";
            this.untaxed_label.Size = new System.Drawing.Size(124, 27);
            this.untaxed_label.TabIndex = 95;
            this.untaxed_label.Text = "未稅金額";
            // 
            // SelectPrice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 357);
            this.Controls.Add(this.SelectunTaxed_button);
            this.Controls.Add(this.SelecttaxIncluded_button);
            this.Controls.Add(this.taxIncluded_textBox);
            this.Controls.Add(this.untaxed_textBox);
            this.Controls.Add(this.taxIncluded_label);
            this.Controls.Add(this.untaxed_label);
            this.Name = "SelectPrice_Form";
            this.Text = "SelectPrice_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button SelectunTaxed_button;
        private System.Windows.Forms.Button SelecttaxIncluded_button;
        private System.Windows.Forms.TextBox taxIncluded_textBox;
        private System.Windows.Forms.TextBox untaxed_textBox;
        private System.Windows.Forms.Label taxIncluded_label;
        private System.Windows.Forms.Label untaxed_label;
    }
}