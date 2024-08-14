using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace slnJapanTravel.View
{
   
    public partial class FrmShipRoute : Form
    {
        string CS =
            //本機
            "Data Source =.; Initial Catalog = JapanTravel; Integrated Security = True; Encrypt = False";
            //連線
            //"Data Source = 192.168.35.188; Initial Catalog = JapanTravel;Persist Security Info = True; User ID = jojo; Password = 0000; Encrypt = False;";
        
        
            
        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;
        public FrmShipRoute()
        {
            InitializeComponent();
        }

        private void FrmShip_Resize(object sender, EventArgs e)
        {
            txtKeyword.Width = this.Width * 230 / 816;

        }
        private void FrmShip_Load(object sender, EventArgs e)
        {
            displaysql(@"SELECT r.RouteID渡輪航線ID AS 渡輪航線, o.PortName港口名稱 AS 出發港, d.PortName港口名稱 AS 目的地, r.RouteDescription航線敘述 AS 航線敘述
                FROM 渡輪航線 r
                JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
                JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID");

        }

        public void displaysql(string sql)
        {
            SqlConnection con = new SqlConnection(CS);
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

       

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmShipRouteEdit f = new FrmShipRouteEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增航線作業";
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;
                DataRow dr = dt.NewRow();
                dr["渡輪航線"] = f.Route.RouteID渡輪航線ID;
                dr["出發港"] = f.Route.OriginPortID出發港ID;
                dr["目的地"] = f.Route.DestinationPortID目的地ID;
                dr["航線敘述"] = f.Route.RouteDescription航線敘述;

                dt.Rows.Add(dr);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmShipRoute_Paint(object sender, PaintEventArgs e)
        {
            resetGridStyle();
            //displaysql(@"SELECT r.RouteID渡輪航線ID AS 渡輪航線, o.PortName港口名稱 AS 出發港, d.PortName港口名稱 AS 目的地, r.RouteDescription航線敘述 AS 航線敘述
            //    FROM 渡輪航線 r
            //    JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
            //    JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID");
        }

        private void resetGridStyle()
        {
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 2000;
            dataGridView1.Columns[3].Width = this.Width - 100 - 100 - 100 - 50;

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

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM 渡輪航線";
            sql += " WHERE RouteDescription航線敘述 LIKE @K_KEYWORD";

            displaysql(sql);
        }

        private void FrmShipRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();

                // 手動配置 UpdateCommand
                _adapter.UpdateCommand = new SqlCommand(
                    @"UPDATE 渡輪航線 
              SET OriginPortID出發港ID = @OriginPortID, 
                  DestinationPortID目的地ID = @DestinationPortID, 
                  RouteDescription航線敘述 = @RouteDescription
              WHERE RouteID渡輪航線ID = @RouteID", con);

                // 添加參數
                _adapter.UpdateCommand.Parameters.Add("@OriginPortID", SqlDbType.Int, 4, "出發港");
                _adapter.UpdateCommand.Parameters.Add("@DestinationPortID", SqlDbType.Int, 4, "目的地");
                _adapter.UpdateCommand.Parameters.Add("@RouteDescription", SqlDbType.NVarChar, 255, "航線敘述");
                _adapter.UpdateCommand.Parameters.Add("@RouteID", SqlDbType.Int, 4, "渡輪航線");

                // 更新資料
                try
                {
                    _adapter.Update(dataGridView1.DataSource as DataTable);
                    MessageBox.Show("資料已成功更新至資料庫。");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新資料時發生錯誤：" + ex.Message);
                }
            }
            //_adapter.Update(dataGridView1.DataSource as DataTable);
            Refresh();
        }
    }
}
