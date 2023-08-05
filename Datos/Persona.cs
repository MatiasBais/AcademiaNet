using System;
using System.Configuration;

namespace Datos
{
    public class Persona
    {
        string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionStringKey"].ConnectionString;



    }
}
