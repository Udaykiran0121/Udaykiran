using Microsoft.SqlServer.Server;
using System;
using System.ComponentModel.DataAnnotations;

namespace EnterpriseHRMS.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [StringLength(100)]
        public string EmpFullName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string Department { get; set; }
        [Required]
        [StringLength (100)]

        public string Role { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime JoiningDate { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(100)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}