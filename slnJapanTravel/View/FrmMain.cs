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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tsAdmin_Click(object sender, EventArgs e)
        {

            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmAdmin fa = new FrmAdmin();
            fa.MdiParent = this;
            fa.Show();
        }

        private void tsbMember_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmMember fm = new FrmMember();
            fm.MdiParent = this;
            fm.Show();
        }

        private void tsbLtinerary_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItinerary fi = new FrmItinerary();
            fi.MdiParent = this;
            fi.Show();
        }

        private void tsbShip_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmShip fs = new FrmShip();
            fs.MdiParent = this;
            fs.Show();
        }

        private void tsbOrder_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmOrder fo = new FrmOrder();
            fo.MdiParent = this;
            fo.Show();
        }

        private void tsbBlog_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmBlog fb = new FrmBlog();
            fb.MdiParent = this;
            fb.Show();
        }
    }
}
