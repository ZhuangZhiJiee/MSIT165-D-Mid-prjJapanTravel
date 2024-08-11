using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View
{
    public partial class FrmItineraryOrder : Form
    {
        public FrmItineraryOrder()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmOrderItineraryEditor f = new FrmOrderItineraryEditor();
            f.ShowDialog();
        }

        private void FrmItineraryOrder_Load(object sender, EventArgs e)
        {
            diplayBySql("SECLET * FORM 行程訂單資料");
        }

        private void diplayBySql(string v)
        {
            throw new NotImplementedException();
        }
    }
}
