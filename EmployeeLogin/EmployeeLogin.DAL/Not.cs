namespace EmployeeLogin.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Not")]
    public partial class Not
    {
        public int NotId { get; set; }

        public int? EmployeeId { get; set; }

        public int? CustomerId { get; set; }

        [StringLength(50)]
        public string details { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        public DateTime? Date { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
