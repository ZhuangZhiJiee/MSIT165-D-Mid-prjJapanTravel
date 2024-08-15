using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnJapanTravel.View.Ship
{
    public partial class FrmShipPhoto : Form
    {
      
        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;


        private void FrmShip_Resize(object sender, EventArgs e)
        {
            txtKeyword.Width = this.Width * 230 / 816;

        }
        public FrmShipPhoto()
        {
            InitializeComponent();
        }

        private void FrmShipPhoto_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT * FROM 渡輪圖片");
        }
        public void displaysql(string sql)
        {
            SqlConnection con = new SqlConnection(DbConfig.GetConnectionString());
            con.Open();
            _adapter = new SqlDataAdapter(sql, con);

            _builder = new SqlCommandBuilder(_adapter);
            _adapter.SelectCommand.Parameters.Add(
                new SqlParameter("K_KEYWORD", "%" + (object)txtKeyword.Text + "%"));

            DataSet ds = new DataSet();
            _adapter.Fill(ds);
            con.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int newImageID = GetNewImageID(); // 從資料庫獲取新 ImageID

            FrmShipPhotoEdit f = new FrmShipPhotoEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增航線圖片";
            f.image = new CImage { ImageID渡輪圖片ID = newImageID }; // 傳遞新ID
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["ImageID渡輪圖片ID"] = f.image.ImageID渡輪圖片ID;
                dr["Image圖片"] = f.image.Image圖片;
                dr["Description圖片描述"] = f.image.Description圖片描述;
                dr["RouteID渡輪航線ID"] = f.image.RouteID渡輪航線ID;
                dt.Rows.Add(dr);
            }
        }

        private int GetNewImageID()
        {
            int newImageID = 1; // 默認為1
            try
            {
                using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(ImageID渡輪圖片ID), 0) + 1 FROM 渡輪圖片", con);
                    newImageID = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("獲取新ImageID時發生錯誤: " + ex.Message);
            }
            return newImageID;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            dr.Delete();
            _adapter.Update(dataGridView1.DataSource as DataTable);
        }

        private void FrmShipPhoto_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (_adapter != null && dataGridView1.DataSource != null)
                {
                    _adapter.Update(dataGridView1.DataSource as DataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("關閉視窗時發生錯誤: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CImage m = new CImage();
            m.ImageID渡輪圖片ID = (int)dr["ImageID渡輪圖片ID"];
            m.RouteID渡輪航線ID = (int)dr["RouteID渡輪航線ID"];
            m.Description圖片描述 = dr["Description圖片描述"].ToString();
            if (dr["ImageID渡輪圖片ID"] != DBNull.Value)
                m.ImageID渡輪圖片ID = (int)dr["ImageID渡輪圖片ID"];
            m.RouteID渡輪航線ID = (int)dr["RouteID渡輪航線ID"];
            if (dr["Image圖片"] != DBNull.Value)
                m.Image圖片 = (byte[])dr["Image圖片"];

            FrmShipPhotoEdit f = new FrmShipPhotoEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "編輯航線圖片";
            f.image = m;
            f.ShowDialog();
            if (f.isOk == DialogResult.OK)
            {
                dr["ImageID渡輪圖片ID"] = f.image.ImageID渡輪圖片ID;
                dr["Image圖片"] = f.image.Image圖片;
                dr["Description圖片描述"] = f.image.Description圖片描述;
                dr["RouteID渡輪航線ID"] = f.image.RouteID渡輪航線ID;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            int newImageID = GetNewImageID(); // 獲取新的 ImageID

            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];
            CImage m = new CImage
            {
                ImageID渡輪圖片ID = newImageID, // 使用新ID
                RouteID渡輪航線ID = (int)dr["RouteID渡輪航線ID"],
                Description圖片描述 = dr["Description圖片描述"].ToString() + " (複製)",
                Image圖片 = (byte[])dr["Image圖片"]
            };

            FrmShipPhotoEdit f = new FrmShipPhotoEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "複製航線圖片";
            f.image = m;
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                dr = dt.NewRow();
                dr["ImageID渡輪圖片ID"] = f.image.ImageID渡輪圖片ID;
                dr["Image圖片"] = f.image.Image圖片;
                dr["Description圖片描述"] = f.image.Description圖片描述;
                dr["RouteID渡輪航線ID"] = f.image.RouteID渡輪航線ID;
                dt.Rows.Add(dr);
            }
        }

        private int GetMaxPortID()
        {
            int maxPortID = 0;
            string sql = "SELECT MAX(ImageID渡輪圖片ID) FROM 渡輪圖片";
            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    maxPortID = Convert.ToInt32(result);
                }
            }
            return maxPortID;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM 渡輪圖片";
            sql += " WHERE Description圖片描述 LIKE @K_KEYWORD";

            displaysql(sql);
        }

        private void FrmShipPhoto_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[0].HeaderText = "圖片編號";
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[1].HeaderText = "航線編號";
            dataGridView1.Columns[2].Width = 1600;
            dataGridView1.Columns[2].HeaderText = "圖片";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[3].HeaderText = "圖片敘述";
            dataGridView1.Columns[2].Width = this.Width - 100 - 100 - 100 - 50  ;
            bool isColorChanged = false;
            int count = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                count++;
                isColorChanged = !isColorChanged;
                r.DefaultCellStyle.BackColor = Color.White;
                if (isColorChanged)
                    r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                r.DefaultCellStyle.Font = new Font("微軟正黑體", 13);
                r.Height = 40;
                r.HeaderCell.Value = count.ToString();

            }
        }
    }
}
