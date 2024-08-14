using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model.Blog
{
    public class Carticlepic
    {
        public int 圖片編號 { get; set; }
        public int  文章編號 { get; set; }
        public byte[] 文章圖片 { get; set; }
        public string 文章圖片說明 { get; set; }
    }
}
