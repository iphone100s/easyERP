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
using System.Web.UI.WebControls;
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
                selectFile_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
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
            selectFile_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
        }

        //上一頁
        private void BtnPreviousPage_Click(object sender, EventArgs e)
        {
            if (this._currentPageIndex > 1)
            {
                _currentPageIndex--;
                selectFile_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
            }
        }

        //下一頁
        private void BtnNextPage_Click(object sender, EventArgs e)
        {
            if (_currentPageIndex < _totalPage)
            {
                _currentPageIndex++;
                selectFile_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
            }
        }

        //最後頁
        private void BtnLastPage_Click(object sender, EventArgs e)
        {
            _currentPageIndex = _totalPage;
            selectFile_dataGridView.DataSource = GetCurrentRecords(_currentPageIndex);
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
           string productNo = this.productNo_textBox.Text.Trim();

            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (productNo.Equals(""))
                    {
                        MessageBox.Show("請輸入產品編號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {                       
                        cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                            " where p.productNo = '" + productNo + "' ", con);
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";
            }
        }

        //修改
        private void UpdateFile_button_Click(object sender, EventArgs e)
        {
            string productNo = this.productNo_textBox.Text.Trim();
            string productName = this.productName_textBox.Text.Trim();
            string productSn = this.productSn_textBox.Text.Trim();
            string productModel = this.productModel_textBox.Text.Trim();
            string productSpec = this.productSpec_textBox.Text.Trim();

            //int inQuantity = Convert.ToInt32(this.inQuantity_textBox.Text);
            //int inventoryQuantity = Convert.ToInt32(this.inventoryQuantity_textBox.Text);

            int inQuantity = int.Parse(this.inQuantity_textBox.Text);
            int inventoryQuantity = int.Parse(this.inventoryQuantity_textBox.Text);

            //string inQuantity = this.inQuantity_textBox.Text;
            //string inventoryQuantity = this.inventoryQuantity_textBox.Text;

            string factoryNo = this.factoryNo_textBox.Text.Trim();
            string factoryName = this.factoryName_textBox.Text.Trim();

            string depotNo = this.depotNo_textBox.Text.Trim();
            string depotName = this.depotName_textBox.Text.Trim();
           
            int untaxed = int.Parse(this.untaxed_textBox.Text);
            int taxIncluded = int.Parse(this.taxIncluded_textBox.Text);

            string inDate = this.inDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string outDate = this.outDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            string note = this.note_textBox.Text.Trim();


            ////下拉式選單
            //KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)status_comboBox.SelectedItem;
            //string key = kvp.Key.ToString();
            //string Value = kvp.Value.ToString();


            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (productNo.Equals(""))
                    {
                        MessageBox.Show("請輸入產品編號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        cmd = new SqlCommand(" UPDATE Date SET inDate = '" + inDate + "' , outDate = '" + outDate + "' WHERE productNo =  '" + productNo + "' ; " +
                            "UPDATE Depot SET depotNo = '" + depotNo + "' , depotName = '" + depotName + "'  WHERE productNo = '" + productNo + "' ;" +
                            "UPDATE Price SET Untaxed = " + untaxed + " , taxIncluded  = " + taxIncluded + "  WHERE productNo  = '" + productNo + "' ;" +
                            "UPDATE Product SET productName = '" + productName + "' , productSpec = '" + productSpec + "' , productSn = '" + productSn + "' , productModel = '" + productModel + "' , inQuantity = " + inQuantity + ", inventoryQuantity = " + inventoryQuantity + ", factoryName = '" + factoryName + "', factoryNo = '" + factoryNo + "', note = '" + note + "' " +
                            "WHERE productNo  = '" + productNo + "' ; ", con);

                        MessageBox.Show("資料修改成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Update(dt);

                //修改完後重新查詢
                SqlCommand cmd1 = new SqlCommand();
                {
                    cmd1 = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                            " where p.productNo = '" + productNo + "' ", con);
                }

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                selectFile_dataGridView.DataSource = dt1;

            }
        }
        //刪除
        private void DeleteFile_button_Click(object sender, EventArgs e)
        {
            string productNo = this.productNo_textBox.Text.Trim();
            string productSn = this.productSn_textBox.Text.Trim();
            //string productModel = this.productModel_textBox.Text.Trim();


            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();

                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (productNo.Equals("") || productSn.Equals("") )
                        {
                            MessageBox.Show("請輸入產品編號，產品序號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("delete from Product where productNo ='" + productNo + "' AND productSn  ='" + productSn + "';  " +
                                "delete from Date where productNo ='" + productNo + "'; " +
                                "delete from Depot where productNo ='" + productNo + "'; " +
                                "delete from Price where productNo ='" + productNo + "' ", con);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("資料刪除成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);

                selectFile_dataGridView.DataSource = dt1;

            }
        }

        //新增
        private void IInsertFile_button_Click(object sender, EventArgs e)
        {

            string productNo = this.productNo_textBox.Text.Trim();
            string productName = this.productName_textBox.Text.Trim();
            string productSn = this.productSn_textBox.Text.Trim();
            string productModel = this.productModel_textBox.Text.Trim();
            string productSpec = this.productSpec_textBox.Text.Trim();

            //int inQuantity = Convert.ToInt32(this.inQuantity_textBox.Text);
            int inQuantity = int.Parse(this.inQuantity_textBox.Text);
            int inventoryQuantity = int.Parse(this.inventoryQuantity_textBox.Text);

            string factoryNo = this.factoryNo_textBox.Text.Trim();
            string factoryName = this.factoryName_textBox.Text.Trim();

            string depotNo = this.depotNo_textBox.Text.Trim();
            string depotName = this.depotName_textBox.Text.Trim();

            int untaxed = int.Parse(this.untaxed_textBox.Text);
            int taxIncluded = int.Parse(this.taxIncluded_textBox.Text);

            string inDate = this.inDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string outDate = this.outDate_dateTimePicker.Value.Date.ToString("yyyy-MM-dd");

            string note = this.note_textBox.Text.Trim();



            ////下拉式選單
            //KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)status_comboBox.SelectedItem;
            //string key = kvp.Key.ToString();
            //string Value = kvp.Value.ToString();


            //查詢重複產品編號
            string pNo = "select productNo from Product where productNo='" + productNo + "' ";
            //string selectID = "select memberID from Member";
            SqlHelp sqlhelper = new SqlHelp();
            DataSet ds = sqlhelper.SqlServerRecordCount2(pNo); // 返回符合的結果數量



            using (SqlConnection con = new SqlConnection(_connecString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                {
                    //inQuantity.Equals("") ||

                    try
                    {
                        if (productNo.Equals("") || productSn.Equals("") ||  factoryNo.Equals("") || factoryName.Equals("") || depotNo.Equals("") || depotName.Equals("") || inDate.Equals(""))
                        {
                            MessageBox.Show("請勿空白產品編號" + Environment.NewLine + 
                                                    "產品序號" + Environment.NewLine + 
                                                        "數量" + Environment.NewLine + 
                                                    "廠商編號" + Environment.NewLine + 
                                                    "廠商名稱" + Environment.NewLine + 
                                                    "倉庫編號" + Environment.NewLine + 
                                                    "倉庫名稱" + Environment.NewLine + 
                                                    "進貨日期", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            string ReturnPermission = ds.Tables["Product"].Rows[0]["productNo"].ToString();
                            if (ReturnPermission.Equals(productNo))
                            {
                                MessageBox.Show("請勿重複產品編號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                        else
                        {
                            cmd = new SqlCommand("insert into Date(inDate, outDate,productNo) values('" + inDate + "','" + outDate + "','" + productNo + "');" +
                                                 "insert into Depot(depotNo, depotName,productNo) values('" + depotNo + "','" + depotName + "','" + productNo + "');" +
                                                 "insert into Price(Untaxed, taxIncluded,productNo) values(" + untaxed + "," + taxIncluded + ",'" + productNo + "'); " +
                                                 "insert into Product(productNo, productName,productSpec,productSn,productModel,inQuantity,inventoryQuantity,factoryName,factoryNo,note) values" +
                                                 "(" + productNo + "," + productName + ",'" + productSpec + "' ,'" + productSn + "','" + productModel + "'," + inQuantity + "," + inventoryQuantity + ",'" + factoryName + "','" + factoryNo + "','" + note + "' ) ", con);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("資料儲存成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                            " where p.productNo = '" + productNo + "' ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);

                selectFile_dataGridView.DataSource = dt1;

            }
        }

        private void InsertFile_Form_Load(object sender, EventArgs e)
        {
            //下拉式選項
            status_comboBox.Items.Add(new KeyValuePair<string, string>("女裝與服飾配件", "A"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("女包精品與女鞋", "B"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("美容保養與彩妝", "C"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("男性精品與服飾", "D"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("手錶與飾品配件", "E"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("嬰幼兒與孕婦", "F"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("電腦平板與周邊", "G"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("相機攝影與周邊", "H"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("手機配件與通訊", "I"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("家電與影音視聽", "J"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("汽機車精品百貨", "K"));

            status_comboBox.DisplayMember = "Key";
            status_comboBox.ValueMember = "Value";
            status_comboBox.SelectedIndex = 0; //設定下拉式選項為第一筆

            SelectFile_button.Enabled = false;
            btnFirstPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = false;
            btnLastPage.Enabled = false;

          

        }

        //金額查詢
        private void SelectPrice_button_Click(object sender, EventArgs e)
        {
            SelectPrice_Form SelectPrice_Form = new SelectPrice_Form();
            SelectPrice_Form.Show();
            this.Close();
        }
        //未稅金額查詢
        public void getUntaxed(int untaxed)
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (untaxed.Equals(""))
                        {
                            MessageBox.Show("請輸入未稅金額!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                                " where m.Untaxed Like '%" + untaxed + "%'  ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }

        //含稅金額查詢
        public void getTaxIncluded(int taxIncluded)
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (taxIncluded.Equals(""))
                        {
                            MessageBox.Show("請輸入含稅金額!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                                " where m.taxIncluded Like '%" + taxIncluded + "%'  ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }







        //廠商查詢
        private void SelectFactory_button_Click(object sender, EventArgs e)
        {
            SelectFactory_Form SelectFactory_Form = new SelectFactory_Form();
            SelectFactory_Form.Show();
            this.Close();

        }
        //廠商編號查詢
        public void getFactoryNo(string factoryNo)
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (factoryNo.Equals(""))
                        {
                            MessageBox.Show("請輸入廠商編號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                                " where p.factoryNo Like '%" + factoryNo + "%'  ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }


        //廠商名稱查詢
        public void getFactoryName(string factoryName)
        {
            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (factoryName.Equals(""))
                        {
                            MessageBox.Show("請輸入廠商編號!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                                " where p.factoryNo Like '%" + factoryName + "%'  ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }


        //出貨日期查詢
        private void SelectoutDate_button_Click(object sender, EventArgs e)
        {
            SelectOutdate_Form selectOutdate_Form = new SelectOutdate_Form();
            selectOutdate_Form.Show();
            this.Close();
        }


        //進貨日期查詢
        private void SelectinDate_button_Click(object sender, EventArgs e)
        {
            SelectIndate_Form selectIndate_Form = new SelectIndate_Form();
            selectIndate_Form.Show();
            this.Close();
        }

        public void getDate(string startDate, string finishDate)
        {

            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();
                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (startDate.Equals("") || finishDate.Equals(""))
                        {
                            MessageBox.Show("請輸入日期!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("select p.productNo ,p.productName,p.productSpec,p.productSn,p.productModel," +
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
                                " where t.inDate BETWEEN '" + startDate + "'  and '" + finishDate + "' ", con);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                selectFile_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }
        }



        private void SelectFile_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int A = selectFile_dataGridView.Rows.Count;


            if (A == 1)
            {
                MessageBox.Show("請先查詢!");
                return;
            }
            else
            {


                productNo_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[0].Value.ToString();
                productName_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[1].Value.ToString();
                productSpec_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[2].Value.ToString();
                productSn_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[3].Value.ToString();
                productModel_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[4].Value.ToString();
                

                inQuantity_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[5].Value.ToString();
                inventoryQuantity_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[6].Value.ToString();
                factoryNo_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[7].Value.ToString();
                factoryName_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[8].Value.ToString();


                string dateInput = selectFile_dataGridView.CurrentRow.Cells[9].Value.ToString();
                DateTime parsedDate = DateTime.Parse(dateInput);
                inDate_dateTimePicker.Value = parsedDate;



                string dateInputa = selectFile_dataGridView.CurrentRow.Cells[10].Value.ToString();
                DateTime parsedDatea = DateTime.Parse(dateInputa);
                outDate_dateTimePicker.Value = parsedDatea;




                depotNo_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[11].Value.ToString();
                depotName_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[12].Value.ToString();

                untaxed_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[13].Value.ToString();
                taxIncluded_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[14].Value.ToString();
                note_textBox.Text = selectFile_dataGridView.CurrentRow.Cells[15].Value.ToString();


            }

        }


    }
}
