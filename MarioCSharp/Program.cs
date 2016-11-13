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
            if ((CorrectNumberOfArguments(args)) && (ArgumentIsInCorrectRange(args)))
            {
                Console.WriteLine(args[1]);
            }
        }
        public bool CorrectNumberOfArguments(string[] args)
        {
            if (args.Length == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ArgumentIsInCorrectRange(string[] args)
        {
            if ((Convert.ToInt32(args[1]) > 0) && (Convert.ToInt32(args[1]) < 24))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
