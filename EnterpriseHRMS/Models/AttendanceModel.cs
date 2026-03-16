using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseHRMS.Models
{
    public class AttendanceModel
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }   
        public DateTime Date { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}