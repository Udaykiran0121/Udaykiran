using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EsportsDetails.Models
{
    [Table("tblEsports")]
    public class Esports
    {
        [Key]
        public int PlyrID { get; set; }
        public string PlyrName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int PlyrLevel { get; set; }
    }
}