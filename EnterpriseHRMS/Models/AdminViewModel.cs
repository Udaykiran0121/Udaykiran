using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseHRMS.Models
{
    public class AdminViewModel
    {
        public int TotalUsers {  get; set; }
        public int TotalCompanyUsers {  get; set; }
        public int TotalPublicUsers {  get; set; }
        public int TotalEmployees {  get; set; }
        public int TotalRoles { get; set; }
        public int TotalHR {  get; set; }
        public int TotalManagers {  get; set; }


    }
}