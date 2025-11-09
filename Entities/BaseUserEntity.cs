using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BaseUserEntity
    {
        [Key]
        public int UserId { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }

        public string PasswordHash { get; set; } 

        public string? Role { get; set; }

        public string ? MobileNo { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
