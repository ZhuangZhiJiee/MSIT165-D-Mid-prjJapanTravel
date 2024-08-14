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

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipSchedule : Form
    {
        public string CS =
        //本機
        "Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";
        //連線
        //"Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";


        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;


        private void FrmShip_Resize(object sender, EventArgs e)
        {
            txtKeyword.Width = this.Width * 230 / 816;
        }

            public FrmShipSchedule()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;

        }

        private void FrmShipSchedule_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT * FROM 渡輪航班");

        }

        public void displaysql(string sql)
        {
            SqlConnection con = new SqlConnection(CS);
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

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
