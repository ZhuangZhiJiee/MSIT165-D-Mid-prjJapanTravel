using slnJapanTravel.Model;
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

namespace slnJapanTravel.View.Order
{
    public partial class FrmTicketDetail : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";  //本機ConnectionString
        private SqlDataAdapter _adapter;
        private SqlCommandBuilder _builder;
        private int _position;
        List<int> _list = null;

        private C航班訂單Detail _detail;
        private C航班訂單資料 _order;

        public C航班訂單Detail Detail { get; set; }
        public C航班訂單資料 order
        {
            get
            {
                if (_order == null)
                    _order = new C航班訂單資料();
                _order.會員ID = Convert.ToInt32(lblMemberName.Text);

                return _order;
            }
            set
            {
                _order = value;
                lblMemberName.Text = _order.會員ID.ToString();
            }
        }


        public FrmTicketDetail()
        {
            InitializeComponent();
        }

        private void FrmTicketDetail_Load(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM 航班訂單Detail");
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
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "請輸入航班訂單編號")
                txtKeyword.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            displayBySql("SELECT * FROM 航班訂單Detail WHERE 航班訂單編號 LIKE "
                + "'%" + txtKeyword.Text + "%'");
        }

        private void txtKeyword_Click_1(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "請輸入航班訂單編號")
                txtKeyword.Clear();
        }
    }
}
