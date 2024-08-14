using slnJapanTravel.View.Blog;
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
    public partial class FrmBlog : Form
    {
        public FrmBlog()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Frmhashtag h=new Frmhashtag();
            //h.MdiParent = this;
            h.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frmarticlelist a = new Frmarticlelist();
            //h.MdiParent = this;
            a.Show();
        }
    }
}
