using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP
{
    public partial class SelectFactory_Form : Form
    {
        public SelectFactory_Form()
        {
            InitializeComponent();
        }


        private void SelectfactoryNo_button_Click_1(object sender, EventArgs e)
        {
            string factoryNo = this.factoryNo_textBox.Text.Trim();


            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getFactoryNo(factoryNo);
            insertFile_Form.Show();
            this.Close();
        }

        private void SelectfactoryName_button_Click_1(object sender, EventArgs e)
        {
            string factoryName = this.factoryName_textBox.Text.Trim();

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getFactoryName(factoryName);
            insertFile_Form.Show();
            this.Close();
        }

        private void SelectFactory_Form_Load(object sender, EventArgs e)
        {
            factoryNo_label.BackColor = Color.Transparent;
            factoryNo_label.Parent = pictureBox1;

            factoryName_label.BackColor = Color.Transparent;
            factoryName_label.Parent = pictureBox1;

        }
    }
}
