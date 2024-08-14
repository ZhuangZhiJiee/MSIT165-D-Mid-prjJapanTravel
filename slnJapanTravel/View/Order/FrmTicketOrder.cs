using slnJapanTravel.Model;
using slnJapanTravel.View.Order;
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

namespace slnJapanTravel.View
{
    public partial class FrmTicketOrder : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private int _position;
        List<int> _list = null;
        public FrmTicketOrder()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmTicketOrderEditor f = new FrmTicketOrderEditor();
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["會員ID"] = f.ticket.會員ID;
                dr["下單時間"] = f.ticket.下單時間;
                dr["付款方式編號"] = f.ticket.付款方式編號;
                dr["付款狀態編號"] = f.ticket.付款狀態編號;
                if (f.ticket.優惠券ID == 0)
                {
                    dr["優惠券ID"] = DBNull.Value;
                }
                else
                {
                    dr["優惠券ID"] = f.ticket.優惠券ID;
                }
                dr["總金額"] = f.ticket.總金額;
                dr["備註"] = f.ticket.備註;
                //dr["評論星級"] = DBNull.Value;
                //dr["評論內容"] = DBNull.Value;
                //dr["評論日期"] = DBNull.Value;
                dr["評論狀態"] = f.ticket.評論狀態;
                dt.Rows.Add(dr);
            }
        }

        private void FrmTicketOrder_Load(object sender, EventArgs e)
        {
            //displayBySql("SELECT 航班訂單編號, mem.會員名稱, 下單時間, p.付款方式, n.訂單狀態, 優惠券ID, 總金額, 備註, 評論狀態 from 航班訂單資料 m " +
            //    "JOIN 付款方式 p " +
            //    "ON m.付款方式編號 = p.付款方式編號 " +
            //    "LEFT JOIN 訂單狀態 n " +
            //    "ON m.訂單狀態編號 = n.訂單狀態編號 " +
            //    "JOIN Member會員 mem " +
            //    "ON m.會員ID = mem.會員ID");
            displayBySql("SELECT 航班訂單編號, 會員ID, 下單時間, 付款方式編號, " +
                "付款狀態編號, 優惠券ID, 總金額, 備註, 評論狀態 FROM 航班訂單資料");

        }

        private void displayBySql(string sql)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            _adapter = new SqlDataAdapter(sql, con);
            _builder = new SqlCommandBuilder(_adapter);

            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select count(*) from 航班訂單Detail where 航班訂單編號 =" + dr[0].ToString();
            //SqlDataReader reader = cmd.ExecuteReader();

            int count = (int)cmd.ExecuteScalar();

            if (count == 0)
            { 
                dr.Delete();
                _adapter.Update(dataGridView1.DataSource as DataTable);
            }
            else
            {
                MessageBox.Show("請先刪除此筆訂單的明細");
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM 航班訂單資料 WHERE 航班訂單編號 LIKE " +
                "'%" + txtKeyword.Text + "%'" +
                "OR 會員Id LIKE '%" + txtKeyword.Text + "%'");
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "查詢訂單編號 or 會員Id")
                txtKeyword.Clear();
        }

        private void FrmTicketOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);
            displayBySql("SELECT 航班訂單編號, 會員ID, 下單時間, 付款方式編號, " +
                "付款狀態編號, 優惠券ID, 總金額, 備註, 評論狀態 FROM 航班訂單資料");
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmTicketDetail f = new FrmTicketDetail();
            f.ShowDialog();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            C航班訂單資料 i = new C航班訂單資料();

            i.會員ID = (int)dr["會員ID"];
            i.下單時間 = (DateTime)dr["下單時間"];
            i.付款方式編號 = (int)dr["付款方式編號"];
            i.付款狀態編號 = (int)dr["付款狀態編號"];
            //if(dr["訂單狀態編號"] != DBNull.Value)
            //    i.訂單狀態編號 = (int)dr["訂單狀態編號"];
            if (dr["優惠券ID"] != DBNull.Value)
                i.優惠券ID = (int)dr["優惠券ID"];
            i.總金額 = (decimal)dr["總金額"];
            i.備註 = dr["備註"].ToString();
            //if(dr["評論星級"] != DBNull.Value)
            //    i.評論星級 = (int)dr["評論星級"];
            //i.評論內容 = dr["評論內容"].ToString();
            //if(dr["評論日期"] != DBNull.Value)
            //    i.評論日期 = (DateTime)dr["評論日期"];
            //i.評論狀態 = (Boolean)dr["評論狀態"];

            FrmTicketOrderEditor f = new FrmTicketOrderEditor();
            f.ticket = i;
            f.btnText = "確定修改";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr["會員ID"] = f.ticket.會員ID;
                dr["下單時間"] = f.ticket.下單時間;
                dr["付款方式編號"] = f.ticket.付款方式編號;
                dr["付款狀態編號"] = f.ticket.付款狀態編號;
                if (f.ticket.優惠券ID == 0)
                {
                    dr["優惠券ID"] = DBNull.Value;
                }
                else
                {
                    dr["優惠券ID"] = f.ticket.優惠券ID;
                }
                dr["總金額"] = f.ticket.總金額;
                dr["備註"] = f.ticket.備註;
                //dr["評論星級"] = DBNull.Value;
                //dr["評論內容"] = DBNull.Value;
                //dr["評論日期"] = DBNull.Value;
                //dr["評論狀態"] = f.itineraryorder.評論狀態;

            }
        }
    }
}
