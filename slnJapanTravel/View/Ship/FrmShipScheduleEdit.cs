using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                _Schedule.DepartureTime出發時間= DateTime.Parse(tbDepTime.Text); ;
                _Schedule.ArrivalTime到達時間= DateTime.Parse(tbArrTime.Text);
                _Schedule.Seats總座位數 = Convert.ToInt32(tbSeat.Text);
                _Schedule.Capacity售出座位數= Convert.ToInt32(tbCapacity.Text);
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
        public FrmShipScheduleEdit()
        {
            InitializeComponent();
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
    }
}
