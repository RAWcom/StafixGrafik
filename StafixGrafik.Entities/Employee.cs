using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StafixGrafik.Entities
{  
    public partial class Employee
    {
        public Employee()
        {
            this.Skill = new HashSet<Skill>();
            this.Function = new HashSet<Function>();
        }
    
        [Required]
        public int EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string Memo { get; set; }

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }
        public virtual ICollection<Skill> Skill { get; set; }
        public virtual ICollection<Function> Function { get; set; }
    }
}
