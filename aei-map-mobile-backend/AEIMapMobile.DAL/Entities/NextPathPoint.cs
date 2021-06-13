using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class NextPathPoint
    {
        [Required]
        public int SourcePointId { get; set; }
        public PathPoint SourcePoint { get; set; }

        [Required]
        public int NextPointId { get; set; }
        public PathPoint NextPoint { get; set; }
    }
}
