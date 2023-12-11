using Hospital_Management__System.Data;
using Hospital_Management__System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Service
{
    public class DoctorService
    {
        public void AddDoctor()
        {
            var context1 = new HospitalContext();
            using (context1)
            {
                // Create a new doctor
                var newDoctor = new Doctor();

                Console.WriteLine("Add Doctor");

                //Console.WriteLine("DoctorID:");
               // newDoctor.DoctorID =Convert.ToInt32( Console.ReadLine());
               Console.WriteLine("DoctorName:");
                newDoctor.DoctorName = Console.ReadLine();
                Console.WriteLine("Specialty:");
                newDoctor.Specialty = Console.ReadLine();
                


                // Add the new doctor to the context and save changes
                context1.Doctors.Add(newDoctor);
                context1.SaveChanges();
                Console.WriteLine("added successifully");
            }
        }

        public void ViewDoctor()
        {
            using (var context2 = new HospitalContext())
            {
                // Retrieve doctor
                var doctors = context2.Doctors.ToList();

                // Display or process the retrieved doctors
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"Doctor ID: {doctor.DoctorID}");
                    Console.WriteLine($"Name: {doctor.DoctorName}");
                   
                    Console.WriteLine();
                }
            }
        }
        public void RemoveDoctor()
        {
            using (var context4 = new HospitalContext())
            {
                // Find a doctor to delete
                Console.WriteLine("Enter DoctorID to Delete Doctor");
                var input = Convert.ToInt32(Console.ReadLine());
                var doctorToDelete = context4.Doctors.Find(input);

                // Delete the doctor if found
                if (doctorToDelete != null)
                {
                    // Delete the patient from the context and save changes
                    context4.Doctors.Remove(doctorToDelete);
                    context4.SaveChanges();
                    Console.WriteLine("Doctor Deleted Successifully");
                }
            }
            
        }
        public void DoctorUI()
        {
            Console.WriteLine("1.Add Doctor");
            Console.WriteLine("2.View Doctor");
            Console.WriteLine("3.Delete Doctor");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddDoctor();
                    break;

                case 2:
                    ViewDoctor();
                    break;

                case 3:
                    RemoveDoctor();
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    
    }
}
