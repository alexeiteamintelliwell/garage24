namespace garage24.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<garage24.DataAccessLayer.VehicleContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(garage24.DataAccessLayer.VehicleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Vehicles.AddOrUpdate(
               p => p.RegNr,
               new Vehicle { VType = VType.Car, RegNr = "FRL-111", Color = "Blue", Brand = "Toyota", VName = "Prius", CheckInTime = DateTime.Now, CheckOutTime = DateTime.Now },
               new Vehicle { VType = VType.Motorcycle, RegNr = "FRL-222", Color = "Black", Brand = "Kawasaki", VName = "Jet", CheckInTime = DateTime.Now, CheckOutTime = DateTime.Now });

        }
    }
}
