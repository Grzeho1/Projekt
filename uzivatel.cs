using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Text;

namespace Projekt
{
    internal class Uzivatel
    {
        static string login;
        static string heslo;
        static string noveheslo;

        public static string Login
        {
            
            get
            {
                return login;

            }
            set
            {
                login = value;
            }
        }
        

       
    }

    
}
