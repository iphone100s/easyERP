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
    public partial class SelectPrice_Form : Form
    {
        public SelectPrice_Form()
        {
            InitializeComponent();
        }

        private void SelectunTaxed_button_Click(object sender, EventArgs e)
        {

            int untaxed = int.Parse(this.untaxed_textBox.Text);


                InsertFile_Form insertFile_Form = new InsertFile_Form();
                insertFile_Form.getUntaxed(untaxed);
                insertFile_Form.Show();
                this.Close();
        

     

        }

        private void SelecttaxIncluded_button_Click(object sender, EventArgs e)
        {
            int taxIncluded = int.Parse(this.taxIncluded_textBox.Text);

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getTaxIncluded(taxIncluded);
            insertFile_Form.Show();
            this.Close();

     

        }
    }
}
