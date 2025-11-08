using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public  class ReportEntity
    {
        public int ReportId { get; set; }

        public int AppointmentId { get; set; }

       
        public int DoctorId { get; set; }

       
        public int PatientId { get; set; }

        public string Description { get; set; }

        

        public string Attachments { get; set; }

        public DateTime ReportCreatedDate { get; set; }

        public DateTime? ReportUpdatedDate { get; set; }

    }
}
