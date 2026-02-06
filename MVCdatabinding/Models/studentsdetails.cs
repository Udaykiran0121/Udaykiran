using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;

namespace MVCdatabinding.Models
{
    public class studentsdetails:DbContext
    {
        public studentsdetails()
            : base("StudentsConnection")
        {

        }
        public DbSet<Students> StudentsTable{ get; set; }
    }
}