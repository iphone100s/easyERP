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
            Check check = new Check();

            bool checkuntaxed = check.IsNumber(untaxed_textBox.Text.Trim());
           
            if (checkuntaxed == false )
            {
                MessageBox.Show("請勿空白或是輸入非數字", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int untaxed = int.Parse(this.untaxed_textBox.Text);

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getUntaxed(untaxed);
            insertFile_Form.Show();
            this.Close();
        }

        private void SelecttaxIncluded_button_Click(object sender, EventArgs e)
        {
            Check check = new Check();

            bool checktaxIncluded = check.IsNumber(taxIncluded_textBox.Text.Trim());

            if (checktaxIncluded == false)
            {
                MessageBox.Show("請勿空白或是輸入非數字", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int taxIncluded = int.Parse(this.taxIncluded_textBox.Text);

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getTaxIncluded(taxIncluded);
            insertFile_Form.Show();
            this.Close();
        }

        private void SelectPrice_Form_Load(object sender, EventArgs e)
        {
            untaxed_label.BackColor = Color.Transparent;
            untaxed_label.Parent = pictureBox1;

            taxIncluded_label.BackColor = Color.Transparent;
            taxIncluded_label.Parent = pictureBox1;
        }
    }
}
