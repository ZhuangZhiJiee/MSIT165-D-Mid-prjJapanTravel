using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Member
{
    public class CLoginAdmin
    {
        public int 管理員ID { get; set; }
        public string 管理員姓名 { get; set; }
        public string 管理員帳號 { get; set; }
        public string 管理員密碼 { get; set; }
        public string 管理員信箱 { get; set; }
        public byte[] 管理員照片 { get; set; }
        public bool 會員管理權限 { get; set; }
        public bool 管理員管理權限 { get; set; }
        public bool 行程管理權限 { get; set; }
        public bool 訂單管理權限 { get; set; }
        public bool 航班管理權限 { get; set; }
        public bool 部落格管理權限 { get; set; }
        public bool 評論管理權限 { get; set; }
        public bool 優惠券管理權限 { get; set; }
    }
}
