namespace easyERP
{
    partial class SelectFactory_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectFactory_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectfactoryNo_button = new System.Windows.Forms.Button();
            this.SelectfactoryName_button = new System.Windows.Forms.Button();
            this.factoryName_textBox = new System.Windows.Forms.TextBox();
            this.factoryNo_textBox = new System.Windows.Forms.TextBox();
            this.factoryName_label = new System.Windows.Forms.Label();
            this.factoryNo_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::easyERP.Properties.Resources.view_two;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // SelectfactoryNo_button
            // 
            this.SelectfactoryNo_button.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SelectfactoryNo_button.Location = new System.Drawing.Point(86, 181);
            this.SelectfactoryNo_button.Name = "SelectfactoryNo_button";
            this.SelectfactoryNo_button.Size = new System.Drawing.Size(100, 45);
            this.SelectfactoryNo_button.TabIndex = 103;
            this.SelectfactoryNo_button.Text = "廠商編號查詢";
            this.SelectfactoryNo_button.UseVisualStyleBackColor = true;
            this.SelectfactoryNo_button.Click += new System.EventHandler(this.SelectfactoryNo_button_Click_1);
            // 
            // SelectfactoryName_button
            // 
            this.SelectfactoryName_button.Font = new System.Drawing.Font("標楷體", 12F);
            this.SelectfactoryName_button.Location = new System.Drawing.Point(242, 181);
            this.SelectfactoryName_button.Name = "SelectfactoryName_button";
            this.SelectfactoryName_button.Size = new System.Drawing.Size(100, 45);
            this.SelectfactoryName_button.TabIndex = 102;
            this.SelectfactoryName_button.Text = "廠商名稱查詢";
            this.SelectfactoryName_button.UseVisualStyleBackColor = true;
            this.SelectfactoryName_button.Click += new System.EventHandler(this.SelectfactoryName_button_Click_1);
            // 
            // factoryName_textBox
            // 
            this.factoryName_textBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.factoryName_textBox.Location = new System.Drawing.Point(182, 113);
            this.factoryName_textBox.Multiline = true;
            this.factoryName_textBox.Name = "factoryName_textBox";
            this.factoryName_textBox.Size = new System.Drawing.Size(200, 25);
            this.factoryName_textBox.TabIndex = 101;
            // 
            // factoryNo_textBox
            // 
            this.factoryNo_textBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.factoryNo_textBox.Location = new System.Drawing.Point(182, 47);
            this.factoryNo_textBox.Multiline = true;
            this.factoryNo_textBox.Name = "factoryNo_textBox";
            this.factoryNo_textBox.Size = new System.Drawing.Size(200, 25);
            this.factoryNo_textBox.TabIndex = 100;
            // 
            // factoryName_label
            // 
            this.factoryName_label.AutoSize = true;
            this.factoryName_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryName_label.ForeColor = System.Drawing.Color.Red;
            this.factoryName_label.Location = new System.Drawing.Point(52, 113);
            this.factoryName_label.Name = "factoryName_label";
            this.factoryName_label.Size = new System.Drawing.Size(124, 27);
            this.factoryName_label.TabIndex = 99;
            this.factoryName_label.Text = "廠商名稱";
            // 
            // factoryNo_label
            // 
            this.factoryNo_label.AutoSize = true;
            this.factoryNo_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryNo_label.ForeColor = System.Drawing.Color.Red;
            this.factoryNo_label.Location = new System.Drawing.Point(52, 47);
            this.factoryNo_label.Name = "factoryNo_label";
            this.factoryNo_label.Size = new System.Drawing.Size(124, 27);
            this.factoryNo_label.TabIndex = 98;
            this.factoryNo_label.Text = "廠商編號";
            // 
            // SelectFactory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 301);
            this.Controls.Add(this.SelectfactoryNo_button);
            this.Controls.Add(this.SelectfactoryName_button);
            this.Controls.Add(this.factoryName_textBox);
            this.Controls.Add(this.factoryNo_textBox);
            this.Controls.Add(this.factoryName_label);
            this.Controls.Add(this.factoryNo_label);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectFactory_Form";
            this.Text = "easyERP-廠商查詢";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button SelectfactoryNo_button;
        private System.Windows.Forms.Button SelectfactoryName_button;
        private System.Windows.Forms.TextBox factoryName_textBox;
        private System.Windows.Forms.TextBox factoryNo_textBox;
        private System.Windows.Forms.Label factoryName_label;
        private System.Windows.Forms.Label factoryNo_label;
    }
}