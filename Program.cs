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
                    //TODO write the rest of the code in this code block
                    //while i is 0 and while its less than 8
                    for (int i = 0; i < Convert.ToInt32(args[0]); i++)
                    {
                        //y is 8-1=7, while y >0
                        for (int y = (Convert.ToInt32(args[0]) - 1); y > 0; y--)
                        {
                            Console.WriteLine(" ");
                        }
                        for (int j = i; j < Convert.ToInt32(args[0]); j++)
                        {
                            Console.WriteLine("#");
                        }
                        Console.WriteLine("\n");
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
