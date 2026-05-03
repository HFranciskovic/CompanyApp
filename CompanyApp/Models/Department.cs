using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentNo { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; } = string.Empty;

        [StringLength(20)]
        [Display(Name = "Location")]
        public string DepartmentLocation { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
