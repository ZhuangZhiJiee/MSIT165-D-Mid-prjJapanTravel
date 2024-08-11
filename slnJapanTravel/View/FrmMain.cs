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


        private void tsbBlog_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmBlog fb = new FrmBlog();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 船票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketCart fb = new FrmTicketCart();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 行程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryCart fb = new FrmItineraryCart();
            fb.MdiParent = this;
            fb.Show();

        }

        private void 行程ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmItineraryOrder fb = new FrmItineraryOrder();
            fb.MdiParent = this;
            fb.Show();
        }

        private void 船票ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            while (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Close();

            FrmTicketOrder fb = new FrmTicketOrder();
            fb.MdiParent = this;
            fb.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
