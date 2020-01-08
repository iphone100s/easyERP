using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace easyERP
{
    public partial class SelectIndate_Form : Form
    {
        public SelectIndate_Form()
        {
            InitializeComponent();
        }


        private void SelectinDate_button_Click(object sender, EventArgs e)
        {
            string startDate = this.startDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string finishDate = this.finishDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            InsertFile_Form insertFile_Form = new InsertFile_Form();
            insertFile_Form.getDate(startDate, finishDate);
            insertFile_Form.Show();
            this.Close();

        }

    }
  }

