using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorID { get; set; }
        public string DoctorName {  get; set; }
        public string Specialty {  get; set; }


        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();

    }
}
