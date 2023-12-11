// See https://aka.ms/new-console-template for more information
using Hospital_Management__System.Data;
using Hospital_Management__System.Models;
using Hospital_Management__System.Service;

Console.WriteLine("1.Patient Page");
Console.WriteLine("2.Doctor Page");
Console.WriteLine("3.Room Page");
Console.WriteLine("4.Appointment Page");
var Patient= new PatientService(); 
var Doctor = new DoctorService();
var Room = new RoomService();
var Appointment = new AppointmentService();
var input = Convert.ToInt32(Console.ReadLine());


switch (input)
{
    case 1:
        Patient.PatientUI();
        
        break;
    case 2:
        Doctor.DoctorUI();
        break;

    case 3:
        Room.RoomUI();
        break;

    case 4:
        Appointment.AppointmentUI();
        break;

    case 5:
        Console.WriteLine("Appointment Page");
        break;


}







