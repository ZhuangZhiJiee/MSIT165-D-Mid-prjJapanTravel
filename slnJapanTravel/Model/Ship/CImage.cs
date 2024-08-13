using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CImage
    {
        public int ImageID渡輪圖片ID { get; set; }
        public int RouteID渡輪航線ID { get; set; }
        public byte[] Image圖片 { get; set; }
        public string Description圖片描述 { get; set; }
    }
}
