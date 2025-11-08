using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class PatientsEntity : BaseUserEntity
    {
        public int PatientId { get; set; }
        public int? UserId { get; set; }

        public string? BloodGroup { get; set; }

        public string? EmergencyContact { get; set; }

        public string Allergies { get; set; }

        public string ? CurrentMedications { get; set; }

        public string? PastMedicalHistory { get; set; }

        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public int Age { get; set; }


        
    }
}
