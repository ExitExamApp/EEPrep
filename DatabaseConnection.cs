﻿using System;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace EEPrep
{
    public class DatabaseConnection
    {
       public static void MakeConnection()
            {
                String sqlServerLogin = "rephie0000";
                String password = "E5th3rdb@w0rk";
                String instanceName = "instance_name";
                String remoteSvrName = "https://p3nlmysqladm002.secureserver.net/grid55/5";

                // Connecting to an instance of SQL Server using SQL Server Authentication  
                Server srv1 = new Server(); // connects to default instance  
                srv1.ConnectionContext.LoginSecure = false; // set to true for Windows Authentication  
                srv1.ConnectionContext.Login = sqlServerLogin;
                srv1.ConnectionContext.Password = password;
                Console.WriteLine(srv1.Information.Version); // connection is established  
            }
      }
    
}