using System;
using System.Collections.Generic;

namespace SYSTEM.Models
{
    public partial class Space
    {
        public Space()
        {
            Bookings = new HashSet<Booking>();
        }

        public int SpaceId { get; set; }
        public string SpaceName { get; set; } = null!;
        public int? Capacity { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
