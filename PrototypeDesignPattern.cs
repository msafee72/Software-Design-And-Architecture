using System;
using System.Collections.Generic;

public class HospitalSystem
{
    private List<Hospital> hospitals;

    public HospitalSystem()
    {
        hospitals = new List<Hospital>();
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

public class Hospital : ICloneable
{
    public string Name { get; }
    public string Location { get; }
    private List<Department> departments;

    public Hospital(string name, string location)
    {
        Name = name;
        Location = location;
        departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        departments.Add(department);
    }

    public object Clone()
    {
        return new Hospital(Name, Location);
    }
}

public class Department : ICloneable
{
    public string Name { get; }
    private List<Doctor> doctors;

    public Department(string name)
    {
        Name = name;
        doctors = new List<Doctor>();
    }

    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    public object Clone()
    {
        return new Department(Name);
    }
}

public class Doctor : ICloneable
{
    public string Name { get; }
    public string Specialization { get; }

    public Doctor(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }

    public object Clone()
    {
        return new Doctor(Name, Specialization);
    }
}

public class Patient : ICloneable
{
    public string Name { get; }
    public int Age { get; }
    public string Gender { get; }
    public string MedicalHistory { get; }
    private List<Prescription> prescriptions;

    public Patient(string name, int age, string gender, string medicalHistory)
    {
        Name = name;
        Age = age;
        Gender = gender;
        MedicalHistory = medicalHistory;
        prescriptions = new List<Prescription>();
    }

    public object Clone()
    {
        return new Patient(Name, Age, Gender, MedicalHistory);
    }
}

public class Prescription : ICloneable
{
    public string MedicationName { get; }
    public string Dosage { get; }
    public string Frequency { get; }
    public DateTime StartDate { get; }
    public DateTime EndDate { get; }

    public Prescription(string medicationName, string dosage, string frequency, DateTime startDate, DateTime endDate)
    {
        MedicationName = medicationName;
        Dosage = dosage;
        Frequency = frequency;
        StartDate = startDate;
        EndDate = endDate;
    }

    public object Clone()
    {
        return new Prescription(MedicationName, Dosage, Frequency, StartDate, EndDate);
    }
}
