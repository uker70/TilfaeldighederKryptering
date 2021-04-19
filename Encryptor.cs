using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfældighederKryptering
{
    class Encryptor
    {
        public static string Encrypt(string input)
        {
            string output = "";

            foreach (char c in input.ToUpper())
            {
                short tmp = Convert.ToInt16(c);
                tmp += 5;

                if (tmp > 90)
                {
                    tmp = (short)(64 + (tmp - 90));
                }

                output += (char)tmp;
            }

            return output;
        }

        public static string Decryptor(string input)
        {
            string output = "";

            foreach (char c in input.ToUpper())
            {
                short tmp = Convert.ToInt16(c);
                tmp -= 5;

                if (65 > tmp)
                {
                    tmp = (short) (91 - (65 - tmp));
                }

                output += (char)tmp;
            }

            return output;
        }
    }
}
