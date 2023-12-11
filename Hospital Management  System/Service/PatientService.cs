using Hospital_Management__System.Data;
using Hospital_Management__System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Service
{
    public class PatientService
    {
        public void AddPatient()
        {
            var context1 = new HospitalContext();
            using (context1)
            {
                // Create a new patient
                var newPatient = new Patient();

                Console.WriteLine("Add Patient");

                Console.WriteLine("Firstname:");
                newPatient.FirstName = Console.ReadLine();
                Console.WriteLine("Lastname:");
                newPatient.LastName = Console.ReadLine();
                Console.WriteLine("Email:");
                newPatient.Email = Console.ReadLine();
                Console.WriteLine("RoomID:");
                newPatient.RoomID = Convert.ToInt32(Console.ReadLine());



                // Add the new patient to the context and save changes
                context1.Patients.Add(newPatient);
                context1.SaveChanges();
                Console.WriteLine("added successifully");
            }
        }
        public void ViewPatient()
        {
            using (var context2 = new HospitalContext())
            {
                // Retrieve patients
                var patients = context2.Patients.ToList();

                // Display or process the retrieved patients
                foreach (var patient in patients)
                {
                    Console.WriteLine($"Patient ID: {patient.PatientID}");
                    Console.WriteLine($"Name: {patient.FirstName}");
                    // Display other patient properties as needed
                    Console.WriteLine();
                }
            }
        }
        public void RemovePatient()
        {
            using (var context4 = new HospitalContext())
            {
                // Find a patient to delete
                Console.WriteLine("Enter PatientID to Delete Patient");
                var input = Convert.ToInt32(Console.ReadLine());
                var patientToDelete = context4.Patients.Find(input);

                // Delete the patient if found
                if (patientToDelete != null)
                {
                    // Delete the patient from the context and save changes
                    context4.Patients.Remove(patientToDelete);
                    context4.SaveChanges();
                    Console.WriteLine("Patient Deleted Successifully");
                }
            }
        }
        public void PatientUI()
        {
            Console.WriteLine("1.Add Patient");
            Console.WriteLine("2.View Patient");
            Console.WriteLine("3.Delete Patient");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddPatient();
                    break;

                case 2:
                    ViewPatient();
                    break;

                case 3:
                    RemovePatient();
                    break;

                default:
                Console.WriteLine("wrong choice");
                break;
            }
        }
    }
}
