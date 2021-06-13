using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class PathPoint
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int X { get; set; }

        [Required]
        public int Y { get; set; }

        [Required, DefaultValue(false)]
        public bool IsExitPoint { get; set; }

        [Required]
        public int SectorId { get; set; }
        public Sector Sector { get; set; }

        [Required]
        public int FloorId { get; set; }
        public Floor Floor { get; set; }

        public ICollection<NextPathPoint> SourcePathPoints { get; set; }
        public ICollection<NextPathPoint> NextPathPoints { get; set; }
    }
}
