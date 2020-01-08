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
            this.factoryName_textBox = new System.Windows.Forms.TextBox();
            this.factoryNo_textBox = new System.Windows.Forms.TextBox();
            this.factoryName_label = new System.Windows.Forms.Label();
            this.factoryNo_label = new System.Windows.Forms.Label();
            this.SelectfactoryNo_button = new System.Windows.Forms.Button();
            this.SelectfactoryName_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // factoryName_textBox
            // 
            this.factoryName_textBox.Location = new System.Drawing.Point(202, 82);
            this.factoryName_textBox.Multiline = true;
            this.factoryName_textBox.Name = "factoryName_textBox";
            this.factoryName_textBox.Size = new System.Drawing.Size(200, 27);
            this.factoryName_textBox.TabIndex = 72;
            // 
            // factoryNo_textBox
            // 
            this.factoryNo_textBox.Location = new System.Drawing.Point(202, 55);
            this.factoryNo_textBox.Multiline = true;
            this.factoryNo_textBox.Name = "factoryNo_textBox";
            this.factoryNo_textBox.Size = new System.Drawing.Size(200, 27);
            this.factoryNo_textBox.TabIndex = 71;
            // 
            // factoryName_label
            // 
            this.factoryName_label.AutoSize = true;
            this.factoryName_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryName_label.Location = new System.Drawing.Point(72, 82);
            this.factoryName_label.Name = "factoryName_label";
            this.factoryName_label.Size = new System.Drawing.Size(124, 27);
            this.factoryName_label.TabIndex = 70;
            this.factoryName_label.Text = "廠商名稱";
            // 
            // factoryNo_label
            // 
            this.factoryNo_label.AutoSize = true;
            this.factoryNo_label.Font = new System.Drawing.Font("標楷體", 20.25F);
            this.factoryNo_label.Location = new System.Drawing.Point(72, 55);
            this.factoryNo_label.Name = "factoryNo_label";
            this.factoryNo_label.Size = new System.Drawing.Size(124, 27);
            this.factoryNo_label.TabIndex = 69;
            this.factoryNo_label.Text = "廠商編號";
            // 
            // SelectfactoryNo_button
            // 
            this.SelectfactoryNo_button.Location = new System.Drawing.Point(77, 195);
            this.SelectfactoryNo_button.Name = "SelectfactoryNo_button";
            this.SelectfactoryNo_button.Size = new System.Drawing.Size(100, 45);
            this.SelectfactoryNo_button.TabIndex = 96;
            this.SelectfactoryNo_button.Text = "廠商編號查詢";
            this.SelectfactoryNo_button.UseVisualStyleBackColor = true;
            this.SelectfactoryNo_button.Click += new System.EventHandler(this.SelectfactoryNo_button_Click);
            // 
            // SelectfactoryName_button
            // 
            this.SelectfactoryName_button.Location = new System.Drawing.Point(263, 195);
            this.SelectfactoryName_button.Name = "SelectfactoryName_button";
            this.SelectfactoryName_button.Size = new System.Drawing.Size(100, 45);
            this.SelectfactoryName_button.TabIndex = 95;
            this.SelectfactoryName_button.Text = "廠商名稱查詢";
            this.SelectfactoryName_button.UseVisualStyleBackColor = true;
            this.SelectfactoryName_button.Click += new System.EventHandler(this.SelectfactoryName_button_Click);
            // 
            // SelectFactory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 450);
            this.Controls.Add(this.SelectfactoryNo_button);
            this.Controls.Add(this.SelectfactoryName_button);
            this.Controls.Add(this.factoryName_textBox);
            this.Controls.Add(this.factoryNo_textBox);
            this.Controls.Add(this.factoryName_label);
            this.Controls.Add(this.factoryNo_label);
            this.Name = "SelectFactory_Form";
            this.Text = "SelectFactory_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox factoryName_textBox;
        private System.Windows.Forms.TextBox factoryNo_textBox;
        private System.Windows.Forms.Label factoryName_label;
        private System.Windows.Forms.Label factoryNo_label;
        public System.Windows.Forms.Button SelectfactoryNo_button;
        private System.Windows.Forms.Button SelectfactoryName_button;
    }
}