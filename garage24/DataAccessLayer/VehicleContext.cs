using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using garage24.Models;

namespace garage24.DataAccessLayer
{
    public class VehicleContext : DbContext
        
    {
        public VehicleContext()
            : base("DefaultAttempt")
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}