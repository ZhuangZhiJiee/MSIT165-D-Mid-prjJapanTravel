using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CItineraryMain
    {
        public int 行程系統編號 {  get; set; }
        public string 行程編號 { get; set;}
        public string 行程名稱 {  get; set; }
        public int 總團位 { get; set;}
        public int 價格 { get; set;}
        public int 地區 { get; set;}
        public int 明細 { get; set;}
        public int 景點 { get; set;}
        public int 飯店 { get; set;}
        public string 行程亮點 { get; set;}
        public string 出團備註 { get; set;}
    }
}
