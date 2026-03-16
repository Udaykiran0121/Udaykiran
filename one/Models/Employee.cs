using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace one.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}