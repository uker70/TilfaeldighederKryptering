using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TilfældighederKryptering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RNG Crypto Service Provider");
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(BitConverter.ToInt32(Number.GetRngNumbers(32), 0));
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed+"\n");
            timer.Reset();

            Console.WriteLine("Random Next");
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(BitConverter.ToInt32(Number.GetRandomNumbers(32), 0));
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);

            Console.WriteLine("\nCæsar kryptering");
            string test = Encryptor.Encrypt("AV");
            Console.WriteLine(test);
            test = Encryptor.Decryptor(test);
            Console.WriteLine(test);

            Console.ReadKey(true);
        }
    }
}
