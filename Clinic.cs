using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClinicManagementSystem
{
    internal class Clinic
    {
        List<Patient> patients = new List<Patient>();
        List<Doctor> doctors = new List<Doctor>();
        List<Appointment> appointments = new List<Appointment>();

        public void AddPatient()
        {

            Patient p = new Patient();
            Console.WriteLine("Enter patient's Name : ");
            p.Name = Console.ReadLine();
            Console.WriteLine("Enter patient's Age : ");
            p.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter patient's ID : ");
            p.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter patient's Phone Number : ");
            p.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter patient's Address : ");
            p.Address = Console.ReadLine();
            patients.Add(p);
            Console.WriteLine(" Added ! ");
            Thread.Sleep(1500);
            Console.Clear();

        }

        public void AddDoctor()
        {
            Doctor d = new Doctor();

            Console.Write("Enter Doctor Name: ");
            d.Name = Console.ReadLine();

            Console.Write("Enter Doctor ID: ");
            d.ID = Console.ReadLine();

            Console.WriteLine("Choose Specialty: ");
            foreach (var spec in Enum.GetValues(typeof(Doctor.Specialty)))
            {
                Console.WriteLine($"{(int)spec} - {spec}");
            }

            int specChoice = Convert.ToInt32(Console.ReadLine());
            if (Enum.IsDefined(typeof(Doctor.Specialty), specChoice))
                d.specialty = (Doctor.Specialty)specChoice;

            doctors.Add(d);
            Console.WriteLine(" Doctor Added Successfully!");

            Thread.Sleep(1500);
            Console.Clear();
        }

        public void AddAppointment()
        {
            Appointment a = new Appointment();

            Console.WriteLine("Enter Appointment ID: ");
            a.Id = Console.ReadLine();

            Console.WriteLine("Enter Patient ID: ");
            int patientId = Convert.ToInt32(Console.ReadLine());


            bool foundPatient = false;
            foreach (Patient p in patients)
            {
                if (p.ID == patientId)
                {
                    a.Patient = p;
                    foundPatient = true;
                    break;
                }
            }

            if (!foundPatient)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Patient not found.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter Doctor ID: ");
            string doctorId = Console.ReadLine();


            bool foundDoctor = false;
            foreach (Doctor d in doctors)
            {
                if (d.ID == doctorId)
                {
                    a.Doctor = d;
                    foundDoctor = true;
                    break;
                }
            }

            if (!foundDoctor)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Doctor not found.");
                Console.ResetColor();
                return;
            }

            Console.WriteLine("Enter Appointment Date (yyyy-mm-dd): ");
            a.Date = DateTime.Parse(Console.ReadLine());


            appointments.Add(a);
            Console.WriteLine(" Appointment Added Successfully!");

            Thread.Sleep(1500);
            Console.Clear();
        }
        public void SearchPatientById()

        {
            Console.WriteLine("Enter The ID Of the Patient To Search: ");
            int patientId = Convert.ToInt32(Console.ReadLine());
            bool found = false;
            foreach (Patient d in patients) {
                if (patientId==d.ID)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Patient Found: Name: {d.Name}, ID: {d.ID}, Age: {d.Age}, Phone: {d.PhoneNumber}, Address: {d.Address}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Patient not found.");
            }

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }

        public void SearchDoctorById()
        {
            Console.WriteLine("Enter The ID Of the Doctor To Search: ");
            string Doctor_Id = Console.ReadLine();
            bool found = false;
            foreach (Doctor doc in doctors)
            {
                if (doc.ID == Doctor_Id)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Doctor Found: Name: {doc.Name}, ID: {doc.ID}, Specialty: {doc.specialty}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Doctor not found.");
            }
            Console.ReadKey();
            Console.Clear();
        }
        public void SearchAppointment()
        {
            Console.WriteLine("Enter The ID Of the Appointment To Search: ");
            string Appointment_Id = Console.ReadLine();
            bool found = false;
            foreach (Appointment app in appointments)
            {
                if (app.Id == Appointment_Id)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Appointment Found: ID: {app.Id}, Patient: {app.Patient.Name}, Doctor: {app.Doctor.Name}, Date: {app.Date}");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Appointment not found.");
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void exit()
        {
            Console.ResetColor();
            Console.BackgroundColor= ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n\n\n-------We Are Pleased To Serve You !------ ");
            return;
        }
    }
}


       