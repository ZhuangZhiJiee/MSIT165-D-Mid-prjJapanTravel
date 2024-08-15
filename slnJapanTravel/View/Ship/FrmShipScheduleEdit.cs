using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
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
    public partial class FrmShipScheduleEdit : Form
    {
        public System.Drawing.Image titleIcon
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
        public string title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public DialogResult isOk { get; set; }
        public CSchedule _Schedule = null;
        public CSchedule Schedule
        {
            get
            {
                if (_Schedule == null)
                    _Schedule = new CSchedule();
                _Schedule.RouteID渡輪航線ID = Convert.ToInt32(tbRouteID.Text);
                _Schedule.DepartureTime出發時間 = DateTime.Parse(tbDepTime.Text);
                _Schedule.ArrivalTime到達時間 = DateTime.Parse(tbArrTime.Text);
                _Schedule.Seats總座位數 = Convert.ToInt32(tbSeat.Text);
                _Schedule.Capacity售出座位數 = Convert.ToInt32(tbCapacity.Text);
                return _Schedule;
            }
            set
            {
                _Schedule = value;
                tbScheduleID.Text = _Schedule.ScheduleID渡輪航班ID.ToString();
                tbRouteID.Text = _Schedule.RouteID渡輪航線ID.ToString();
                tbDepTime.Text = _Schedule.DepartureTime出發時間.ToString();
                tbArrTime.Text = _Schedule.ArrivalTime到達時間.ToString();
                tbSeat.Text = _Schedule.Seats總座位數.ToString();
                tbCapacity.Text = _Schedule.Capacity售出座位數.ToString();
            }
        }

        public FrmShipScheduleEdit(CSchedule schedule = null)
        {
            InitializeComponent();
            tbScheduleID.ReadOnly = true;

            if (schedule != null)
            {
                _Schedule = schedule;
                tbRouteID.Text = _Schedule.RouteID渡輪航線ID.ToString();
                tbDepTime.Text = _Schedule.DepartureTime出發時間.ToString();
                tbArrTime.Text = _Schedule.ArrivalTime到達時間.ToString();
                tbSeat.Text = _Schedule.Seats總座位數.ToString();
                tbCapacity.Text = _Schedule.Capacity售出座位數.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string errMsg = "";

            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }
            this.isOk = DialogResult.OK;
            Close();
        }

        private void FrmShipScheduleEdit_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbScheduleID.Text))
            {
                // 獲取新 ScheduleID 並設置到 tbScheduleID
                int newID = GenerateNewScheduleID();
                if (newID > 0)
                {
                    tbScheduleID.Text = newID.ToString();
                }
                else
                {
                    // 處理錯誤情況，例如顯示錯誤訊息或禁用功能
                    MessageBox.Show("無法生成新的 ScheduleID。");
                    tbScheduleID.Text = "Error";
                }
            }
            if (string.IsNullOrEmpty(tbDepTime.Text) && string.IsNullOrEmpty(tbArrTime.Text))
            {
                SetDefaultDates();
            }
        }

        private void SetDefaultDates()
        {
            tbDepTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // 設置 tbArrTime 為當前時間 + 1 天
            tbArrTime.Text = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss");
        }

        private int GenerateNewScheduleID()
        {
            string query = "SELECT ISNULL(MAX(ScheduleID渡輪航班ID), 0) FROM 渡輪航班";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                try
                {
                    con.Open();
                    // 執行查詢並獲取最大 ID
                    object result = cmd.ExecuteScalar();
                    int maxID = Convert.ToInt32(result);

                    // 返回新的 ID
                    return maxID + 1;
                }
                catch (Exception ex)
                {
                    // 處理異常情況
                    MessageBox.Show($"Error generating new ScheduleID: {ex.Message}");
                    return -1; // 返回一個無效的 ID 以表示錯誤
                }
            }
        }
    }
}
    