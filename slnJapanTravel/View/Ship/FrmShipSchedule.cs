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
            FrmShipScheduleEdit f = new FrmShipScheduleEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增航班資料";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["ScheduleID渡輪航班ID"] = f.Schedule.ScheduleID渡輪航班ID;
                dr["RouteID渡輪航線ID"] = f.Schedule.RouteID渡輪航線ID;
                dr["DepartureTime出發時間"] = f.Schedule.DepartureTime出發時間;
                dr["ArrivalTime到達時間"] = f.Schedule.ArrivalTime到達時間;
                dr["Seats總座位數"] = f.Schedule.Seats總座位數;
                dr["Capacity售出座位數"] = f.Schedule.Capacity售出座位數;

                dt.Rows.Add(dr);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShipSchedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            _adapter.Update(dataGridView1.DataSource as DataTable);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);

        }
    }
}
