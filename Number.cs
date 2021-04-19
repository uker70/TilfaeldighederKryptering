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

        public static byte[] GetRngNumbers(int length)
        {
            byte[] random = new byte[length];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(random);
            }

            return random;
        }

        public static byte[] GetRandomNumbers(int length)
        {
            byte[] random = new byte[length];

            rnd.NextBytes(random);

            return random;
        }
    }
}
