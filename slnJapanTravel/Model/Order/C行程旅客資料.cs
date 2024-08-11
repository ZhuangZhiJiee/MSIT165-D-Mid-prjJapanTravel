using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class C行程旅客資料
    {
        public int 行程旅客資料編號 {  get; set; }
        public int 行程訂單編號 {  set; get; }
        public string 姓氏 { set; get; }
        public string 名字 { set; get; }
        public string 身分證字號 {  get; set; }
        public string 護照號碼 { set; get; }
    }
}
