using HospitalManagementSystem.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BusinessLayer.Services
{
    public interface IPatientRepository
    {
        Patient GetById(int patientId);
        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(int patientId);
        List<Patient> GetAll();
    }
}
