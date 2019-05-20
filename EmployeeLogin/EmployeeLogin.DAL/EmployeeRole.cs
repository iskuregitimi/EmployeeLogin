namespace EmployeeLogin.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeRole")]
    public partial class EmployeeRole
    {
        public int EmployeeRoleID { get; set; }

        public int EmployeeID { get; set; }

        public int RoleID { get; set; }
    }
}
