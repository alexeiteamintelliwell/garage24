using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace garage24.Models
{
    
    public class Vehicle
    {
        public int Id { get; set; }

        [Display(Name ="Vehicle Type")]
        public VType VType { get; set; }

        [Display(Name ="Reg Nr")]
        [RegularExpression(pattern: "^[A-Za-z]{3}[0-9]{3}", ErrorMessage ="......")]
        public string RegNr { get; set; }
        public string Color { get; set; }

       // [StringLength(50)]
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