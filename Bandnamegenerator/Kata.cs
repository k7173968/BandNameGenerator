using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandnamegenerator
{
    class Kata
    {
        public static string BandNameGenerator(string str)
        {
            if (str == null || str.Length==1)
                return "";
            if (Equals(str.First(), str.Last()))
            {
                return str.First().ToString().ToUpper() + str.Substring(1) + str.Substring(1);
            }
            else
            {
                return "The " + str.First().ToString().ToUpper() + str.Substring(1);
            }
        }
    }
}
