using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Floor : Area
    {
        public List<Room> Rooms { get; set; }
    }
}
