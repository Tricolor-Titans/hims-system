using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class AdminEntity : Person
    {
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? MobileNo { get; set; }


    }
}