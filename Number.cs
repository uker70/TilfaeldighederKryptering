using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TilfældighederKryptering
{
    class Number
    {
        private static Random rnd = new Random();

        //uses the RNGCryptoServiceProvider to get random values to byte array
        public static byte[] GetRngNumbers(int length)
        {
            byte[] random = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(random);
            }

            return random;
        }

        //uses Random to get random values to byte array
        public static byte[] GetRandomNumbers(int length)
        {
            byte[] random = new byte[length];

            rnd.NextBytes(random);

            return random;
        }
    }
}
