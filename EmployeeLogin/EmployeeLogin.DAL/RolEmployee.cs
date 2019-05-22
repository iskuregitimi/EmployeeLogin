namespace EmployeeLogin.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolEmployee")]
    public partial class RolEmployee
    {
        public int RolEmployeeId { get; set; }

        public int? EmployeeId { get; set; }

        public int? RoleId { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Roller Roller { get; set; }
    }
}
