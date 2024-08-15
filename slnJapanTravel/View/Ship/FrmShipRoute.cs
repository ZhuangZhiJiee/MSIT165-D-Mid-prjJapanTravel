using slnJapanTravel.Model;
using slnJapanTravel.Model.Ship;
using System;
using System.Collections;
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
        
        private SqlDataAdapter _adapter;
        private int _position = -1;
        private SqlCommandBuilder _builder;
        //List<int> _list = null;

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



        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmShipRouteEdit f = new FrmShipRouteEdit();
            f.titleIcon = btnCreate.Image;
            f.title = "新增航線作業";
            f.ShowDialog();

            if (f.isOk == DialogResult.OK)
            {
                //DataTable dt = dataGridView1.DataSource as DataTable;
                //DataRow dr = dt.NewRow();
                //dr["渡輪航線"] = f.Route.RouteID渡輪航線ID;
                //dr["出發港"] = f.Route.OriginPortID出發港ID;
                //dr["目的地"] = f.Route.DestinationPortID目的地ID;
                //dr["航線敘述"] = f.Route.RouteDescription航線敘述;
                //dt.Rows.Add(dr);

                // 從 FrmShipRouteEdit 中取得輸入資料
                int originPortID = f.Route.OriginPortID出發港ID;
                int destinationPortID = f.Route.DestinationPortID目的地ID;
                string routeDescription = f.Route.RouteDescription航線敘述;

                // 將資料插入資料庫
                InsertRouteIntoDatabase(originPortID, destinationPortID, routeDescription);

                // 更新 DataGridView 顯示
                displaysql(@"SELECT r.RouteID渡輪航線ID AS 渡輪航線, o.PortName港口名稱 AS 出發港, d.PortName港口名稱 AS 目的地, r.RouteDescription航線敘述 AS 航線敘述
                     FROM 渡輪航線 r
                     JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
                     JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID");
            }
        }

        private void InsertRouteIntoDatabase(int originPortID, int destinationPortID, string routeDescription)
        {
            string sql = @"INSERT INTO 渡輪航線 (OriginPortID出發港ID, DestinationPortID目的地ID, RouteDescription航線敘述)
                   VALUES (@OriginPortID, @DestinationPortID, @RouteDescription)";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@OriginPortID", originPortID);
                cmd.Parameters.AddWithValue("@DestinationPortID", destinationPortID);
                cmd.Parameters.AddWithValue("@RouteDescription", routeDescription);

                con.Open();
                cmd.ExecuteNonQuery();
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
            string keyword = "%" + txtKeyword.Text + "%";

            string sql = @"
        SELECT r.RouteID渡輪航線ID AS 渡輪航線, 
               o.PortName港口名稱 AS 出發港, 
               d.PortName港口名稱 AS 目的地, 
               r.RouteDescription航線敘述 AS 航線敘述
        FROM 渡輪航線 r
        JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
        JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID
        WHERE r.RouteDescription航線敘述 LIKE @K_KEYWORD
        OR o.PortName港口名稱 LIKE @K_KEYWORD
        OR d.PortName港口名稱 LIKE @K_KEYWORD";

            

            displaysql(sql);
        }

        private void FrmShipRoute_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_position < 0 || dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("請選擇要刪除的航線。");
                return;
            }

            // 取得選中行的 RouteID渡輪航線ID
            int routeID = Convert.ToInt32(dataGridView1.Rows[_position].Cells["渡輪航線"].Value);

            // 顯示確認對話框
            DialogResult result = MessageBox.Show("確定要刪除這條航線嗎？", "確認刪除", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // 從資料庫刪除記錄
                DeleteRouteFromDatabase(routeID);

                // 刪除 DataGridView 中的行
                dataGridView1.Rows.RemoveAt(_position);
            }
        }

        private void DeleteRouteFromDatabase(int routeID)
        {
            string sql = "DELETE FROM 渡輪航線 WHERE RouteID渡輪航線ID = @RouteID";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@RouteID", routeID);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("航線資料已成功刪除。");
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _position = e.RowIndex;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_position < 0)
            {
                MessageBox.Show("請選擇一條航線進行編輯。");
                return;
            }

            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];

            // 創建一個新的 CRoute 物件並填入選中行的資料
            CRoute route = new CRoute();
            route.RouteID渡輪航線ID = (int)dr["渡輪航線"];
            route.OriginPortID出發港ID = GetPortIDFromName(dr["出發港"].ToString()); // 假設您有一個方法能根據港口名稱獲取PortID
            route.DestinationPortID目的地ID = GetPortIDFromName(dr["目的地"].ToString());
            route.RouteDescription航線敘述 = dr["航線敘述"].ToString();

            // 打開編輯視窗，並將資料傳遞給視窗
            FrmShipRouteEdit f = new FrmShipRouteEdit();
            f.titleIcon = btnEdit.Image;
            f.title = "編輯航線作業";
            f.Route = route;
            f.ShowDialog();

            // 如果用戶點擊了確認按鈕，將更新資料
            if (f.isOk == DialogResult.OK)
            {
                dr["出發港"] = GetPortNameFromID(f.Route.OriginPortID出發港ID); // 假設您有一個方法能根據PortID獲取港口名稱
                dr["目的地"] = GetPortNameFromID(f.Route.DestinationPortID目的地ID);
                dr["航線敘述"] = f.Route.RouteDescription航線敘述;

                UpdateRouteInDatabase(f.Route);

            }
        }

        private void UpdateRouteInDatabase(CRoute route)
        {
            string sql = @"UPDATE 渡輪航線
                   SET OriginPortID出發港ID = @OriginPortID, 
                       DestinationPortID目的地ID = @DestinationPortID, 
                       RouteDescription航線敘述 = @RouteDescription
                   WHERE RouteID渡輪航線ID = @RouteID";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@OriginPortID", route.OriginPortID出發港ID);
                cmd.Parameters.AddWithValue("@DestinationPortID", route.DestinationPortID目的地ID);
                cmd.Parameters.AddWithValue("@RouteDescription", route.RouteDescription航線敘述);
                cmd.Parameters.AddWithValue("@RouteID", route.RouteID渡輪航線ID);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private object GetPortNameFromID(int portID)
        {
            string portName = string.Empty;

            // 使用資料庫連接來查找對應的 PortName
            using (SqlConnection conn = new SqlConnection(DbConfig.GetConnectionString()))
            {
                string sql = "SELECT PortName港口名稱 FROM Port港口 WHERE PortID港口ID = @PortID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PortID", portID);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result != DBNull.Value)
                {
                    portName = result.ToString();
                }
            }

            return portName;
        }

        private int GetPortIDFromName(string portName)
        {
            int portID = -1;

            // 使用資料庫連接來查找對應的 PortID
            using (SqlConnection conn = new SqlConnection(DbConfig.GetConnectionString()))
            {
                string sql = "SELECT PortID港口ID FROM Port港口 WHERE PortName港口名稱 = @PortName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PortName", portName);

                conn.Open();
                object result = cmd.ExecuteScalar();
                conn.Close();

                if (result != null && result != DBNull.Value)
                {
                    portID = Convert.ToInt32(result);
                }
            }

            return portID;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (_position < 0 || _position >= dataGridView1.Rows.Count)
            {
                MessageBox.Show("請選擇要複製的航線。");
                return;
            }

            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dr = dt.Rows[_position];

            // 創建一個新的 CRoute 物件並填入選中行的資料
            CRoute route = new CRoute();
            route.RouteID渡輪航線ID = (int)dr["渡輪航線"];
            route.OriginPortID出發港ID = GetPortIDFromName(dr["出發港"].ToString()); // 假設您有一個方法能根據港口名稱獲取PortID
            route.DestinationPortID目的地ID = GetPortIDFromName(dr["目的地"].ToString());
            route.RouteDescription航線敘述 = dr["航線敘述"].ToString() + "(複製)";

            // 打開編輯視窗，並將資料傳遞給視窗
            FrmShipRouteEdit f = new FrmShipRouteEdit();
            f.titleIcon = btnEdit.Image;
            f.title = "編輯航線作業";
            f.Route = route;
            f.ShowDialog();

            // 如果用戶確認，將新數據插入到 DataTable 中
            if (f.isOk == DialogResult.OK)
            {
                InsertRouteIntoDatabase(f.Route);

                // 新數據來自 FrmShipRouteEdit 表單
                //DataRow newRow = dt.NewRow();
                //newRow["渡輪航線"] = f.Route.RouteID渡輪航線ID; // 需要從編輯表單獲取新的 ID
                //newRow["出發港"] = f.Route.OriginPortID出發港ID;
                //newRow["目的地"] = f.Route.DestinationPortID目的地ID;
                //newRow["航線敘述"] = f.Route.RouteDescription航線敘述;


                displaysql(@"SELECT r.RouteID渡輪航線ID AS 渡輪航線, o.PortName港口名稱 AS 出發港, d.PortName港口名稱 AS 目的地, r.RouteDescription航線敘述 AS 航線敘述
                     FROM 渡輪航線 r
                     JOIN Port港口 o ON r.OriginPortID出發港ID = o.PortID港口ID
                     JOIN Port港口 d ON r.DestinationPortID目的地ID = d.PortID港口ID");
            }
        }

        private void InsertRouteIntoDatabase(CRoute route)
        {
            string sql = @"INSERT INTO 渡輪航線 (OriginPortID出發港ID, DestinationPortID目的地ID, RouteDescription航線敘述)
                   VALUES (@OriginPortID, @DestinationPortID, @RouteDescription)";

            using (SqlConnection con = new SqlConnection(DbConfig.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@OriginPortID", route.OriginPortID出發港ID);
                cmd.Parameters.AddWithValue("@DestinationPortID", route.DestinationPortID目的地ID);
                cmd.Parameters.AddWithValue("@RouteDescription", route.RouteDescription航線敘述);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
