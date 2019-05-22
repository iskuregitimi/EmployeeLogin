namespace EmployeeLogin.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Leads = new HashSet<Lead>();
            Nots = new HashSet<Not>();
        }

        public int CustomerId { get; set; }

        [StringLength(50)]
        public string Adı { get; set; }

        [StringLength(50)]
        public string Soyadı { get; set; }

        public DateTime? Doğumtarihi { get; set; }

        [StringLength(11)]
        public string Telno { get; set; }

        [StringLength(11)]
        public string Telno2 { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Email2 { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }

        [StringLength(200)]
        public string Adress2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lead> Leads { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Not> Nots { get; set; }
    }
}
