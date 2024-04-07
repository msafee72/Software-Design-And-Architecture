using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Doctor
    {
        private static Doctor instance;
        private string doctorId {  get; set; }
        private string name {  get; set; }
        private string specialization {  get; set; }
        private List<Patient> patients;

        private Doctor(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
            this.doctorId = GenerateDoctorId();
            this.patients = new List<Patient>();
        }

        public static Doctor GetInstance(string name, string specialization)
        {
            if (instance == null)
            {
                instance = new Doctor(name, specialization);
            }
            return instance;
        }

        private string GenerateDoctorId()
        {
            string id = new Random().Next().ToString();
            return id;
        }

        public void addPatient(Patient patient)
        {
            patients.Add(patient);
        }

        public void removePatient(Patient patient)
        {
            patients.Remove(patient);
        }

        public List<Patient> getPatients()
        {
            return patients;
        }
    }
}
