using slnJapanTravel.Model;
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
                _cRoute.DestinationPortID目的地ID = Convert.ToInt32(cbOri.SelectedValue);
                _cRoute.OriginPortID出發港ID = Convert.ToInt32(cbDest.SelectedValue);
                _cRoute.RouteDescription航線敘述 = tbDesc.Text;
                return _cRoute;
            }
            set
            {
                _cRoute = value;
                tbID.Text = _cRoute.RouteID渡輪航線ID.ToString();
                cbOri.SelectedValue = _cRoute.OriginPortID出發港ID.ToString();
                cbDest.SelectedValue = _cRoute.DestinationPortID目的地ID.ToString();
                tbDesc.Text = _cRoute.RouteDescription航線敘述;
                
            }
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
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet1.Port港口' 資料表。您可以視需要進行移動或移除。
            this.port港口TableAdapter1.Fill(this.japanTravelDataSet1.Port港口);
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet.Port港口' 資料表。您可以視需要進行移動或移除。
            this.port港口TableAdapter.Fill(this.japanTravelDataSet.Port港口);
            string CS =
        //本機
        //"Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";
        //連線
        "Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";

            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT PortID港口ID, PortName港口名稱 FROM port港口", con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbOri.DataSource = dt;
                cbOri.DisplayMember = "PortName港口名稱";
                cbOri.ValueMember = "PortID港口ID";

                cbDest.DataSource = dt.Copy(); // 避免DataSource共享
                cbDest.DisplayMember = "PortName港口名稱";
                cbDest.ValueMember = "PortID港口ID";
            }
        }
    }
}
