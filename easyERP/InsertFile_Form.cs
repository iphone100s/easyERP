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
    public partial class InsertFile_Form : Form
    {
        public InsertFile_Form()
        {
            InitializeComponent();
        }

        //連線
        private string _connecString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        // 現在選取的分頁編號
        private int _currentPageIndex = 1;
        // 總共多少分頁
        private int _totalPage = 0;
        // 頁面大小
        private int _pageSize = 10;

        //分頁功能

        // 計算頁數
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

        //設定分頁
        private void BtnSet_Click(object sender, EventArgs e)
        {
            //SelectMember_button.Enabled = false;
            //if (_pageSize != Convert.ToInt32(nudPageSize.Value))
            //{
            if (nudPageSize.Value == 0)
            {
                MessageBox.Show("請設定分頁!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                _currentPageIndex = 1;
                _pageSize = Convert.ToInt32(nudPageSize.Value);
                CalculateTotalPages(getData());
                lbTotalPage.Text = "共 " + _totalPage + " 頁";
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";
                select_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
                //}

                SelectFile_button.Enabled = true;
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
            }
        }


        //分頁語法
        private DataTable GetCurrentRecords(int page)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                if (page == 1)
                {
                    //cmd = new SqlCommand("Select TOP " + _pageSize +
                    //" memberID, memberAccount, password, memberName, permissionName from Member ", con);

                    cmd = new SqlCommand("select TOP " + _pageSize + " p.productNo, p.productName, p.productSpec, p.productSn, p.productModel," +
                        "p.inQuantity, p.inventoryQuantity, p.factoryName," +
                        "p.factoryNo, p.note," +
                        "m.Untaxed, m.taxIncluded," +
                        "a.depotNo, a.depotName," +
                        "t.inDate, t.outDate " +
                        "from Product p join Price m " +
                        "on p.productNo = m.productNo " +
                        "join Depot a " +
                        "on p.productNo = a.productNo " +
                        "join Date t " +
                        "on p.productNo = t.productNo ", con);
                }
                else
                {
                    //利用 SQL 語法來切換資料
                    int PreviousPageOffSet = (page - 1) * _pageSize;

                    //cmd = new SqlCommand("Select TOP " + _pageSize + " memberID, memberAccount, password, memberName, permissionName " +
                    //    "FROM Member  where memberAccount " +
                    //    "NOT IN " +
                    //    "(Select TOP " + PreviousPageOffSet + "  memberAccount from Member ) "
                    //    , con);

                    cmd = new SqlCommand("Select TOP " + _pageSize + " p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel, " +
                        "p.inQuantity, p.inventoryQuantity, p.factoryName," +
                        "p.factoryNo, p.note," +
                        "m.Untaxed, m.taxIncluded," +
                        "a.depotNo, a.depotName," +
                        "t.inDate, t.outDate " +
                        "from Product p join Price m " +
                        "on p.productNo = m.productNo " +
                        "join Depot a " +
                        "on p.productNo = a.productNo " +
                        "join Date t " +
                        "on p.productNo = t.productNo " +
                        "where 	number NOT IN " +
                        "(Select TOP " + PreviousPageOffSet + "  number from Product p join Price m  " +
                        "  on p.productNo = m.productNo" +
                        " join Depot a " +
                        " on  p.productNo = a.productNo " +
                        " join Date t " +
                        " on p.productNo = t.productNo) "
                        , con);

                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";
            }
            return dt;
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



        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        private DataTable getData()
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
                    "p.inQuantity, p.inventoryQuantity, p.factoryName," +
                    "p.factoryNo, p.note," +
                    "m.Untaxed, m.taxIncluded," +
                    "a.depotNo, a.depotName," +
                    "t.inDate, t.outDate " +
                    "from Product p join Price m " +
                    "on p.productNo = m.productNo " +
                    "join Depot a " +
                    "on p.productNo = a.productNo " +
                    "join Date t " +
                    "on p.productNo = t.productNo ", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    return dt;
                }
            }
        }


        //查詢
        private void SelectFile_button_Click(object sender, EventArgs e)
        {

        }
        //修改
        private void UpdateFile_button_Click(object sender, EventArgs e)
        {

        }
        //查詢
        private void DeleteFile_button_Click(object sender, EventArgs e)
        {

        }
        //新增
        private void IInsertFile_button_Click(object sender, EventArgs e)
        {

        }

        private void InsertFile_Form_Load(object sender, EventArgs e)
        {


            SelectFile_button.Enabled = false;
            btnFirstPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = false;
            btnLastPage.Enabled = false;




        }
    }
}
