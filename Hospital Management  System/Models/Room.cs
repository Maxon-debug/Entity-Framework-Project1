using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
       public string RoomNumber {  get; set; }
       public string RoomType {  get; set; }

       
        public ICollection<Patient>Patients { get; } = new List<Patient>();
    }
}
