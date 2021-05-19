using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        public string Name { get; set; }
        public ICollection<RoomPoint> Points { get; set; }
        public ICollection<FilterValue> FilterValues { get; set; }
        [Required, DefaultValue(false)]
        public Floor Floor { get; set; }
    }
}
