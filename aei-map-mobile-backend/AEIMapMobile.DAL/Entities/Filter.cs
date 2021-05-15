using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Filter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FilterValue> PossibleValues { get; set; }
    }
}
