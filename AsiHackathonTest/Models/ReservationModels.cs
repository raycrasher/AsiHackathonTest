using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AsiHackathonTest.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? ReservedTime { get; set; }
        public DateTime Timestamp { get; set; }
        public bool IsReserved { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
    }
}
