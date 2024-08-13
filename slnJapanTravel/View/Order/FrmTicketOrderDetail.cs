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

namespace slnJapanTravel.View.Order
{
    public partial class FrmTicketOrderDetail : Form
    {
        private C航班訂單Detail _detail;
        private C航班訂單資料 _order;

        public C航班訂單Detail Detail { get; set; }
        public C航班訂單資料 order
        {
            get
            {
                if (_order == null)
                    _order = new C航班訂單資料();
                _order.會員ID = Convert.ToInt32(lblMemberName.Text);

                return _order;
            }
            set
            {
                _order = value;
                lblMemberName.Text = _order.會員ID.ToString();
            }
        }

        public FrmTicketOrderDetail()
        {
            InitializeComponent();
        }
    }
}
