using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using System.Configuration;
using System.Net.Mail;






/// <summary>
///主要包括sqlHelp資料庫訪問助手類 和常用的一些函式定義
///</summary>
///SqlHelp資料庫訪問助手
///1.public static void OpenConn()                                  //開啟資料庫連線
///2.public static void CloseConn()                                 //關閉資料庫連線
///3.public static SqlDataReader getDataReaderValue(string sql)     //讀取資料
///4.public DataSet GetDataSetValue(string sql, string tableName)   //返回DataSet
///5.public DataView GetDataViewValue(string sql)                   //返回DataView
///6.public DataTable GetDataTableValue(string sql)                 //返回DataTable
///7.public void ExecuteNonQuery(string sql)                        //執行一個SQL操作:新增、刪除、更新操作
///8.public int ExecuteNonQueryCount(string sql)                    //執行一個SQL操作:新增、刪除、更新操作，返回受影響的行
///9.public static object ExecuteScalar(string sql)                 //執行一條返回第一條記錄第一列的SqlCommand命令
///10.public int SqlServerRecordCount(string sql)                   //返回記錄數

namespace easyERP
{
    class SqlHelp
    {
        ///私有屬性:資料庫連線字串
        ///Data Source=(Local)          伺服器地址
        ///Initial Catalog=ERP  資料庫名稱
        ///User ID=sa                   資料庫使用者名稱
        ///Password=sa123       資料庫密碼

        //測試用資料連線
        //private const string connectionString = "Data Source=(Local);Pooling=False;Max Pool Size = 1024;Initial Catalog=login;Persist Security Info=True;User ID=sa;Password=sa123";

        private const string connectionString = "Data Source=(Local);Pooling=False;Max Pool Size = 1024;Initial Catalog=ERP;Persist Security Info=True;User ID=sa;Password=sa123";

        //private static  string _connecString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

        public static SqlConnection conn;

        //開啟資料庫連線
        public static void OpenConn()
        {
            string SqlCon = connectionString; //資料庫連線字串

            conn = new SqlConnection(SqlCon);

            if (conn.State.ToString().ToLower() == "open")
            {

            }
            else
            {
                conn.Open();
            }

            //using (SqlConnection conn = new SqlConnection(_connecString))
            //{
            //    conn.Open();

            //}


        }

        public static void CloseConn()
        {
            if (conn.State.ToString().ToLower() == "open")
            {
                //連線開啟時
                conn.Close();
                conn.Dispose();

            }
        }


        //public int SqlServerRecordCount(string sql)
        //{
        //    OpenConn();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = sql;
        //    cmd.Connection = conn;
            
        //    SqlDataReader dr;
        //    dr = cmd.ExecuteReader();
        //    int RecordCount = 0;
        //    while (dr.Read())
        //    {
        //        RecordCount = RecordCount + 1;
        //    }
        //    CloseConn();
        //    return RecordCount;
        //}

        //public string SqlServerRecordCount1(string sql)
        //{
        //    OpenConn();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.CommandText = sql;
        //    cmd.Connection = conn;
        //    SqlDataReader dr;
        //    string permission = string.Empty;
            
        //    dr = cmd.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        permission = dr["permission"].ToString().Trim();

        //    }
        //    CloseConn();
        //    return permission;
        //}

        public DataSet SqlServerRecordCount2(string sql)
        {
            OpenConn();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds, "Member");

            return ds;
        }
    }
}
