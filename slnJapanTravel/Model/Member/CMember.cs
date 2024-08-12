using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Member
{
    public class CMember
    {
        public int 會員ID { get; set; }
        public string 會員名稱 { get; set; }
        public string 性別 { get; set; }
        public DateTime 生日 { get; set; }
        public string 電話 {  get; set; }
        public string Email {  get; set; }
        public string 會員帳號 {  get; set; }
        public string 會員密碼 {  get; set; }
        public string 城市 {  get; set; }
        public string 地址 { get; set; }
        public byte[] 會員照片 { get; set; }
        public bool 會員狀態 { get; set; }
    }
}
