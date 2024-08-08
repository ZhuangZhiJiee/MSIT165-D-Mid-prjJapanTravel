using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CDetail
    {
        public int 明細編號 {  get; set; }
        public int 行程系統編號 { get; set; }
        public int 第幾天 { get; set; }
        public string 明細名稱 { get; set; }
        public CSpot spot { get; set; }
        public CHotel hotel { get; set; }
        public string 明細描述 { get; set;}
    }
}
