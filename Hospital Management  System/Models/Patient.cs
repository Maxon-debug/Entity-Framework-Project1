using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Models
{
    public class Patient
    {
        [Key]
        public int PatientID {  get; set; }
       public string FirstName {  get; set; }
       public string LastName { get; set; }
       public  string Email {  get; set; }
        //int RoomID {  get; set; }


        public int RoomID { get; set; }
        public Room Room { get; set; } = null!;



        public ICollection<Appointment> Appointments { get; } = new List<Appointment>();
    }
}
