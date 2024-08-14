using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Blog
{
    public class Carticle
    {
        public int 文章編號 { get; set; }
        public int 會員ID { get; set; }
        public string 文章標題 { get; set; }
        public DateTime 發布時間 { get; set; }       
        public string 文章狀態 { get; set; }
        public Chashtag hashtag { get; set; }
        public Carticlepic pic { get; set; }
    }
}
