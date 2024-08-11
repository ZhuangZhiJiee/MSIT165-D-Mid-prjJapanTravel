using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace slnJapanTravel.Model
{
    public class CSchedule
    {
        public int ScheduleID渡輪航班ID { get; set; }
        public int RouteID渡輪航線ID { get; set; }
        public DateTime DepartureTime出發時間 { get; set; }
        public DateTime ArrivalTime到達時間 { get; set; }
        public int Seats總座位數 { get; set; }
        public int Capacity售出座位數 { get; set; }
        public CRoute Route { get; set; }
    }
}
