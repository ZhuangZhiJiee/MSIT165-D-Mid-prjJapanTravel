using slnJapanTravel.View.Ship;
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
    public partial class FrmShip : Form
    {
        public FrmShip()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            FrmShipRoute fs = new FrmShipRoute();
            fs.MdiParent = MdiParent;
            fs.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRoutePhoto_Click(object sender, EventArgs e)
        {
            FrmShipPhoto fs = new FrmShipPhoto();
            fs.MdiParent = MdiParent;
            fs.Show();
        }
    }
}
