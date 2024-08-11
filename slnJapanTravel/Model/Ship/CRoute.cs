using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace slnJapanTravel.Model
{
    public class CRoute
    {
        public int RouteID渡輪航線ID { get; set; }
        public int OriginPortID出發港ID { get; set; }
        public int DestinationPortID目的地ID { get; set; }
        public string RouteDescription航線敘述 { get; set; }
        public CPort OriginPort { get; set; }
        public CPort DestinationPort { get; set; }
    }
}
