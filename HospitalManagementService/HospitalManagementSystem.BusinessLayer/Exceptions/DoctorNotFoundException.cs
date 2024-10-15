using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.BusinessLayer.Exceptions
{
    public class DoctorNotFoundException : ApplicationException
    {
        public DoctorNotFoundException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
