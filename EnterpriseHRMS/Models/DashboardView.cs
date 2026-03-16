using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseHRMS.Models
{
    public class DashboardView
    {
        public int TotalEmployees { get; set; }
        public int TotalHR { get; set; }
        public int TotalManagers { get; set; }
        public  int ActiveEmployees {  get; set; }
        public int DeletedEmployees { get; set; }
        public int EmployeesAddedToday { get; set; }
        public List<EmployeeModel> RecentEmployees { get; set; }
    }
}