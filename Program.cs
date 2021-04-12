using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Afternoon_4_5_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashing h = new Hashing();

            Console.WriteLine("Enter your string to hash.");

            string _input = Console.ReadLine();

            string s = h.ComputeSHA256Hash(_input);

            Console.WriteLine("The hash is: " + s);

            Console.ReadKey();







        }
    }
}
