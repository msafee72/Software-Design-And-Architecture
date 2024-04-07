using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Department
    {
        private static Department instance;
        private string departmentId;
        private string name;
        private List<Doctor> doctors;
        private List<Patient> patients;

        private Department(string name)
        {
            this.name = name;
            this.departmentId = GenerateDepartmentId();
            this.doctors = new List<Doctor>();
            this.patients = new List<Patient>();
        }

        public static Department GetInstance(string name)
        {
            if (instance == null)
            {
                instance = new Department(name);
            }
            return instance;
        }

        private string GenerateDepartmentId()
        {
            string id = new Random().Next().ToString();
            return id;
        }

        public string getId()
        {
            return departmentId;
        }

        public string getName()
        {
            return name;
        }

        public void addDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        public void removeDoctor(Doctor doctor)
        {
            doctors.Remove(doctor);
        }

        public List<Doctor> getDoctors()
        {
            return doctors;
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
