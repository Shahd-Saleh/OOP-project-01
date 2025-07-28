using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClinicManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clinic clinic = new Clinic();
            bool KeepGoing = true;
            while (KeepGoing)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("------ Welcome To Clinic System -------");
                Console.ResetColor();
                Console.ForegroundColor= ConsoleColor.Magenta;
                Console.WriteLine("1-Add New Patient");
                Console.WriteLine("2-Add New Doctor");
                Console.WriteLine("3-Add New Appointment");
                Console.WriteLine("4-Search Patient By ID ");
                Console.WriteLine("5-Search Doctor By ID ");
                Console.WriteLine("6-Search Appointment ");
                Console.WriteLine("7-Exit");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Enter Your Choice ....");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                

                switch (choice)
                {
                    case 1:
                        clinic.AddPatient();
                        break;
                    case 2:
                        clinic.AddDoctor();
                        break;
                    case 3:
                        clinic.AddAppointment();
                        break;
                    case 4:
                        clinic.SearchPatientById();
                        break;
                    case 5:
                        clinic.SearchDoctorById();
                        break;
                    case 6:
                        clinic.SearchAppointment();
                        break;
                    case 7:
                        clinic.exit();
                        KeepGoing = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            

            
        
        }
    }
}
