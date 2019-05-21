namespace EmployeeLogin.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phone")]
    public partial class Phone
    {
        public int PhoneID { get; set; }

        public int CustomerID { get; set; }

        [Required]
        [StringLength(24)]
        public string PhoneNumber { get; set; }
    }
}
