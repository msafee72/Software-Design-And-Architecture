using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Prescription
    {
        private static Prescription instance;
        private string prescriptionId {  get; set; }
        private string medicationName {  get; set; }
        private string dosage {  get; set; }
        private string frequency {  get; set; }
        private DateTime startDate {  get; set; }
        private DateTime endDate {  get; set; }

        private Prescription(string medicationName, string dosage, string frequency, DateTime startDate, DateTime endDate)
        {
            // Initialize prescription data members
            this.medicationName = medicationName;
            this.dosage = dosage;
            this.frequency = frequency;
            this.startDate = startDate;
            this.endDate = endDate;
            // Generate prescriptionId or any other initialization logic
            this.prescriptionId = GeneratePrescriptionId();
        }

        public static Prescription GetInstance(string medicationName, string dosage, string frequency, DateTime startDate, DateTime endDate)
        {
            if (instance == null)
            {
                instance = new Prescription(medicationName, dosage, frequency, startDate, endDate);
            }
            return instance;
        }

        // Generate unique prescriptionId logic
        private string GeneratePrescriptionId()
        {
            string generatedId = new Random().Next().ToString();
            return generatedId;
        }

    }
}
