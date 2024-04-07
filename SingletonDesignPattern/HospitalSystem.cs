using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class HospitalSystem
    {
        private static HospitalSystem instance;
        private List<Hospital> hospitals;

        private HospitalSystem()
        {
            hospitals = new List<Hospital>();
        }

        public static HospitalSystem GetInstance()
        {
            if (instance == null)
            {
                instance = new HospitalSystem();
            }
            return instance;
        }

        public void AddHospital(Hospital hospital)
        {
            hospitals.Add(hospital);
        }

        public void RemoveHospital(Hospital hospital)
        {
            hospitals.Remove(hospital);
        }

        public List<Hospital> GetHospitals()
        {
            return hospitals;
        }
    }
}
