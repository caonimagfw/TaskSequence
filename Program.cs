using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSequence
{

    class Program
    {
        static AsyncHandle ah = new AsyncHandle();
        static void Main(string[] args)
        {

            for (int i = 0; i < 100; i++)
            {

                Console.BackgroundColor = ConsoleColor.Black;
                ah.OpenBoil(i.ToString());
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.WriteLine("Main Call End******");
            Console.ReadLine();
        }


    }
}
