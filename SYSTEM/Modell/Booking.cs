using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYSTEM.MydbContext;

namespace SYSTEM.Modell
{
    internal class Booking
    {
            public int BookingID { get; set; }
            public int SpaceID { get; set; }
            public int UserID { get; set; }
            public DateTime StartTime { get; set; }
            public DateTime EndTime { get; set; }

   
    }
}
