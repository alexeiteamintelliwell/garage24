using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace garage24.Models
{
    
    public class Vehicle
    {
        public int Id { get; set; }
        public VType VType { get; set; }
        public string RegNr { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string VName { get; set; }
        public int WheelTally { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }

    }

    public enum VType
    {
        Car,
        Boat,
        Lorry,
        Bus,
        Motorcycle
    }
}