using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Oracle_Connection
{
    static class Secret
    {
        public static string GetConnString()
        {
            return  "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=feenix-oracle.swin.edu.au)(PORT=1521))" +
                    "(CONNECT_DATA=(SERVICE_NAME=DMS)));" +
                    "User Id=tbaird;Password=myPassword;";

             /*
             * Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=MyHost)(PORT=MyPort))
             * (CONNECT_DATA=(SERVICE_NAME=MyOracleSID)));User Id=myUsername;Password=myPassword;
             */
        }

    }
}
