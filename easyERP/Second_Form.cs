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

            Memer_Form selectMemer_Form = new Memer_Form();
            selectMemer_Form.ShowDialog();


        }


        private void Second_Form_Load(object sender, EventArgs e)
        {



        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.ShowDialog();

        }
    }
}
