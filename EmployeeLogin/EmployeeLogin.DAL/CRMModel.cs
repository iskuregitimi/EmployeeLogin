namespace EmployeeLogin.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRMModel : DbContext
    {
        public CRMModel()
            : base("name=CRMModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Lead> Leads { get; set; }
        public virtual DbSet<Not> Nots { get; set; }
        public virtual DbSet<RolEmployee> RolEmployees { get; set; }
        public virtual DbSet<Roller> Rollers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Telno)
                .IsFixedLength();
        }
    }
}
