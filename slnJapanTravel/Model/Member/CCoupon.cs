using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Member
{
    public class CCoupon
    {
        public int 優惠券ID { get; set; }
        public string 優惠券名稱 { get; set; }
        public decimal 折扣 { get; set; }
        public DateTime 到期日 { get; set; }
        public decimal 使用條件 { get; set; }
        public bool 可否使用 { get; set; }
    }
}
