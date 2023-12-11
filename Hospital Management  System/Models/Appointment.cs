using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Models
{
    public class Appointment
    {
      
        [Key]
        public int AppointmentID {  get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime AppointmentTim {  get; set; }


        public int PatientID  { get; set; }
        public Patient? Patient { get; set; } 
        public int DoctorID { get; set; }
        public Doctor? Doctor { get; set; } 
    }
}
