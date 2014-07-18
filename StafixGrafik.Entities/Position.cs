using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StafixGrafik.Entities
{
    public partial class Position
    {
        [Required]
        public int PositionId { get; set; }
        [Required]
        public string Name { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
