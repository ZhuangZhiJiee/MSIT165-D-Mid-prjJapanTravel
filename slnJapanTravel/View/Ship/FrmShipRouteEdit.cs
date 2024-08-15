using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;


namespace slnJapanTravel.View
{
    public partial class FrmShipRouteEdit : Form
    {
        public CRoute _cRoute = null;
      
        public CRoute Route
        {
            get
            {
                if (_cRoute == null)
                    _cRoute = new CRoute();
                //_cRoute.RouteID渡輪航線ID = Convert.ToInt32(tbID.Text.ToString());
                //_cRoute.DestinationPortID目的地ID = Convert.ToInt32(cbOri.SelectedValue);
                //_cRoute.OriginPortID出發港ID = Convert.ToInt32(cbDest.SelectedValue);
                _cRoute.OriginPortID出發港ID = GetPortIDFromName(cbOri.Text);
                _cRoute.DestinationPortID目的地ID = GetPortIDFromName(cbDest.Text);
                _cRoute.RouteDescription航線敘述 = tbDesc.Text;
                return _cRoute;
            }
            set
            {
                _cRoute = value;
                //tbID.Text = _cRoute.RouteID渡輪航線ID.ToString();
                //cbOri.SelectedValue = _cRoute.OriginPortID出發港ID.ToString();
                //cbDest.SelectedValue = _cRoute.DestinationPortID目的地ID.ToString();
                //tbDesc.Text = _cRoute.RouteDescription航線敘述;
                cbOri.Text = GetPortNameFromID(_cRoute.OriginPortID出發港ID);
                cbDest.Text = GetPortNameFromID(_cRoute.DestinationPortID目的地ID);
                tbDesc.Text = _cRoute.RouteDescription航線敘述;
            }
        }

        private string GetPortNameFromID(int portID)
        {
            string portName = string.Empty;

            // 使用資料庫連接來查找對應的 PortName
            using (SqlConnection conn = new SqlConnection(DbConfig.GetConnectionString()))
            {
                string sql = "SELECT PortName港口名稱 FROM Port港口 WHERE PortID港口ID = @PortID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PortID", portID);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result != DBNull.Value)
                {
                    portName = result.ToString();
                }
            }

            return portName;
        }

        private int GetPortIDFromName(string portName)
        {
            int portID = -1;

            // 使用資料庫連接來查找對應的 PortID
            using (SqlConnection conn = new SqlConnection(DbConfig.GetConnectionString()))
            {
                string sql = "SELECT PortID港口ID FROM Port港口 WHERE PortName港口名稱 = @PortName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PortName", portName);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result != DBNull.Value)
                {
                    portID = Convert.ToInt32(result);
                }
            }

            return portID;
        }

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
        public FrmShipRouteEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (!CNumberUtility.isNumber(tbID.Text))           
            
            //    // 處理無效的輸入
            //    MessageBox.Show("無效的航線ID。請輸入一個有效的數字。");
            //return; // 或者採取其他措施，例如清空字段

            //string errMsg = "";
            //if (string.IsNullOrEmpty(tbDep.Text))
            //    errMsg += "\r\n出發港必須輸入";
            //if (string.IsNullOrEmpty(tbDest.Text))
            //    errMsg += "\r\n到達港必須輸入";
            //if (!CNumberUtility.isNumber(fbQty.fieldValue))
            //    errMsg += "\r\n庫存必須輸入數字";
            //if (!CNumberUtility.isNumber(fbCost.fieldValue))
            //    errMsg += "\r\n成本必須輸入數字";
            //if (!CNumberUtility.isNumber(fbPrice.fieldValue))
            //    errMsg += "\r\n價格必須輸入數字";
            //if (!string.IsNullOrEmpty(errMsg))
            //{
            //    MessageBox.Show(errMsg);
            //    return;
            //}
            this.isOk = DialogResult.OK;
            Close();
        }

        private void FrmShipREdit_Load(object sender, EventArgs e)
        {
            //// TODO: 這行程式碼會將資料載入 'japanTravelDataSet1.Port港口' 資料表。您可以視需要進行移動或移除。
            //this.port港口TableAdapter1.Fill(this.japanTravelDataSet1.Port港口);
            //// TODO: 這行程式碼會將資料載入 'japanTravelDataSet.Port港口' 資料表。您可以視需要進行移動或移除。
            //this.port港口TableAdapter.Fill(this.japanTravelDataSet.Port港口);
            DataTable portData = GetAllPortNames();

            cbOri.DataSource = portData.Copy(); // 避免資料來源共享
            cbOri.DisplayMember = "PortName港口名稱";
            cbOri.ValueMember = "PortID港口ID";

            cbDest.DataSource = portData.Copy(); // 避免資料來源共享
            cbDest.DisplayMember = "PortName港口名稱";
            cbDest.ValueMember = "PortID港口ID";

            // 根據 Route 設置 ComboBox 的選擇
            if (_cRoute != null)
            {
                cbOri.SelectedValue = _cRoute.OriginPortID出發港ID;
                cbDest.SelectedValue = _cRoute.DestinationPortID目的地ID;
            }

        }

        private DataTable GetAllPortNames()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT PortID港口ID, PortName港口名稱 FROM Port港口";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);
            }

            return dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbDesc.Text = "此航線為沖繩地區的交通船，往返石垣島及竹富島";
        }
    }
}
