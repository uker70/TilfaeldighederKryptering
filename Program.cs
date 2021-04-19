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
            //calls the methods for RNG and Random numbers providers an shows the result
            Console.WriteLine("RNG Crypto Service Provider");

            //time to see how long it took to get the numbers
            Stopwatch timer = new Stopwatch();
            timer.Start();

            //gets 10 numbers from RNG
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(BitConverter.ToInt32(Number.GetRngNumbers(32), 0));
            }

            //stops timer and shows how long it took and then resets the timer
            timer.Stop();
            Console.WriteLine(timer.Elapsed+"\n");
            timer.Reset();

            Console.WriteLine("Random Next");

            //starts the timer again and gets 10 numbers from Random
            timer.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(BitConverter.ToInt32(Number.GetRandomNumbers(32), 0));
            }

            //stops timer and shows how long it took
            timer.Stop();
            Console.WriteLine(timer.Elapsed);

            //calls the methods for Cæsar kryptering and shows the result
            Console.WriteLine("\nCæsar kryptering");
            string test = Encryptor.Encrypt("AV");
            Console.WriteLine(test);
            test = Encryptor.Decryptor(test);
            Console.WriteLine(test);

            Console.ReadKey(true);
        }
    }
}
