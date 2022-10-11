using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace Projekt
{
    internal class Uzivatel
    {
        static string login;

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
        public static string Heslo { get; set; }
    }
}
