using slnJapanTravel.Component.Product;
using slnJapanTravel.Model.Product;
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
    public partial class FrmItinerary : Form
    {
    SqlDataAdapter _adapter;
    private SqlCommandBuilder _builder;
    CItineraryDate _date;
    string _s = "Data Source=.;Initial Catalog = JapanTravel; Integrated Security = True; Encrypt=False";
    //string _s = "Data Source=192.168.35.188;Initial Catalog=JapanTravel;User ID=Ting;Password=0000;Encrypt=False";

    public FrmItinerary()
    {
        InitializeComponent();
    }
    private void FrmItinerary_Load(object sender, EventArgs e)
    {
        displayBySql("SELECT [行程編號], [行程名稱], [體驗名稱],[可預約人數], [總團位], [價格], [主題], [地區名稱], [出團備註], [出發日期]"
            + "\r\nFROM [Itinerary行程]"
            + "\r\nJOIN [Activity體驗]\r\nON[體驗編號]=[體驗]"
            + "\r\nJOIN [Area地區]\r\nON[地區編號]=[地區]"
            + "\r\nLEFT JOIN [ItineraryTime行程批次]\r\nON[Itinerary行程].[行程系統編號]=[ItineraryTime行程批次].[行程系統編號]");
    }


    private void displayBySql(string sql)
    {

        SqlConnection con = new SqlConnection(); //new類別
        con.ConnectionString = _s; //連接自來水廠
        con.Open();

        _adapter = new SqlDataAdapter(sql, con);
        _builder = new SqlCommandBuilder(_adapter);

        DataSet ds = new DataSet();
        _adapter.Fill(ds);
        dataGridView1.DataSource = ds.Tables[0];
        con.Close();
    }

    private void btnInsert_Click(object sender, EventArgs e)
    {

    FrmItineraryInsert f = new FrmItineraryInsert();
    f.ShowDialog();
    if (f.isOK == DialogResult.OK)
    {
        CProductManager p = new CProductManager();
        p.create(f.main);

        DataTable dt = dataGridView1.DataSource as DataTable;
        DataRow dr = dt.NewRow();
        dr["行程編號"] = f.main.行程編號;
        dr["體驗名稱"] = GetActivityNameById(f.main.體驗);
        dr["行程名稱"] = f.main.行程名稱;
        dr["總團位"] = f.main.總團位.ToString();
        dr["價格"] = f.main.價格.ToString();
        dr["地區名稱"] = GetAreaNameById(f.main.地區);
        string combinedDates = "";
        foreach (var date in f.main.date.出發日期.ToString())
        {
            if (!string.IsNullOrEmpty(combinedDates))
            {
                combinedDates += ", ";
            }
            combinedDates += date.ToString();
        }
        dr["出發日期"] = combinedDates;

        dt.Rows.Add(dr);
    }
    }
    private string GetActivityNameById(int activityId)
    {
    string activityName = string.Empty;

    using (SqlConnection con = new SqlConnection(_s))
    {
        con.Open();
        string sql = "SELECT 體驗名稱 FROM Activity體驗 WHERE 體驗編號 = @ActivityId";
        using (SqlCommand cmd = new SqlCommand(sql, con))
        {
            cmd.Parameters.AddWithValue("@ActivityId", activityId);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    activityName = reader["體驗名稱"].ToString();
                }
            }
        }
    }

    return activityName;
    }
    private string GetAreaNameById(int areaId)
    {
        string areaName = string.Empty;

        using (SqlConnection con = new SqlConnection(_s))
        {
            con.Open();
            string sql = "SELECT 地區名稱 FROM Area地區 WHERE 地區編號 = @AreaId";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@AreaId", areaId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        areaName = reader["地區名稱"].ToString();
                    }
                }
            }
        }

        return areaName;
    }

    //private void dataGridView1_Paint(object sender, PaintEventArgs e)
    //{
    //    resetGridStyle();
    //}
    //}
    //private void resetGridStyle()
    //{
    //    dataGridView1.Columns[0].Width = 0;
    //    dataGridView1.Columns[1].Width = this.Width - 650;
    //    dataGridView1.Columns[2].Width = 150;
    //    dataGridView1.Columns[3].Width = 150;
    //    dataGridView1.Columns[4].Width = 150;
    //    dataGridView1.Columns[5].Width = 150;

    //    int count = 0;
    //    bool isColorChanged = false;
    //    foreach (DataGridViewRow r in dataGridView1.Rows)
    //    {
    //        count++;
    //        isColorChanged = !isColorChanged;
    //        if (isColorChanged)
    //            r.DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
    //        r.DefaultCellStyle.Font = new Font("Meiryo UI", 11);
    //        r.Height = 50;
    //        r.HeaderCell.Value = count.ToString();
    //    }
    //}

}
