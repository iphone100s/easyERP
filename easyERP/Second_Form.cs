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
    public partial class Second_Form : Form
    {
        public Second_Form()
        {
            
            InitializeComponent();
        }


        private void Member_button_Click(object sender, EventArgs e)
        {
            //MDI視窗
            //ShowForm(selectMemer_Form.Instance);

            Member_Form memer_Form = new Member_Form();
            memer_Form.ShowDialog();

        }


        private void Second_Form_Load(object sender, EventArgs e)
        {


            //this.member_button.Visible = false;
            //this.insert_button.Visible = false;
        }





    }
}
