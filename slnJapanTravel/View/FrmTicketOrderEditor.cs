using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmTicketOrderEditor : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
                                                                                                                             //string _s = "Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";  //本機ConnectionString

        private C航班訂單資料 _ticket = null;
        public DialogResult isOk {  get; set; }

        public C航班訂單資料 ticket
        {
            get
            {
                if (_ticket == null)
                    _ticket = new C航班訂單資料();
                _ticket.會員ID = Convert.ToInt32(fb會員ID.fieldValue);
                _ticket.下單時間 = DateTime.Now;
                _ticket.付款方式編號 = Convert.ToInt32(fb付款方式編號.fieldValue);
                _ticket.付款狀態編號 = Convert.ToInt32(fb付款狀態編號.fieldValue);
                _ticket.訂單狀態編號 = 1;
                _ticket.優惠券ID = Convert.ToInt32(fb優惠券ID.fieldValue);
                _ticket.總金額 = Convert.ToDecimal(fb總金額.fieldValue);
                _ticket.備註 = fb備註.fieldValue;
                return _ticket;
            }
            set
            {
                _ticket = value;
                fb會員ID.fieldValue = _ticket.會員ID.ToString();
                fb付款方式編號.fieldValue = _ticket.付款方式編號.ToString();
                fb付款狀態編號.fieldValue = _ticket.付款狀態編號.ToString();
                fb優惠券ID.fieldValue = _ticket.優惠券ID.ToString();
                fb備註.fieldValue = _ticket.備註.ToString();
            }
        }
        
        public FrmTicketOrderEditor()
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
            string sql = "INSERT INTO 航班訂單資料 (";
            sql += "會員ID, ";
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
