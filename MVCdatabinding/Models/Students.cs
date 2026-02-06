using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MVCdatabinding.Models
{
    [Table("tblstudents")]
    public class Students
    {
        [Key]
        public int studentId { get; set; }
        public string Name { get; set; }
        public int RollNo { get; set; }
    }
}