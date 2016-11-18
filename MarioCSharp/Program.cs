using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarioCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                if ((Convert.ToInt32(args[0]) > 0) && (Convert.ToInt32(args[0]) < 24))
                {
                    for (int j = 0; j < Convert.ToInt32(args[0]); j++)
                    {
                        for (int i = j; i < Convert.ToInt32(args[0]); i++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = (Convert.ToInt32(args[0]) - (j+1)); k < Convert.ToInt32(args[0]); k++)
                        {
                            Console.Write("#");
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("You must only enter a number that's between 1 and 23.");
                }
            }
            else
            {
                Console.WriteLine("You must only enter one argument.");
            }
        }
    }
}
