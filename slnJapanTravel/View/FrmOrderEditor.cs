using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmOrderEditor : Form
    {
        public FrmOrderEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000";//Trust Server Certificate=True";
            //con.Open();

            //SqlCommand cmd = new SqlCommand();
            //cmd.Connection = con;
            //cmd.CommandText = GetInsertSql();
            //cmd.ExecuteNonQuery();

            //con.Close();
            //MessageBox.Show("新增成功");
        }

        private string GetInsertSql()
        {
            string sql = "INSERT INTO 航班訂單資料 (";
            sql += "會員ID, ";
            sql += "付款方式編號, ";
            sql += "付款狀態編號, ";
            sql += "訂單狀態編號, ";
            sql += "優惠券ID, ";
            sql += "總金額";
            sql += ")VALUES(";
            sql += "1, ";
            sql += "1, ";
            sql += "1, ";
            sql += "1, ";
            sql += "'0', ";
            sql += "100)";

            return sql;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
