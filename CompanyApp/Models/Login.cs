using System.ComponentModel.DataAnnotations;

namespace CompanyApp.Models
{
    public class Login
    {
        [Key]
        public int LoginNo { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Username")]
        public string LoginUserName { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; } = string.Empty;
    }
}
