using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AndromedaV1
{
    class Utils
    {
        private static Random random = new Random();

        public static string RandomChar(int charcase)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz$^ù*!:;/§/.,£$";
            return new string(Enumerable.Repeat(chars, charcase)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
