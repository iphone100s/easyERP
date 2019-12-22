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
    public partial class Member_Form : Form
    {
        //MDI視窗
        //private static Member_Form _instance;

        //public static Member_Form Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new Member_Form();
        //        return _instance;
        //    }
        //}



        public Member_Form()
        {
            InitializeComponent();
        }

        private void Member_Form_Load(object sender, EventArgs e)
        {

        }

        private void Member_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //MDI視窗
            //_instance = null;
        }

        private void SelectMember_button_Click(object sender, EventArgs e)
        {
            selectMemer selectMemer_Form = new selectMemer();
            selectMemer_Form.ShowDialog();

            //selectMemer_Form selectMemer_Form2 = new selectMemer_Form();
            //selectMemer_Form2.ShowDialog();
        }
    }
}
