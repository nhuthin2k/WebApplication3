using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    [Table("Accounts")]
    public class Role
    {
        [Key]
        [StringLength(20)]
        public string RoleID { get; set; }
      
        public string RoleName { get; set; }
    }
}