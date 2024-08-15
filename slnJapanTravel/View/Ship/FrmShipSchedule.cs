using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipSchedule : Form
    {
        

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
            SqlConnection con = new SqlConnection(DbConfig.GetConnectionString());
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

                // 檢查 DataTable 是否為 null
                if (dt == null)
                {
                    MessageBox.Show("無法取得資料表格。");
                    return;
                }

                DataRow dr = dt.NewRow();
                dr["ScheduleID渡輪航班ID"] = f.Schedule.ScheduleID渡輪航班ID;
                dr["RouteID渡輪航線ID"] = f.Schedule.RouteID渡輪航線ID;
                dr["DepartureTime出發時間"] = f.Schedule.DepartureTime出發時間;
                dr["ArrivalTime到達時間"] = f.Schedule.ArrivalTime到達時間;
                dr["Seats總座位數"] = f.Schedule.Seats總座位數;
                dr["Capacity售出座位數"] = f.Schedule.Capacity售出座位數;

                dt.Rows.Add(dr);

                // 將更改提交到資料庫
                try
                {
                    _adapter.Update(dt);
                    displaysql(@"SELECT * FROM 渡輪航班"); // 重新加載資料
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"新增資料時出錯: {ex.Message}");
                }
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CSchedule m = new CSchedule();
            m.DepartureTime出發時間 = (DateTime)dr["DepartureTime出發時間"];
            m.ArrivalTime到達時間 = (DateTime)dr["ArrivalTime到達時間"];
            m.Seats總座位數 = (int)dr["Seats總座位數"];
            m.Capacity售出座位數 = (int)dr["Capacity售出座位數"];
            if (dr["ScheduleID渡輪航班ID"] != DBNull.Value)
                m.ScheduleID渡輪航班ID = (int)dr["ScheduleID渡輪航班ID"];
            m.RouteID渡輪航線ID = (int)dr["RouteID渡輪航線ID"];

            FrmShipScheduleEdit f = new FrmShipScheduleEdit();
            f.titleIcon = btnEdit.Image;
            f.title = "編輯航班資料";
            f.Schedule = m;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr["ScheduleID渡輪航班ID"] = f.Schedule.ScheduleID渡輪航班ID;
                dr["RouteID渡輪航線ID"] = f.Schedule.RouteID渡輪航線ID;
                dr["DepartureTime出發時間"] = f.Schedule.DepartureTime出發時間;
                dr["ArrivalTime到達時間"] = f.Schedule.ArrivalTime到達時間;
                dr["Seats總座位數"] = f.Schedule.Seats總座位數;
                dr["Capacity售出座位數"] = f.Schedule.Capacity售出座位數;

                // 更新 DataTable 並提交到資料庫
                _adapter.Update(dt);
                dt.AcceptChanges();  // 確保 DataTable 狀態更新
            }
        }



        private void btnCopy_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CSchedule m = new CSchedule();
            m.DepartureTime出發時間 = (DateTime)dr["DepartureTime出發時間"];
            m.ArrivalTime到達時間 = (DateTime)dr["ArrivalTime到達時間"];
            m.Seats總座位數 = (int)dr["Seats總座位數"];
            m.Capacity售出座位數 = (int)dr["Capacity售出座位數"];
            m.RouteID渡輪航線ID = (int)dr["RouteID渡輪航線ID"];

            FrmShipScheduleEdit f = new FrmShipScheduleEdit(m);
            f.titleIcon = btnCopy.Image;
            f.title = "複製航班資料";
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                DataRow newDr = dt.NewRow();
                newDr["ScheduleID渡輪航班ID"] = f.Schedule.ScheduleID渡輪航班ID;
                newDr["RouteID渡輪航線ID"] = f.Schedule.RouteID渡輪航線ID;
                newDr["DepartureTime出發時間"] = f.Schedule.DepartureTime出發時間;
                newDr["ArrivalTime到達時間"] = f.Schedule.ArrivalTime到達時間;
                newDr["Seats總座位數"] = f.Schedule.Seats總座位數;
                newDr["Capacity售出座位數"] = f.Schedule.Capacity售出座位數;

                dt.Rows.Add(newDr);

                // 將更改提交到資料庫
                _adapter.Update(dt);
                displaysql(@"SELECT * FROM 渡輪航班");
            }
        }

    }
}
