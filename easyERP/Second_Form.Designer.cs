namespace easyERP
{
    partial class Second_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Second_Form));
            this.member_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.select_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // member_button
            // 
            this.member_button.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.member_button.Location = new System.Drawing.Point(87, 52);
            this.member_button.Name = "member_button";
            this.member_button.Size = new System.Drawing.Size(210, 40);
            this.member_button.TabIndex = 7;
            this.member_button.Text = "員工系統";
            this.member_button.UseVisualStyleBackColor = true;
            this.member_button.Click += new System.EventHandler(this.Member_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Font = new System.Drawing.Font("標楷體", 14.25F);
            this.insert_button.Location = new System.Drawing.Point(87, 159);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(210, 40);
            this.insert_button.TabIndex = 8;
            this.insert_button.Text = "建檔系統";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // select_button
            // 
            this.select_button.Font = new System.Drawing.Font("標楷體", 14.25F);
            this.select_button.Location = new System.Drawing.Point(87, 265);
            this.select_button.Name = "select_button";
            this.select_button.Size = new System.Drawing.Size(210, 40);
            this.select_button.TabIndex = 9;
            this.select_button.Text = "查詢系統";
            this.select_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_two;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Second_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.select_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.member_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Second_Form";
            this.Text = "easyERP";
            this.Load += new System.EventHandler(this.Second_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button member_button;
        public System.Windows.Forms.Button insert_button;
        public System.Windows.Forms.Button select_button;
    }
}