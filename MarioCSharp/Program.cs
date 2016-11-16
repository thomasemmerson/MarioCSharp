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
                    Console.WriteLine("You passed.");
                    //TODO write the rest of the code in this code block
                    for (int i = 0; i < intarg = Convert.ToInt32(args[0]); i++)
                    {
                        for (int y = ConvertToInt(args[0]); y > 0; y--)
                        {
                            Console.WriteLine(" ");
                        }
                        for 
                        Console.WriteLine("#\n");
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
