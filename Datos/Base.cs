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
        public SqlConnection conn = new SqlConnection(@"Server=tcp:academianet.database.windows.net,1433;Initial Catalog = academia2; Persist Security Info=False;User ID = netadmin; Password=Qwer1234; MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30;");
    }
}
