using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sqlconnection.Models
{
    public class EmployeeDetails: DbContext
    {
        public EmployeeDetails():base ("EmployeeConnection")
        {

        }
        public DbSet<Employee> EmployeesTable { get; set; }
    }
}