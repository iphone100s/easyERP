using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace easyERP
{
    public partial class Memer_Form : Form
    {
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

                SelectMember_button.Enabled = true;
                btnFirstPage.Enabled = true;
                btnPreviousPage.Enabled = true;
                btnNextPage.Enabled = true;
                btnLastPage.Enabled = true;
                ExportExcel_button.Enabled = true;

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
                    cmd = new SqlCommand("Select TOP " + _pageSize +
                    " memberID, memberAccount, password, memberName, permissionName, memberErrorName from Member ", con);
                }
                else
                {
                    //利用 SQL 語法來切換資料
                    int PreviousPageOffSet = (page - 1) * _pageSize;

                    cmd = new SqlCommand("Select TOP " + _pageSize + " memberID, memberAccount, password, memberName, permissionName, memberErrorName " +
                        "FROM Member  where memberID " +
                        "NOT IN " +
                        "(Select TOP " + PreviousPageOffSet + "  memberID from Member ) "
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
                using (SqlCommand cmd = new SqlCommand("SELECT memberID,memberAccount, password, memberName, permissionName, memberErrorName  FROM Member ", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    return dt;

                }
            }
        }



        //查詢
        private void SelectMember_button_Click(object sender, EventArgs e)
        {

            //string memberAccount = this.memberAccount_textbox.Text.Trim();
            //string memberName = this.memberName_textBox.Text.Trim();
            //string password = this.password_textBox.Text.Trim();
            string memberID = this.memberID_textBox.Text.Trim();


            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (memberID.Equals(""))
                    {
                        MessageBox.Show("請輸入員工ID!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    //if (memberAccount.Equals("") || password.Equals(""))
                    //{
                    //    cmd = new SqlCommand("select  TOP 10 memberAccount,password,memberName,permissionName from Member", con);
                    //}
                    else
                    {
                        //cmd = new SqlCommand("select memberID,memberAccount, password, memberName, permissionName from Member where memberAccount='" + memberAccount + "'and password='" + password + "'", con);
                        cmd = new SqlCommand("select memberID,memberAccount, password, memberName, permissionName, memberErrorName from Member where memberID='" + memberID + "' ", con);
                    }
                }

                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                select_dataGridView.DataSource = dt;
                lbCurrentPage.Text = "第 " + _currentPageIndex + " 頁";

            }

        }

        //修改
        private void UpdateMember_button_Click(object sender, EventArgs e)
        {

            string memberAccount = this.memberAccount_textbox.Text.Trim();
            string memberName = this.memberName_textBox.Text.Trim();
            string password = this.password_textBox.Text.Trim();
            string memberID = this.memberID_textBox.Text.Trim();

            //下拉式選單
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)status_comboBox.SelectedItem;
            string key = kvp.Key.ToString();
            string Value = kvp.Value.ToString();

            //下拉式選單
            KeyValuePair<string, string> Membererror = (KeyValuePair<string, string>)error_comboBox.SelectedItem;
            string keyError = Membererror.Key.ToString();
            string ValueError = Membererror.Value.ToString();


            using (SqlConnection con = new SqlConnection(_connecString))
            {
                SqlCommand cmd = new SqlCommand();
                {
                    if (memberID.Equals(""))
                    {
                        MessageBox.Show("請輸入ID!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {

                        if (memberAccount.Equals("") && password.Equals("") && memberName.Equals(""))
                        {
                            MessageBox.Show("請輸入帳號，密碼，姓名!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (memberAccount != "" && password.Equals("") && memberName.Equals(""))//輸入 帳號
                        {
                            cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + memberAccount + "'  where memberID = " + memberID + "", con);

                        }
                        if (memberAccount != "" && password != "" && memberName.Equals(""))//輸入 帳號 密碼
                        {
                            cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + memberAccount + "' , password='" + password + "' where memberID =" + memberID + "", con);

                        }
                        if (memberAccount.Trim().Length > 0 && password != "" && memberName != "")   //輸入 帳號 密碼 姓名
                        {
                            cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + memberAccount + "' , password='" + password + "' , memberName='" + memberName + "' where memberID =" + memberID + " ", con);

                        }
                        if (memberAccount.Trim().Length > 0 && password != "" && memberName != "" && key != "" && Value != "")   //輸入 帳號 密碼 姓名 職等
                        {
                            cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + memberAccount + "' , password='" + password + "' , memberName='" + memberName + "' , permission='" + Value + "' , permissionName='" + key + "' where memberID =" + memberID + " ", con);

                        }
                        if (memberAccount.Trim().Length > 0 && password != "" && memberName != "" && key != "" && Value != "" && keyError != "" && ValueError != "")   //輸入 帳號 密碼 姓名 職等 狀態
                        {
                            cmd = new SqlCommand(" UPDATE Member SET memberAccount='" + memberAccount + "' , password='" + password + "' , memberName='" + memberName + "' , permission='" + Value + "' , permissionName='" + key + "', memberError=" + ValueError + " , memberErrorName='" + keyError + "' where memberID =" + memberID + " ", con);

                        }
                        updateSuccess();
                    }

                }

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                da.Update(dt);

                //修改完後重新查詢
                SqlCommand cmd1 = new SqlCommand();
                {
                    cmd1 = new SqlCommand(" select memberID,memberAccount, password, memberName, permissionName, memberErrorName from Member where memberID ='" + memberID + "' ", con);
                }

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                da1.Fill(dt1);

                select_dataGridView.DataSource = dt1;

            }
        }

        private void updateSuccess()
        {
            MessageBox.Show("資料修改成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //新增
        private void IInsertMember_button_Click(object sender, EventArgs e)
        {
            string memberAccount = this.memberAccount_textbox.Text.Trim();
            string memberName = this.memberName_textBox.Text.Trim();
            string password = this.password_textBox.Text.Trim();
            string memberID = this.memberID_textBox.Text.Trim();


            //下拉式選單
            KeyValuePair<string, string> kvp = (KeyValuePair<string, string>)status_comboBox.SelectedItem;
            string key = kvp.Key.ToString();
            string Value = kvp.Value.ToString();

            //下拉式選單
            KeyValuePair<string, string> Membererror = (KeyValuePair<string, string>)error_comboBox.SelectedItem;
            string keyError = Membererror.Key.ToString();
            string ValueError = Membererror.Value.ToString();

            string selectID = "select memberID from Member where memberID='" + memberID + "' ";
            //string selectID = "select memberID from Member";
            SqlHelp sqlhelper = new SqlHelp();

            DataSet ds = sqlhelper.SqlServerRecordCount2(selectID); // 返回符合的結果數量



            using (SqlConnection con = new SqlConnection(_connecString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();
                {


                    try
                    {
                        if (memberAccount.Equals("") || password.Equals("") || memberName.Equals("") || memberID.Equals(""))
                        {
                            MessageBox.Show("請勿空白帳號，姓名，密碼，員工ID!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            string ReturnPermission = ds.Tables["Member"].Rows[0]["memberID"].ToString();
                            if (ReturnPermission.Equals(memberID))
                            {
                                MessageBox.Show("請勿重複員工ID!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }
                        }
                        else
                        {
                            cmd = new SqlCommand("insert into Member(memberAccount, password, memberName, permission,permissionName, memberError,memberErrorName,memberID) values('" + memberAccount + "','" + password + "','" + memberName + "','" + Value + "','" + key + "'," + ValueError + ",'" + keyError + "','" + memberID + "') ", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("資料儲存成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd = new SqlCommand(" select memberID,memberAccount, password, memberName, permissionName, memberErrorName from Member where memberID ='" + memberID + "' ", con);
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

                //SqlCommand cmd1 = new SqlCommand();
                //{

                //    //全部搜尋
                //    //cmd1 = new SqlCommand(" select * from Member ", con);

                //    //單筆搜尋
                //    cmd1 = new SqlCommand(" select memberID,memberAccount, password, memberName, permissionName from Member where memberAccount ='" + memberAccount + "' ", con);

                //}

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);

                select_dataGridView.DataSource = dt1;

            }
        }

        //刪除
        private void DeleteMember_button_Click(object sender, EventArgs e)
        {

            string memberAccount = this.memberAccount_textbox.Text.Trim();
            string memberName = this.memberName_textBox.Text.Trim();
            string password = this.password_textBox.Text.Trim();
            string memberID = this.memberID_textBox.Text.Trim();

            using (SqlConnection con = new SqlConnection(_connecString))
            {

                con.Open();


                SqlCommand cmd = new SqlCommand();
                {

                    try
                    {
                        if (memberAccount.Equals("") || password.Equals("") || memberID.Equals(""))
                        {
                            MessageBox.Show("請輸入帳號，密碼，員工ID!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                        else
                        {
                            cmd = new SqlCommand("delete from Member where memberID ='" + memberID + "'", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("資料刪除成功!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cmd = new SqlCommand(" select TOP 10 * from Member ", con);
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
                //SqlCommand cmd1 = new SqlCommand();
                //{

                //    //全部搜尋
                //    cmd1 = new SqlCommand(" select TOP 10 * from Member ", con);

                //    //單筆搜尋
                //    // cmd1 = new SqlCommand(" select memberAccount, password, memberName, permissionName from Member where memberAccount ='" + updateAccount + "' ", con);
                //}

                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                da1.Fill(dt1);

                select_dataGridView.DataSource = dt1;

            }
        }




        private void SelectMemer_Load(object sender, EventArgs e)
        {
            //下拉式選項
            status_comboBox.Items.Add(new KeyValuePair<string, string>("超級使用者", "A"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("主管", "B"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("一般職員", "C"));
            status_comboBox.Items.Add(new KeyValuePair<string, string>("離職員工", "F"));

            status_comboBox.DisplayMember = "Key";
            status_comboBox.ValueMember = "Value";
            status_comboBox.SelectedIndex = 0; //設定下拉式選項為第一筆

            error_comboBox.Items.Add(new KeyValuePair<string, string>("未鎖定", "0"));
            error_comboBox.Items.Add(new KeyValuePair<string, string>("已鎖定", "3"));

            error_comboBox.DisplayMember = "Key";
            error_comboBox.ValueMember = "Value";
            error_comboBox.SelectedIndex = 0; //設定下拉式選項為第一筆


            SelectMember_button.Enabled = false;
            btnFirstPage.Enabled = false;
            btnPreviousPage.Enabled = false;
            btnNextPage.Enabled = false;
            btnLastPage.Enabled = false;
            ExportExcel_button.Enabled = false;


            //設定標題的底色為透明標題
            Employee_label.BackColor = Color.Transparent;
            Employee_label.Parent = pictureBox1;

            memberAccount_label.BackColor = Color.Transparent;
            memberAccount_label.Parent = pictureBox1;

            Password_label.BackColor = Color.Transparent;
            Password_label.Parent = pictureBox1;

            permissionName_label.BackColor = Color.Transparent;
            permissionName_label.Parent = pictureBox1;

            memberName_label.BackColor = Color.Transparent;
            memberName_label.Parent = pictureBox1;

            memberID_label.BackColor = Color.Transparent;
            memberID_label.Parent = pictureBox1;

            Employee_label.BackColor = Color.Transparent;
            Employee_label.Parent = pictureBox1;

            lbCurrentPage.BackColor = Color.Transparent;
            lbCurrentPage.Parent = pictureBox1;

            lbTotalPage.BackColor = Color.Transparent;
            lbTotalPage.Parent = pictureBox1;

            error_label.BackColor = Color.Transparent;
            error_label.Parent = pictureBox1;
            

        }



        public Memer_Form()
        {
            InitializeComponent();
        }

        private void Select_dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int A = select_dataGridView.Rows.Count;

            if (A == 0)
            {
                MessageBox.Show("請先查詢", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                memberID_textBox.Text = select_dataGridView.CurrentRow.Cells[0].Value.ToString();
                memberAccount_textbox.Text = select_dataGridView.CurrentRow.Cells[1].Value.ToString();
                memberName_textBox.Text = select_dataGridView.CurrentRow.Cells[2].Value.ToString();
                password_textBox.Text = select_dataGridView.CurrentRow.Cells[3].Value.ToString();
                status_comboBox.Text = select_dataGridView.CurrentRow.Cells[4].Value.ToString();
                error_comboBox.Text = select_dataGridView.CurrentRow.Cells[5].Value.ToString();
            }

        }


        private void EasyERP_Member_CurrentChanged(object sender, EventArgs e)
        {

        }


        //輸出EXCEL表    
        private void ExportExcel_button_Click(object sender, EventArgs e)
        {
            string saveFileName = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Execl files (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt = true;
            saveFileDialog.Title = "Export Excel File To";
            saveFileDialog.ShowDialog();
            saveFileName = saveFileDialog.FileName;

            if (saveFileName.IndexOf(":") < 0)
                return;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("請確定是否有安裝Excel?", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 
            //下面只是匯出到excel的簡單格式設定 可自行變化 
            //worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 10]).MergeCells = true; //左右合併 
            //            worksheet.get_Range(worksheet.Cells[2, 1], worksheet.Cells[2, 10]).MergeCells = true; //左右合併 
            //            worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[2, 10]).MergeCells = true; //上下合併 1.2列合併 
            //           worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 10]).MergeCells = true; //左右合併 
            //           worksheet.get_Range(worksheet.Cells[4, 1], worksheet.Cells[4, 10]).MergeCells = true; //左右合併 
            //          worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[4, 10]).MergeCells = true; //上下合併 3.4列合併 
            //          worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 10]).Cells.Font.Size = 20; //標題字型大小 
            //           worksheet.get_Range(worksheet.Cells[1, 1], worksheet.Cells[1, 10]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //          worksheet.get_Range(worksheet.Cells[3, 1], worksheet.Cells[3, 10]).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;



            DateTime dt = DateTime.Now;
            worksheet.Cells[1, 7] = "員工資料一覽表"; //第1行 第7列
            worksheet.Cells[3, 7] = "報表產出時間為: " //第3行 第7列
            + dt.Year + "年" + dt.Month.ToString().PadLeft(2, '0') +"月"+ dt.Day.ToString().PadLeft(2, '0')+"日 "+dt.Hour.ToString()+":"+dt.Minute.ToString().PadLeft(2, '0') + "分";


            for (int i = 0; i < select_dataGridView.ColumnCount; i++)
            {
                worksheet.Cells[5, i + 1] = select_dataGridView.Columns[i].HeaderText; // 依照上面合併使用過的列數(最大值+1) 前面四行我拿作標題跟時間了所以重第五列開始 
            }
            for (int r = 0; r < select_dataGridView.Rows.Count; r++)
            {
                for (int i = 0; i < select_dataGridView.ColumnCount; i++)
                {
                    worksheet.Cells[r + 6, i + 1] = select_dataGridView.Rows[r].Cells[i].Value;
                }
                System.Windows.Forms.Application.DoEvents();

                worksheet.Columns.EntireColumn.AutoFit();//自動調整欄位 



                if (saveFileName != "")
                {
                    try
                    {
                        workbook.Saved = true;
                        workbook.SaveCopyAs(saveFileName);
                    }
                    catch (Exception ex)
                    {
                       MessageBox.Show("匯出文件時出錯,EXCEL文件可能正在使用!!\n" + ex.Message);
                      
                    }

                }
            }
        }
    }
}
