using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class DoctorEntity: BaseUserEntity
    {
        public int DoctorId { get; set; }
        public int? UserId { get; set; }
        public string? Specialization { get; set; }
        public string? Qualification { get; set; }
        public int ExperienceYears{ get; set; }
        public decimal? ConsultationFee { get; set; }

        public string AvailableDays { get; set; }

    }
}
