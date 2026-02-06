using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace sqlconnection.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        [Required]
        public string EmpName { get; set; }
        public Nullable<decimal> EmpSalary { get; set; }

    }
}