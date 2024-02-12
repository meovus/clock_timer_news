using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock_Timer
{
    internal class DbConnectionString
    {

        public static string connstring = System.IO.File.ReadAllText(@"D:\dbconnectionstring.txt");


    }
}
