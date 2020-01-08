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

        private void SelectfactoryNo_button_Click(object sender, EventArgs e)
        {
            string factoryNo = this.factoryNo_textBox.Text.Trim();
   

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getFactoryNo(factoryNo);
            insertFile_Form.Show();
            this.Close();


        }

        private void SelectfactoryName_button_Click(object sender, EventArgs e)
        {
            string factoryName = this.factoryName_textBox.Text.Trim();

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getFactoryName(factoryName);
            insertFile_Form.Show();
            this.Close();
        }
    }
}
