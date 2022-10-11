using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt
{
    internal class uzivatel
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
    }
}
