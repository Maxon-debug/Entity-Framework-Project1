using Hospital_Management__System.Data;
using Hospital_Management__System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Service
{
    public class AppointmentService
    {
        public void AddAppointment()
        {
            var context1 = new HospitalContext();
            using (context1)
            {
                // Create a new Appointment
                var newAppointment = new Appointment();

                Console.WriteLine("Add Appointment");

                
                Console.WriteLine("AppointmentDate:");
                DateTime userDateTime;
                if (DateTime.TryParse(Console.ReadLine(), out userDateTime))
                {
                    newAppointment.AppointmentDate = userDateTime;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                }
                Console.WriteLine("AppointmentTime:");
                DateTime userTime;
                if (DateTime.TryParse(Console.ReadLine(), out userTime))
                {
                    newAppointment.AppointmentTim = userTime;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                }
                Console.WriteLine("PatientID:");
                newAppointment.PatientID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("DoctorID:");
                newAppointment.DoctorID = Convert.ToInt32(Console.ReadLine());



                // Add the new appointment to the context and save changes
                context1.Appointments.Add(newAppointment);
                context1.SaveChanges();
                Console.WriteLine("added successifully");
            }
        }
        public void ViewAppointment()
        {
            using (var context2 = new HospitalContext())
            {
                // Retrieve Appointments
                var appointments = context2.Appointments.ToList();

                // Display or process the retrieved Appointments
                foreach (var appointment in appointments)
                {
                    Console.WriteLine($"AppointmentId: {appointment.AppointmentID}");
                    Console.WriteLine($"AppointmentDate: {appointment.AppointmentDate}");
                    Console.WriteLine($"AppointmentTime: {appointment.AppointmentTim}");
                    Console.WriteLine($"Doctor ID: {appointment.DoctorID}");

                    Console.WriteLine();
                }
            }
        }
        public void RemoveAppointment()
        {
            using (var context4 = new HospitalContext())
            {
                // Find an Appointment to delete
                Console.WriteLine("Enter AppointmentID to Delete Appointment");
                var input = Convert.ToInt32(Console.ReadLine());
                var AppointmentToDelete = context4.Appointments.Find(input);

                // Delete the Appointment if found
                if (AppointmentToDelete != null)
                {
                    // Delete the Appointment from the context and save changes
                    context4.Appointments.Remove(AppointmentToDelete);
                    context4.SaveChanges();
                    Console.WriteLine("Room Deleted Successifully");
                }
            }
        }
        public void AppointmentUI()
        {
            Console.WriteLine("1.Add Appointment");
            Console.WriteLine("2.View Appointments");
            Console.WriteLine("3.Delete Appointments");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddAppointment();
                    break;

                case 2:
                    ViewAppointment();
                    break;

                case 3:
                    RemoveAppointment();
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
}
