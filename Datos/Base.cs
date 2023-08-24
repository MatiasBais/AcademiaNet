using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Base
    {
        public SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=academia;Trusted_Connection=True;");
    }
}
