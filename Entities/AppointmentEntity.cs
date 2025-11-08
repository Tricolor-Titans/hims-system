using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Entities
{
    public  class AppointmentEntity:BaseUserEntity
    {
        public int AppointmentId { get; set; }

       
        public int PatientId { get; set; }

       
        public int SessionId { get; set; }

        
        public int DoctorId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime AppointmentDate { get; set; }

        public string Status { get; set; }

        public string ReasonForVisit { get; set; }

       

       
    }
}
