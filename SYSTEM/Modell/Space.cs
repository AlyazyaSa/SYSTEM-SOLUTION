using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYSTEM.Modell
{
    internal class Space
    {
            [Key]
            public int SpaceID { get; set; }

            public string SpaceName { get; set; }
            public int Capacity { get; set; }
            public string Description { get; set; }
    }
}
