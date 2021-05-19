using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class FilterValue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Room> Rooms { get; set; }
        [Required, DefaultValue(false)]
        public Filter Filter { get; set; }
    }
}
