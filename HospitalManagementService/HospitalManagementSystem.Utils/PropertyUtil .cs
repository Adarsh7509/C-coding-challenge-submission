using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Configuration.Assemblies;

namespace HospitalManagementSystem.Utils
{
    public class PropertyUtil
    {
        public static string GetConnectionString() => System.Configuration.ConfigurationManager.ConnectionStrings["HospitalManagementSystem"].ConnectionString;
    }
}



