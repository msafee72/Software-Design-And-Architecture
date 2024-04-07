using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal sealed class Hospital
    {
        private static Hospital instance;
        private string hospitalId;
        private string name;
        private string location;
        private List<Department> departments;

        private Hospital(string name, string location)
        {
            this.name = name;
            this.location = location;
            this.hospitalId = GenerateHospitalId();
            this.departments = new List<Department>();
        }

        public static Hospital GetInstance(string name, string location)
        {
            if (instance == null)
            {
                instance = new Hospital(name, location);
            }
            return instance;
        }

        private string GenerateHospitalId()
        {
            string id = new Random().Next().ToString();
            return id;
        }

        public string GetId()
        {
            return hospitalId;
        }

        public string GetName()
        {
            return name;
        }

        public string GetLocation()
        {
            return location;
        }

        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        public void RemoveDepartment(Department department)
        {
            departments.Remove(department);
        }

        public List<Department> GetDepartments()
        {
            return departments;
        }
    }
}
