using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Patient
    {
        private static Patient instance;
        private string patientId {  get; set; }
        private string name {  get; set; }
        private int age {  get; set; }
        private string gender {  get; set; }
        private string medicalHistory;
        private List<Prescription> prescriptions;

        private Patient(string name, int age, string gender, string medicalHistory)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.medicalHistory = medicalHistory;
            this.patientId = GeneratePatientId();
            this.prescriptions = new List<Prescription>();
        }

        public static Patient GetInstance(string name, int age, string gender, string medicalHistory)
        {
            if (instance == null)
            {
                instance = new Patient(name, age, gender, medicalHistory);
            }
            return instance;
        }

        private string GeneratePatientId()
        {
            string id = new Random().Next().ToString();
            return id;
        }


        public string getMedicalHistory()
        {
            return medicalHistory;
        }

        public void addPrescription(Prescription prescription)
        {
            prescriptions.Add(prescription);
        }

        public void removePrescription(Prescription prescription)
        {
            prescriptions.Remove(prescription);
        }

        public List<Prescription> getPrescriptions()
        {
            return prescriptions;
        }
    }
}
