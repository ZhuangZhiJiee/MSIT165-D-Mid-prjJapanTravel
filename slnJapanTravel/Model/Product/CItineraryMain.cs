using slnJapanTravel.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CItineraryMain
    {
        public CItineraryDate date {  get; set; }
        public int 行程系統編號 {  get; set; }
        public string 行程編號 { get; set;}
        public string 行程名稱 { get; set; } 
        public int 體驗 { get; set; }
        public string 體驗名稱 { get; set;}
        public int 可預約人數 { get; set; }
        public int 總團位 { get; set;}
        public int 價格 { get; set;}
        public int 地區 { get; set;}
        public string 地區名稱 { get; set;}
        public int 主題 { get; set;}
        public string 出團備註 { get; set;}
        public byte[] 圖片 { get; set;}
    }
}
