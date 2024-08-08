using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class C航班訂單資料
    {
        public int 航班訂單編號 { get; set; }
        public int 會員ID {  get; set; }
        public DateTime 下單時間 { get; set; }
        public int 付款方式編號 { get; set; }
        public int 付款狀態編號 { get; set; }
        public DateTime 付款時間 { get; set; }
        public int 訂單狀態編號 { get; set; }
        public int 優惠券ID { get; set; }
        public string 備註 { get; set; }
        public int 評論星級 { get; set; }
        public string 評論內容 { get; set; }
        public DateTime 評論日期 { get; set; }
        public bool 評論狀態 {  get; set; }
    }
}
