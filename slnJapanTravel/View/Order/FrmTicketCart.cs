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


        private void FrmTicketCart_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet.付款方式' 資料表。您可以視需要進行移動或移除。
            this.付款方式TableAdapter.Fill(this.japanTravelDataSet.付款方式);
            // TODO: 這行程式碼會將資料載入 'japanTravelDataSet.Port港口' 資料表。您可以視需要進行移動或移除。
            this.port港口TableAdapter.Fill(this.japanTravelDataSet.Port港口);
            this.cbStarting.SelectedIndex = -1;
            this.cbDestination.SelectedIndex = -1;


        }

        private void txtKeyword_Click(object sender, EventArgs e)
        {
            if (txtKeyword.Text == "關鍵字")
                txtKeyword.Clear();
        }
    }
}
