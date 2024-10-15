using HospitalManagementSystem.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BusinessLayer.Services
{
    public interface IAppointmentRepository
    {
        Appointment GetById(int appointmentId);
        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(int appointmentId);
        List<Appointment> GetAll();
        List<Appointment> GetByPatientId(int patientId);
        List<Appointment> GetByDoctorId(int doctorId);
    }
}
