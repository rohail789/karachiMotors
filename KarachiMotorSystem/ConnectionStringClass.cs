using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace KarachiMotorSystem
{
    public class ConnectionStringClass
    {

        public SqlConnection getDatabaseConnection()
        {

            string myconnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\hp\Documents\KarachiMotors.mdf;Integrated Security=True;";
            SqlConnection myconnection = new SqlConnection(myconnectionString);
            return myconnection;
        }
    }
}