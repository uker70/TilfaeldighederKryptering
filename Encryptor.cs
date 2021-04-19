using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TilfældighederKryptering
{
    class Encryptor
    {
        //encrypts the incoming string by moving each char 5 to the right
        public static string Encrypt(string input)
        {
            string output = "";

            foreach (char c in input.ToUpper())
            {
                //converts to short ascii and adds 5
                short tmp = Convert.ToInt16(c);
                tmp += 5;

                //makes sure the input is within the uppercase ascii value
                if (tmp > 90)
                {
                    tmp = (short)(64 + (tmp - 90));
                }

                //converts back to char and add it to the output string
                output += (char)tmp;
            }

            return output;
        }

        //decrypts the incoming string by moving each char 5 to the left
        public static string Decryptor(string input)
        {
            string output = "";

            //converts to short ascii and removes 5
            foreach (char c in input.ToUpper())
            {
                short tmp = Convert.ToInt16(c);
                tmp -= 5;

                //makes sure the input is within the uppercase ascii value
                if (65 > tmp)
                {
                    tmp = (short) (91 - (65 - tmp));
                }

                //converts back to char and add it to output string
                output += (char)tmp;
            }

            return output;
        }
    }
}
