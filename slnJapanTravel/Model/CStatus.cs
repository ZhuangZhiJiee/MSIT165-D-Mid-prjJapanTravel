using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slnJapanTravel.Model
{
    public class CStatus
    {
        public class C付款狀態
        {
            public int 付款狀態編號 { get; set; }
            public string 付款狀態 { get; set; }
        }
        public class C訂單狀態
        {
            public int 訂單狀態編號 { get; set; }
            public string 訂單狀態 { get; set; }
        }

    }
}
