using System;
using System.Collections.Generic;

namespace SYSTEM.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int? SpaceId { get; set; }
        public int? UserId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Space? Space { get; set; }
    }
}
