using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace easyERP
{
    public partial class selectMemer : Form
    {
        //連線
        private string _connecString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        // 現在選取的分頁編號
        private int _currentPageIndex = 1;
        // 總共多少分頁
        private int _totalPage = 0;
        // 頁面大小
        private int _pageSize = 10;


        /// <summary>
        /// 計算頁數
        /// </summary>
        /// <param name="dt">The dt.</param>
        private void CalculateTotalPages(DataTable dt)
        {
            int rowCount = dt.Rows.Count;
            _totalPage = rowCount / _pageSize;

            //不足一個分頁行數的還是算一頁
            if (rowCount % _pageSize > 0)
                _totalPage += 1;
        }

        private DataTable GetCurrentRecords(int page)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                if (page == 1)
                {
                    cmd = new SqlCommand("Select TOP " + _pageSize +
                    " memberAccount, password, memberName, permissionName from Member ", con);
                }
                else
                {
                    //利用 SQL 語法來切換資料
                    int PreviousPageOffSet = (page - 1) * _pageSize;

                    cmd = new SqlCommand("Select TOP " + _pageSize + " memberAccount, password, memberName, permissionName " +
                        "FROM Member  where memberAccount " +
                        "NOT IN " +
                        "(Select TOP " + PreviousPageOffSet + "  memberAccount from Member ) "
                        , con);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";
            }
            return dt;
        }


        private void SelectMemer_Load(object sender, EventArgs e)
        {


        }

        //第一頁
        private void BtnFirstPage_Click(object sender, EventArgs e)
        {
            _currentPageIndex = 1;
            select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
        }

        //上一頁
        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex > 1)
            {
                _currentPageIndex--;
                select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
            }
        }

        //下一頁
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPageIndex < _totalPage)
            {
                _currentPageIndex++;
                select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
            }
        }


        //最後頁
        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPageIndex = _totalPage;
            select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
        }

        //設定分頁
        private void BtnSet_Click(object sender, EventArgs e)
        {
            //if (_pageSize != Convert.ToInt32(nudPageSize.Value))
            //{
            _currentPageIndex = 1;
            _pageSize = Convert.ToInt32(nudPageSize.Value);
            CalculateTotalPages(getData());
            lbTotalPage.Text = "共 " + _totalPage + " 頁";
            lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";
            select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
            //}
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        private DataTable getData()
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT memberAccount, password, memberName, permissionName  FROM [dbo].[Member] ", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    return dt;

                    // string dsss = select_dataGridView.DataSource.ToString();

                }
            }
        }

        private void SelectMember_button_Click(object sender, EventArgs e)
        {

            string userAccount = this.useraccount_textBox.Text;
            string password = this.password_textBox.Text;


            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (userAccount.Equals("") || password.Equals(""))
                    {
                        cmd = new SqlCommand("select  TOP 10 memberAccount,password,memberName,permissionName from Member", con);
                    }
                    else
                    {
                        cmd = new SqlCommand("select * from Member where memberAccount='" + userAccount + "'and password='" + password + "'", con);
                    }
                }

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                select_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }

        private void UpdateMember_button_Click(object sender, EventArgs e)
        {
            string updateAccount = this.update_useraccount_textBox.Text.Trim();
            string updatePassword = this.update_password_textBox.Text.Trim();
            string updateId = this.update_id_textBox.Text.Trim();
            string updateName = this.update_username_textBox.Text.Trim();


            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (updateAccount.Equals("") && updatePassword.Equals("") && updateName.Equals(""))
                    {
                        MessageBox.Show("請勿沒輸入就按修改!!");
                        return;
                    }
                    if (updateAccount != "" && updatePassword.Equals("") && updateName.Equals(""))//只輸入帳號
                    {
                        cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + updateAccount + "'  where memberID = " + updateId + "", con);
                    }
                    if (updateAccount != "" && updatePassword != "" && updateName.Equals(""))//只輸入帳號密碼
                    {
                        cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + updateAccount + "' , password='" + updatePassword + "' where memberID =" + updateId + "", con);
                    }
                    if (updateAccount.Trim().Length > 0 && updatePassword != "" && updateName != "")                                                                         //輸入帳號密碼姓名
                    {
                        cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + updateAccount + "' , password='" + updatePassword + "' , memberName='" + updateName + "' where memberID =" + updateId + "", con);
                    }

                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Update(dt);




                //修改完後重新查詢
                SqlCommand cmd1 = new SqlCommand();
                {
                    cmd1 = new SqlCommand(" select memberAccount, password, memberName, permissionName from Member where memberID ='" + updateId + "' ", con);

                }

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                //select --> datatable 
                select_dataGridView.DataSource = dt1;


                //  DataSet set = new DataSet();
                ////  DataTable dt = new DataTable();
                //  SqlDataAdapter da = new SqlDataAdapter();
                //  da.Fill(set);
                //  da.Update(set);
                //  select_dataGridView.DataSource = set;

            }
        }

        public selectMemer()
        {
            InitializeComponent();
        }

       
    }
}
