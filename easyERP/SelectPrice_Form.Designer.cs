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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPrice_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.taxIncluded_textBox = new System.Windows.Forms.TextBox();
            this.untaxed_textBox = new System.Windows.Forms.TextBox();
            this.taxIncluded_label = new System.Windows.Forms.Label();
            this.untaxed_label = new System.Windows.Forms.Label();
            this.SelectunTaxed_button = new System.Windows.Forms.Button();
            this.SelecttaxIncluded_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_two;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 101;
            this.pictureBox1.TabStop = false;
            // 
            // taxIncluded_textBox
            // 
            this.taxIncluded_textBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.taxIncluded_textBox.Location = new System.Drawing.Point(239, 135);
            this.taxIncluded_textBox.Multiline = true;
            this.taxIncluded_textBox.Name = "taxIncluded_textBox";
            this.taxIncluded_textBox.Size = new System.Drawing.Size(115, 25);
            this.taxIncluded_textBox.TabIndex = 105;
            this.taxIncluded_textBox.Text = "0";
            // 
            // untaxed_textBox
            // 
            this.untaxed_textBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.untaxed_textBox.Location = new System.Drawing.Point(239, 61);
            this.untaxed_textBox.Multiline = true;
            this.untaxed_textBox.Name = "untaxed_textBox";
            this.untaxed_textBox.Size = new System.Drawing.Size(115, 25);
            this.untaxed_textBox.TabIndex = 104;
            this.untaxed_textBox.Text = "0";
            // 
            // taxIncluded_label
            // 
            this.taxIncluded_label.AutoSize = true;
            this.taxIncluded_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.taxIncluded_label.ForeColor = System.Drawing.Color.Red;
            this.taxIncluded_label.Location = new System.Drawing.Point(99, 133);
            this.taxIncluded_label.Name = "taxIncluded_label";
            this.taxIncluded_label.Size = new System.Drawing.Size(124, 27);
            this.taxIncluded_label.TabIndex = 103;
            this.taxIncluded_label.Text = "含稅金額";
            // 
            // untaxed_label
            // 
            this.untaxed_label.AutoSize = true;
            this.untaxed_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.untaxed_label.ForeColor = System.Drawing.Color.Red;
            this.untaxed_label.Location = new System.Drawing.Point(99, 61);
            this.untaxed_label.Name = "untaxed_label";
            this.untaxed_label.Size = new System.Drawing.Size(124, 27);
            this.untaxed_label.TabIndex = 102;
            this.untaxed_label.Text = "未稅金額";
            // 
            // SelectunTaxed_button
            // 
            this.SelectunTaxed_button.Font = new System.Drawing.Font("標楷體", 12F);
            this.SelectunTaxed_button.Location = new System.Drawing.Point(94, 206);
            this.SelectunTaxed_button.Name = "SelectunTaxed_button";
            this.SelectunTaxed_button.Size = new System.Drawing.Size(100, 45);
            this.SelectunTaxed_button.TabIndex = 109;
            this.SelectunTaxed_button.Text = "未稅金額查詢";
            this.SelectunTaxed_button.UseVisualStyleBackColor = true;
            this.SelectunTaxed_button.Click += new System.EventHandler(this.SelectunTaxed_button_Click);
            // 
            // SelecttaxIncluded_button
            // 
            this.SelecttaxIncluded_button.Font = new System.Drawing.Font("標楷體", 12F);
            this.SelecttaxIncluded_button.Location = new System.Drawing.Point(254, 206);
            this.SelecttaxIncluded_button.Name = "SelecttaxIncluded_button";
            this.SelecttaxIncluded_button.Size = new System.Drawing.Size(100, 45);
            this.SelecttaxIncluded_button.TabIndex = 108;
            this.SelecttaxIncluded_button.Text = "含稅金額查詢";
            this.SelecttaxIncluded_button.UseVisualStyleBackColor = true;
            this.SelecttaxIncluded_button.Click += new System.EventHandler(this.SelecttaxIncluded_button_Click);
            // 
            // SelectPrice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.SelectunTaxed_button);
            this.Controls.Add(this.SelecttaxIncluded_button);
            this.Controls.Add(this.taxIncluded_textBox);
            this.Controls.Add(this.untaxed_textBox);
            this.Controls.Add(this.taxIncluded_label);
            this.Controls.Add(this.untaxed_label);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectPrice_Form";
            this.Text = "easyERP-未稅含稅金額查詢";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox taxIncluded_textBox;
        private System.Windows.Forms.TextBox untaxed_textBox;
        private System.Windows.Forms.Label taxIncluded_label;
        private System.Windows.Forms.Label untaxed_label;
        public System.Windows.Forms.Button SelectunTaxed_button;
        private System.Windows.Forms.Button SelecttaxIncluded_button;
    }
}