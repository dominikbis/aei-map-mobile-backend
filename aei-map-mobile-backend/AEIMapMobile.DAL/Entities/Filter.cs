﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEIMapMobile.DAL.Entities
{
    public class Filter
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IEnumerable<FilterValue> FilterValues { get; set; }
    }
}
