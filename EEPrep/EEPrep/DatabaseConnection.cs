using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public class DatabaseConnection 
    {
        //private string connectionString = "server = Reph;" + "user id = admin;" +
          //                              "persistsecurityinfo=True;" + "database=examdb";
        private ConnectionState connState;
        private String currentDB;
        private String connectionString;
        // sql connection
        private SqlConnection conn;

        public DatabaseConnection()
        {
        }

        public DatabaseConnection(string providerName)
        {
            connState = ConnectionState.Closed;
            //Configuration Manager
            ConnectionStringSettingsCollection connStrings = ConfigurationManager.ConnectionStrings;

            if (connStrings != null)
            {
                // search for provider name that matches this nametype
                foreach (ConnectionStringSettings connString in connStrings)
                {
                    if (connString.ProviderName == providerName)
                    {
                        connectionString = connString.ConnectionString;
                        break;
                    }
                }
            }
            // create the connection
            conn = new SqlConnection(this.connectionString);
        }

        public void OpenConnection()
        {
            conn.Open();
            // TODO(reph): check the state, add code to close, create command
             
        }
        public static void MakeConnection()
        {

        }

        //Purpose: Creates an instance of a command object
        //Requires: nothing
        //Returns: an instance of a command object
        public IDbCommand CreateCommand()
        {
            IDbCommand result = new SqlCommand();
            result.Connection = conn;
            return result;
        }
         

          
     }
 }
    
