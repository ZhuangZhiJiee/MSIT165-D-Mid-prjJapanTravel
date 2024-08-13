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
                dr["評論星級"] = DBNull.Value;
                dr["評論內容"] = DBNull.Value;
                dr["評論日期"] = DBNull.Value;
                dr["評論狀態"] = f.ticket.評論狀態;
                dt.Rows.Add(dr);
            }
        }

        private void FrmTicketOrder_Load(object sender, EventArgs e)
        {
            //displayBySql("SELECT * FROM 航班訂單資料" +
            //    " JOIN 航班訂單Detail" +
            //    " ON 航班訂單資料.航班訂單編號 = 航班訂單Detail.航班訂單編號");

            displayBySql("SELECT * FROM 航班訂單資料");
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
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];

            SqlConnection con = new SqlConnection();
            con.ConnectionString = _s;
            con.Open();

            MessageBox.Show((dt.Rows[_position][0].ToString()));
            //dr.Delete();
            //_adapter.Update(dataGridView1.DataSource as DataTable);
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
            displayBySql("SELECT * FROM 航班訂單資料");
        }

        //private C航班訂單Detail queryByOrderId(int 航班訂單編號)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = _s;
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = "SELECT * FROM 航班訂單Detail WHERE 航班訂單編號=" + 航班訂單編號;
        //    SqlDataReader reader = cmd.ExecuteReader();
        //    if (!reader.Read())
        //    {
        //        con.Close();
        //        return null;
        //    }
        //    C航班訂單Detail c = new C航班訂單Detail();
        //    c.航班訂單Detail編號 = Convert.ToInt32(reader["航班訂單Detail編號"]);
        //    c.航班訂單編號 = Convert.ToInt32(reader["航班訂單編號"]);
        //    c.ScheduleID航班編號 = Convert.ToInt32(reader["ScheduleID航班編號"]);
        //    c.數量 = Convert.ToInt32(reader["數量"]);
        //    con.Close();
        //    return c;
        //}

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //DataTable dt = dataGridView1.DataSource as DataTable;
            //DataRow dr = dt.Rows[_position];

            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = _s;
            //con.Open();

            //int 航班訂單編號 = Convert.ToInt32(dt.Rows[_position][0]);
            FrmTicketOrderDetail f = new FrmTicketOrderDetail();
            //f.order = queryByOrderId(航班訂單編號);
            f.ShowDialog();

        }


    }
}
