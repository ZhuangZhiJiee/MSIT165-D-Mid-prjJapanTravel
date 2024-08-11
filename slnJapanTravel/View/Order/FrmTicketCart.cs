using slnJapanTravel.Model;
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

namespace slnJapanTravel.View
{
    public partial class FrmTicketCart : Form
    {
        private void displayTicketBySql(string sql)
        {

        }
        public FrmTicketCart()
        {
            InitializeComponent();
        }

        private void cbPaymentMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            C付款方式 c = new C付款方式();
            cbPaymentMethods.Items.Add(c.付款方式);
        }
    }
}
