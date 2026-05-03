using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompanyApp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeNo { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Employee Name")]
        public string EmployeeName { get; set; } = string.Empty;

        [Display(Name = "Salary")]
        public int Salary { get; set; }

        [Display(Name = "Last Modified")]
        public DateTime LastModifyDate { get; set; } = DateTime.Now;

        [ForeignKey("Department")]
        [Display(Name = "Department")]
        public int DepartmentNo { get; set; }

        public Department? Department { get; set; }
    }
}
