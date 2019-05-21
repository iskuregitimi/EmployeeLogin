namespace EmployeeLogin.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Address")]
    public partial class Address
    {
        [Key]
        public int AdresID { get; set; }

        public int CustomerID { get; set; }

        [StringLength(200)]
        public string Adres { get; set; }
    }
}
