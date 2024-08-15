using slnJapanTravel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace slnJapanTravel.View
{
    public partial class FrmOrderItineraryEditor : Form
    {

        private System.Windows.Forms.ComboBox comboBoxStatus;

        private C行程訂單資料 _itineraryorder;
        private DialogResult _isOk;
        public DialogResult isOk
        {
            get { return _isOk; }
        }
        public FrmOrderItineraryEditor()
        {
            InitializeComponent();
        }

        public C行程訂單資料 itineraryorder
        {
            get
            {
                if (_itineraryorder == null)
                    _itineraryorder = new C行程訂單資料();
                _itineraryorder.會員ID = Convert.ToInt32(fbMemberId.fieldValue);
                _itineraryorder.行程批次編號 = Convert.ToInt32(cbItineraryId.SelectedValue);
                _itineraryorder.數量 = Convert.ToInt32(fbQuantity.fieldValue);
                _itineraryorder.下單時間 = DateTime.Now;
                _itineraryorder.付款方式編號 = Convert.ToInt32(cbPaymentMethodId.SelectedValue);
                _itineraryorder.付款狀態編號 = Convert.ToInt32(cbPaymentStatusId.SelectedValue);
                _itineraryorder.付款時間 = DateTime.Now;
                _itineraryorder.訂單狀態編號 = Convert.ToInt32(cbOrderStatusId.SelectedValue);
                //if(isNumber(fbCouponId.fieldValue))
                //    _itineraryorder.優惠券ID = Convert.ToInt32(fbCouponId.fieldValue);
                _itineraryorder.總金額 = Convert.ToDecimal(fbAmount.fieldValue);
                _itineraryorder.備註 = fbRemark.fieldValue;
                //_itineraryorder.評論星級 = Convert.ToInt32(fbCommentStar.fieldValue);
                //_itineraryorder.評論內容 = fbCommentContent.fieldValue;
                //_itineraryorder.評論日期 = Convert.ToDateTime(fbCommentDate.fieldValue);
                //_itineraryorder.評論狀態 = true;

                return _itineraryorder;

            }

            set
            {
                _itineraryorder = value;
                fbMemberId.fieldValue = Convert.ToString(_itineraryorder.會員ID);
                cbItineraryId.SelectedValue = Convert.ToString(_itineraryorder.行程批次編號);
                fbQuantity.fieldValue = Convert.ToString(_itineraryorder.數量);
                cbPaymentMethodId.SelectedValue = Convert.ToString(_itineraryorder.付款方式編號);
                cbPaymentStatusId.SelectedValue = Convert.ToString(_itineraryorder.付款狀態編號);
                //fbPaymentTime.fieldValue = Convert.ToString(_itineraryorder.付款時間);
                //fbCouponId.fieldValue = Convert.ToString(_itineraryorder.優惠券ID);
                fbAmount.fieldValue = Convert.ToString(_itineraryorder.總金額);
                fbRemark.fieldValue = Convert.ToString(_itineraryorder.備註);
                //fbCommentStar.fieldValue = Convert.ToString(_itineraryorder.評論星級);
                //fbCommentContent.fieldValue = Convert.ToString(_itineraryorder.評論內容);
                //fbCommentDate.fieldValue = Convert.ToString(_itineraryorder.評論日期);
                //fbCommentStatus.fieldValue = Convert.ToString(_itineraryorder.評論狀態);
            }
        }

        private bool isNumber(string p)
        {
            try
            {
                double d = Convert.ToDouble(p);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (!isNumber(fbMemberId.fieldValue))
                errMsg += "請輸入會員編號";
            if (cbItineraryId.SelectedValue==null)
                errMsg += "\r請選擇行程批次編號";
            if (!isNumber(fbQuantity.fieldValue))
                errMsg += "\r請輸入數量";
            if (cbPaymentMethodId.SelectedValue==null)
                errMsg += "\r請選擇付款方式";
            if (!isNumber(fbAmount.fieldValue))
                errMsg += "\r請輸入總金額";



            if (!string.IsNullOrEmpty(errMsg))
            {
                MessageBox.Show(errMsg);
                return;
            }


            _isOk = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string btnText
        { 
            get { return btnOk.Text; }
            set { btnOk.Text = value; }
        }

        private void FrmOrderItineraryEditor_Load(object sender, EventArgs e)
        {



            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet4.ItineraryTime行程批次' 資料表。您可以視需要進行移動或移除。
            this.itineraryTime行程批次TableAdapter.Fill(this.japanTravelDataSet4.ItineraryTime行程批次);
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet3.訂單狀態' 資料表。您可以視需要進行移動或移除。
            this.訂單狀態TableAdapter.Fill(this.japanTravelDataSet3.訂單狀態);
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet3.付款狀態' 資料表。您可以視需要進行移動或移除。
            this.付款狀態TableAdapter.Fill(this.japanTravelDataSet3.付款狀態);
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet3.付款方式' 資料表。您可以視需要進行移動或移除。
            this.付款方式TableAdapter.Fill(this.japanTravelDataSet3.付款方式);

        }
    }
}
