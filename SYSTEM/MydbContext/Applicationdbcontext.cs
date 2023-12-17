using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM.Modell;

namespace SYSTEM.MydbContext
{
    internal class Applicationdbcontext : DbContext
    {
      
         public DbSet<Booking> Bookings { get; set; }
        public DbSet<Space> Space { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog= CodeAcademyBookingDB;Integrated Security=True;");

        }
        

    }
}
