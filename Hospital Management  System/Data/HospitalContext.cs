using Hospital_Management__System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Data
{
    public class HospitalContext : DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //var configbuilder = new configurationbuilder().addjsonfile("appsettings.json").build();
            //var configsection = configbuilder.getsection("connectionstrings");
            //var connectionstring = configsection["sqlserverconnection"] ?? null;
            //optionsbuilder.usesqlserver(connectionstring);
            optionsBuilder.UseSqlServer("Server=MAXON-DEBUG79;Database=HOSPITSAL_DB2;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships here
            modelBuilder.Entity<Patient>()
                .HasOne(p => p.Room)
                .WithMany(r => r.Patients)
                .HasForeignKey(p => p.RoomID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(p => p.Appointments)
                .HasForeignKey(a => a.PatientID)
                .OnDelete(DeleteBehavior.Cascade);  // Specify Restrict here

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(d => d.Appointments)
                .HasForeignKey(a => a.DoctorID)
                .OnDelete(DeleteBehavior.Cascade); 


        }



    }

}
