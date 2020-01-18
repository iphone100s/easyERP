using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            try
            {
                if (username.Equals("") || password.Equals(""))
                {
                    MessageBox.Show("請勿空白帳號密碼!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {

                    string selectAccount = "select * from Member where memberAccount='" + username + "'and password='" + password + "'"; //正式用資料庫

                    SqlHelp sqlhelper = new SqlHelp();


                    DataSet ds = sqlhelper.SqlServerRecordCount2(selectAccount); // 返回符合的結果數量     

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string ReturnPermission = ds.Tables["Member"].Rows[0]["permission"].ToString(); //.Rows[0] 抓一排 如果0改成1 就是往下抓一排
                        int ReturnNemberError = (int)ds.Tables["Member"].Rows[0]["memberError"]; //.Rows[0] 抓一排 如果0改成1 就是往下抓一排

                        //string sqlname = ds.Tables["Member"].Rows[0]["memberName"].ToString();
                        if (ReturnNemberError > 2)
                        {
                            MessageBox.Show("密碼已被鎖定!! 請洽管理員", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                        if (ReturnPermission.Equals("A") || ReturnPermission.Equals("B"))
                        {
                            ReturnPermission = ds.Tables["Member"].Rows[0]["memberName"].ToString().Trim();


                            string updateDeleteMemberError = "UPDATE Member SET memberError = 0  WHERE memberAccount ='" + username + "' ; "; //正式用資料庫
                            sqlhelper.SqlServerRecordCount2(updateDeleteMemberError);


                            MessageBox.Show(ReturnPermission + " 歡迎您登入，請按確定登入系統", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //跳轉道主頁面
                            Second_Form view = new Second_Form();

                            view.Show();//顯示新頁面
                            this.Hide();//隱藏當前頁面
                                        //this.Close();//關閉視窗

                        }
                        if (ReturnPermission.Equals("C"))
                        {
                            string updateDeleteMemberError = "UPDATE Member SET memberError = 0  WHERE memberAccount ='" + username + "' ; "; //正式用資料庫
                            sqlhelper.SqlServerRecordCount2(updateDeleteMemberError);

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
                    if (ds.Tables[0].Rows.Count == 0)
                    {


                        string selectMemberError = "select memberAccount,memberError from Member where memberAccount='" + username + "' ; "; //正式用資料庫
                        DataSet selectError = sqlhelper.SqlServerRecordCount2(selectMemberError);
                        if (selectError.Tables["Member"].Rows.Count > 0)
                        {
                            int ReturnNemberError = (int)selectError.Tables["Member"].Rows[0]["memberError"]; //.Rows[0] 抓一排 如果0改成1 就是往下抓一排

                            if (ReturnNemberError < 3)
                            {
                                string updateAddMemberError = "UPDATE Member SET memberError = memberError + 1 WHERE memberAccount ='" + username + "' ; "; //正式用資料庫
                                sqlhelper.SqlServerRecordCount2(updateAddMemberError);
                                MessageBox.Show("密碼錯誤喔!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            if (ReturnNemberError == 3)
                            {
                                string updateAddMemberError = "UPDATE Member SET memberErrorName = '已鎖定' WHERE memberAccount ='" + username + "' ; "; //正式用資料庫
                                sqlhelper.SqlServerRecordCount2(updateAddMemberError);
                                MessageBox.Show("帳號已鎖定!!請洽管理員", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("帳號或密碼錯誤喔!!", "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("系統有問題，請洽管理員!!!" + ex.Message, "提示訊息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
