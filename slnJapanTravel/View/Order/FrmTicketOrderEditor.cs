using slnJapanTravel.Model;
using slnJapanTravel.Model.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmTicketOrderEditor : Form
    {
        string _s = "Data Source=192.168.35.188,1433;Initial Catalog=JapanTravel;User ID=Luke;Password=0000;Encrypt=False";  //SQL ConnectionString
        //string _s = "Data Source=.;Initial Catalog=JapanTravel;Integrated Security=True;Encrypt=False";                                                                                                                     //string _s = "Data Source=(localdb)\\ProjectModels;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";  //本機ConnectionString

        private C航班訂單資料 _ticket = null;
        private C航班訂單Detail _ticketDetail = null;
        private CMember _member = null;
        private DialogResult _isOk;
        public DialogResult isOk
        {
            get { return _isOk; }
        }

        public CMember member
        {
            get
            {
                if (_member == null)
                    _member = new CMember();
                _member.會員名稱 = member.會員名稱;

                return _member;
            }
        }
        public C航班訂單資料 ticket
        {
            get
            {
                if (_ticket == null)
                    _ticket = new C航班訂單資料();
                _ticket.會員ID = Convert.ToInt32(fbMemberId.fieldValue);
                _ticket.下單時間 = DateTime.Now;
                _ticket.付款方式編號 = Convert.ToInt32(fbPaymentMethodId.fieldValue);
                _ticket.付款狀態編號 = 1;
                _ticket.付款時間 = DateTime.Now;
                _ticket.訂單狀態編號 = 1;
                if (isNumber(fbCouponId.fieldValue))
                    _ticket.優惠券ID = Convert.ToInt32(fbCouponId.fieldValue);
                _ticket.總金額 = Convert.ToDecimal(fbAmount.fieldValue);
                _ticket.備註 = fbRemark.fieldValue;
                //_ticket.評論星級 = Convert.ToInt32(fbCommentStar.fieldValue);
                //_ticket.評論內容 = fbCommentContent.fieldValue;
                //_ticket.評論日期 = Convert.ToDateTime(fbCommentDate.fieldValue);
                _ticket.評論狀態 = true;

                return _ticket;
            }
            set
            {
                _ticket = value;
                fbMemberId.fieldValue = Convert.ToString(_ticket.會員ID);
                fbPaymentMethodId.fieldValue = Convert.ToString(_ticket.付款方式編號);
                fbPaymentStatusId.fieldValue = Convert.ToString(_ticket.付款狀態編號);
                fbPaymentTime.fieldValue = Convert.ToString(_ticket.付款時間);
                fbCouponId.fieldValue = Convert.ToString(_ticket.優惠券ID);
                fbAmount.fieldValue = Convert.ToString(_ticket.總金額);
                fbRemark.fieldValue = Convert.ToString(_ticket.備註);
                //fbCommentStar.fieldValue = Convert.ToString(_itineraryorder.評論星級);
                //fbCommentContent.fieldValue = Convert.ToString(_itineraryorder.評論內容);
                //fbCommentDate.fieldValue = Convert.ToString(_itineraryorder.評論日期);
                //fbCommentStatus.fieldValue = Convert.ToString(_itineraryorder.評論狀態);
            }
        }

        public FrmTicketOrderEditor()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string errMsg = "";
            if (!isNumber(fbMemberId.fieldValue))
                errMsg += "請輸入會員編號";
            if (!isNumber(fbPaymentMethodId.fieldValue))
                errMsg += "\r請輸入付款方式編號";
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string btnText
        {
            get { return btnOk.Text; }
            set { btnOk.Text = value; }
        }

    }
}
