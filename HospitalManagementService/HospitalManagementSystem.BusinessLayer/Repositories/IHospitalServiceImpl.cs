using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BusinessLayer.Services
{
    public interface IHospitalServiceImpl
    {
        void ViewAppointmentById();
        void ViewAppointmentsForPatient();
        void ViewAppointmentsForDoctor();
        void ScheduleAppointment();
        void UpdateAppointment();
        void CancelAppointment();
    }
}
