using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperacion2
{
    class Class1
    {
        public static SqlConnection enlace = new SqlConnection(@"workstation id = MyEncuesta.mssql.somee.com; packet size = 4096; user id = Das7_SQLLogin_1; pwd=3l2jqiv7jq;data source = MyEncuesta.mssql.somee.com; persist security info=False;initial catalog = MyEncuesta");
    }
}
