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
    public partial class FrmOrderItineraryEditor : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";  //本機ConnectionString

        public FrmOrderItineraryEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = GetInsertSql();
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("新增成功");
        }

        private string GetInsertSql()
        {
            string sql = "INSERT INTO 行程訂單資料 (";
            sql += "會員ID, ";
            sql += "行程批次編號, ";
            sql += "數量, ";
            sql += "下單時間, ";
            sql += "付款方式編號, ";
            sql += "付款狀態編號, ";
            sql += "付款時間, ";
            sql += "訂單狀態編號, ";
            sql += "優惠券ID, ";
            sql += "總金額, ";
            sql += "備註, ";
            sql += "評論星級, ";
            sql += "評論內容, ";
            sql += "評論日期, ";
            sql += "評論狀態";
            sql += ")VALUES(";
            sql += "@f會員ID, ";
            sql += "@f行程批次編號, ";
            sql += "@f數量, ";
            sql += "@下單時間, ";
            sql += "@付款方式編號, ";
            sql += "@付款狀態編號, ";
            sql += "@付款時間, ";
            sql += "@訂單狀態編號, ";
            sql += "@優惠券ID, ";
            sql += "@總金額, ";
            sql += "@備註, ";
            sql += "@評論星級, ";
            sql += "@評論內容, ";
            sql += "@評論日期, ";
            sql += "@評論狀態)";


            return sql;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
