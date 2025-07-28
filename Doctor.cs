using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicManagementSystem
{
    internal class Doctor
    {
        // doctor's info
        public string ID { get; set; }
        public string Name { get; set; }
        public  Specialty specialty { get; set; }
        public string PhoneNumber { get; set; }


        public enum Specialty
        {
            Cardiology=1,
            Dermatology,
            Pediatrics,
            Orthopedics,
            Neurology,
            General,
            InternalMedicine,
            Surgery
        }
    }
}
