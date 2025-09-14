using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Role { get; set; }
    }
}