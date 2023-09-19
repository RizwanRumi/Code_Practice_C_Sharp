using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.ViewModels
{
    public class EmployeeCreateViewModel
    {        
        [Required]
        [MaxLength(50, ErrorMessage = "Name Cannot Exceed 50 Characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Dept? Department { get; set; }
        public IFormFile Photo { get; set; }
    }
}
