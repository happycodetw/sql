using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_insert_into
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = cn.cnn) //連接資料庫
            {
                con.Open();//開啓資料庫
                SqlCommand cmd = new SqlCommand();//宣告執行sql指令的物件   Command=>命令
                cmd.Connection = con;  //連接sql   Connection=>連接
                cmd.CommandText =    //打sql指令的地方
                    $"Select Name From Account";   //Select=>選擇
                //cmd.ExecuteScalar()    只能一次抓一筆資料
                SqlDataReader dr = cmd.ExecuteReader();       //一次抓多筆資料
                while (dr.Read())   //讀取檔案
                {
                    if (!dr.Equals(DBNull.Value))   // 直到沒有
                    {
                        comboBox1.Items.Add(dr[0].ToString());   // 顯示第一筆資料
                    }
                }
            }
        }
    }
}
