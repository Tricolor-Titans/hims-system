using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AdminsEntity: BaseUserEntity
    {
        public int AdminId { get; set; }
        public int? UserId { get; set; }
        public string? Designation { get; set; }
        public string AccessLevel { get; set; } 
        
    }
}
