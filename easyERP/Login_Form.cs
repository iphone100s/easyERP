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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //設定標題的底色為透明標題
            label_title.BackColor = Color.Transparent;
            label_title.Parent = pictureBox_one;//將pictureBox設為標籤的父控件
            //pictureBox_one.Controls.Add(label_title);
            //label_title.Location = new Point(80, 80); //重新設定標籤的位置 此位置相對於父控件的左上角


        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void userTextBox_Click(object sender, EventArgs e)
        {
            this.userTextBox.Text = "";
        }

        private void PasswordTextBox_Click(object sender, EventArgs e)
        {
            this.passwordTextBox.Text = "";
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            
            string username = this.userTextBox.Text;
            string password = this.passwordTextBox.Text;


            if (username.Equals("") || password.Equals(""))
            {
                MessageBox.Show("請勿空白帳號密碼!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //到資料庫驗證
                //string selectSql = "select * from tb_user where username='" + username + "'and password='" + password + "'"; //測試用資料庫

                  string selectAccount = "select * from Member where memberAccount='" + username + "'and password='" + password + "'"; //正式用資料庫

                //string selectAccount = "select memberAccount,password,permission from Member where memberAccount='" + username + "'and password='" + password + "'"; //正式用資料庫
                //string selectAccount = "select memberAccount,password,permission from Member ";
           


                //StringBuilder sb = new StringBuilder();
                //sb.Append(" select memberAccount,password,permission from Member where memberAccount='" + username + "'and password='" + password + "' ");


                SqlHelp sqlhelper = new SqlHelp();

                // 1
                //回傳為int 抓單筆資料 如果有就會為1
                //int count = sqlhelper.SqlServerRecordCount(selectAccount); // 返回符合的結果數量
                //if (count > 0)
                //{
                //    MessageBox.Show("資訊驗證成功 即將跳轉頁面");                   
                //    Second_Form view = new Second_Form();//跳轉道主頁面
                //    // Main view = new Main();//建立新的頁面
                //    view.Show();//顯示新頁面
                //    this.Hide();//隱藏當前頁面
                //}
                //else
                //{
                //    MessageBox.Show("使用者名稱或密碼錯誤");
                //}


                // 2
                //回傳為string 在SqlHelp此物件抓出字串並回到這判斷
                //string ReturnPermission = sqlhelper.SqlServerRecordCount1(selectAccount); // 返回符合的結果數量
                //if (ReturnPermission.Equals("A"))
                //{
                //    //if (ReturnPermission.Equals("A"))
                //    //{
                //    MessageBox.Show("資訊驗證成功 即將跳轉頁面");

                //    //跳轉道主頁面
                //    Second_Form view = new Second_Form();
                //    // Main view = new Main();//建立新的頁面
                //    view.Show();//顯示新頁面
                //    this.Hide();//隱藏當前頁面
                //                //break;
                //                //}
                //                //else
                //                //{
                //                //    MessageBox.Show("資訊驗證成功 但無權限");
                //                //}
                //}
                //else
                //{
                //    MessageBox.Show("使用者名稱或密碼錯誤");
                //}

                // 3
                //FOR迴圈抓資料(在這抓取物件資料 回傳字串)
                //DataSet ds = sqlhelper.SqlServerRecordCount2(selectAccount); // 返回符合的結果數量
                //string ReturnPermission = string.Empty;
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    for (int a = 0; a < ds.Tables[0].Rows.Count; a++)
                //    {
                //        ReturnPermission = ds.Tables["Member"].Rows[a]["permission"].ToString();

                //        if (ReturnPermission.Equals("A"))
                //        {
                //            MessageBox.Show("資訊驗證成功 即將跳轉頁面");

                //            //跳轉道主頁面
                //            Second_Form view = new Second_Form();
                //            // Main view = new Main();//建立新的頁面
                //            view.Show();//顯示新頁面
                //            this.Hide();//隱藏當前頁面
                //            break;
                //        }
                //        else
                //        {
                //            MessageBox.Show("資訊驗證成功 但無權限");
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("使用者名稱或密碼錯誤");
                //}

                // 4
                //單筆抓資料(在這抓取物件資料 回傳字串)
                //DataSet ds = sqlhelper.SqlServerRecordCount2(selectAccount); // 返回符合的結果數量              
                //if (ds.Tables[0].Rows.Count > 0)
                //{
                //    string ReturnPermission = ds.Tables["Member"].Rows[0]["permission"].ToString(); //.Rows[0] 抓一排 如果0改成1 就是往下抓一排

                //    if (ReturnPermission.Equals("A"))
                //    {
                //        MessageBox.Show("資訊驗證成功 即將跳轉頁面");

                //        //跳轉道主頁面
                //        Second_Form view = new Second_Form();
                //        // Main view = new Main();//建立新的頁面
                //        view.Show();//顯示新頁面
                //        this.Hide();//隱藏當前頁面
                        
                //    }
                //    else
                //    {
                //        MessageBox.Show("資訊驗證成功 但無權限");
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("使用者名稱或密碼錯誤");
                //}


                DataSet ds = sqlhelper.SqlServerRecordCount2(selectAccount); // 返回符合的結果數量              
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string ReturnPermission = ds.Tables["Member"].Rows[0]["permission"].ToString(); //.Rows[0] 抓一排 如果0改成1 就是往下抓一排

                    //string sqlname = ds.Tables["Member"].Rows[0]["memberName"].ToString();

                    if (ReturnPermission.Equals("A") || ReturnPermission.Equals("B"))
                    {
                         ReturnPermission = ds.Tables["Member"].Rows[0]["memberName"].ToString().Trim();

                        //MessageBox.Show( ReturnPermission + " 歡迎您登入，請按確定登入系統" );

                        MessageBox.Show(ReturnPermission + " 歡迎您登入，請按確定登入系統", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //跳轉道主頁面
                        Second_Form view = new Second_Form();
                        
                        view.Show();//顯示新頁面
                        this.Hide();//隱藏當前頁面
                        //this.Close();//關閉視窗
                        
                    }
                    if (ReturnPermission.Equals("C"))
                    {

                        //MessageBox.Show( ReturnPermission + " 歡迎您登入，請按確定登入系統");
                        MessageBox.Show(ReturnPermission + " 歡迎您登入，請按確定登入系統", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //跳轉道主頁面
                        Second_Form view = new Second_Form();
                        view.Show();//顯示新頁面
                        this.Hide();//隱藏當前頁面
                        view.member_button.Enabled = false; //讓button反灰(屬性的modifiers要改成public)
                        //this.Close();//關閉視窗
                        //view.select_button.Visible = false;  //讓button不見
                    }

                }
                else
                {
                    MessageBox.Show("使用者名稱或密碼錯誤", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            this.userTextBox.Text = "";
            this.passwordTextBox.Text = "";
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
