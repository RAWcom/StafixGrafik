using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using StafixGrafik.Entities;

namespace StafixGrafik.Web.DataContexts
{   
    public partial class EmployeeDb : DbContext
    {
        public EmployeeDb()
            : base("DefaultConnection")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Function> Functions { get; set; }
    }
}
