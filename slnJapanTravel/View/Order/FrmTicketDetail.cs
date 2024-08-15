using prjCustomerSystem;
using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
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
        private CImage _image;

        public C航班訂單Detail Detail
        {
            get
            {
                if (_detail == null)
                    _detail = new C航班訂單Detail();
                _detail.數量 = Convert.ToInt32(tbQuantity.Text);
                _detail.航班訂單編號 = Convert.ToInt32(tbTicketOrderId.Text);
                _detail.ScheduleID航班編號 = Convert.ToInt32(tbShipId.Text);
                return _detail;
            }
            set
            {
                _detail = value;
                tbQuantity.Text = _detail.數量.ToString();
                tbTicketOrderId.Text = _detail.航班訂單編號.ToString();
                tbShipId.Text = _detail.ScheduleID航班編號.ToString();
            }
        }
        //public C航班訂單資料 order
        //{
        //    get
        //    {
        //        if (_order == null)
        //            _order = new C航班訂單資料();
        //        _order.會員ID = Convert.ToInt32(lblMemberName.Text);

        //        return _order;
        //    }
        //    set
        //    {
        //        _order = value;
        //        lblMemberName.Text = _order.會員ID.ToString();
        //    }
        //}


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
            refresh();
        }

        private void txtKeyword_Click_1(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "請輸入航班訂單編號")
                txtKeyword.Clear();
        }

        private void btnAllClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            copyInfo();
        }


        private void copyInfo()
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            C航班訂單Detail ticketOrderDetail = new C航班訂單Detail();
            if (dr["航班訂單編號"] != DBNull.Value)
                ticketOrderDetail.航班訂單編號 = (int)dr["航班訂單編號"];
            if (dr["ScheduleID航班編號"] != DBNull.Value)
                ticketOrderDetail.ScheduleID航班編號 = (int)dr["ScheduleID航班編號"];
            if (dr["數量"] != DBNull.Value)
                ticketOrderDetail.數量 = (int)dr["數量"];

            this.tbShipId.Text = ticketOrderDetail.ScheduleID航班編號.ToString();
            this.tbQuantity.Text = ticketOrderDetail.數量.ToString();
            this.tbTicketOrderId.Text = ticketOrderDetail.航班訂單編號.ToString() ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DialogResult _isOk;
        public DialogResult isOk
        {
            get { return _isOk; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (!CNumberUtility.isNumber(tbTicketOrderId.Text))
                errMsg += "請輸入航班訂單編號";
            if (!CNumberUtility.isNumber(tbShipId.Text))
                errMsg += "\r請輸入航班編號";
            if (!CNumberUtility.isNumber(tbQuantity.Text))
                errMsg += "\r請輸入數量";
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }


            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.NewRow();
            dr["航班訂單編號"] = this.Detail.航班訂單編號;
            dr["ScheduleID航班編號"] = this.Detail.ScheduleID航班編號;
            dr["數量"] = this.Detail.數量;
            dt.Rows.Add(dr);
            _adapter.Update(dataGridView1.DataSource as DataTable);
            displayBySql("SELECT * FROM 航班訂單Detail");
            refresh();
        }

        private void FrmTicketDetail_Paint(object sender, PaintEventArgs e)
        {
            refresh();

        }

        private void refresh()
        {
            dataGridView1.Columns[0].Width = 0;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = this.Width - 200 - 200 - 465;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("微軟正黑體", 14);

            bool isColorChanged = false;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 40;
                r.HeaderCell.Value = count.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (!CNumberUtility.isNumber(tbTicketOrderId.Text))
                errMsg += "請輸入航班訂單編號";
            if (!CNumberUtility.isNumber(tbShipId.Text))
                errMsg += "\r請輸入航班編號";
            if (!CNumberUtility.isNumber(tbQuantity.Text))
                errMsg += "\r請輸入數量";
            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }


            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];

            dr["航班訂單編號"] = Convert.ToInt32(tbTicketOrderId.Text);
            dr["ScheduleID航班編號"] = Convert.ToInt32(tbShipId.Text);
            dr["數量"] = Convert.ToInt32(tbQuantity.Text);
            _adapter.Update(dataGridView1.DataSource as DataTable);
            displayBySql("SELECT * FROM 航班訂單Detail");
            refresh();

        }


        //public CImage shipimage
        //{
        //    get { return _image; }
        //    set { _image = value;
        //        if (_image != null) 
        //        {
        //            Stream streamImage = new MemoryStream(_image.Image圖片);
        //            picShipImage.Image = Bitmap.FromStream(streamImage);
        //        }

        //    }
        //}

        //private void displayShipBySql(string sql)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = _s;
        //    con.Open();
        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
        //    adapter.SelectCommand.Parameters.Add(
        //        new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds);
        //    con.Close();
        //    picShipImage.Controls.Clear();
        //    foreach(DataRow r in ds.Tables[0].Rows)
        //    {
        //        CImage i = new CImage();
        //        if (r["Image圖片"] != DBNull.Value)
        //            i.Image圖片 = (byte[])r["Image圖片"];

        //        picShipImage = i;

        //    }
        //}

    }
}
