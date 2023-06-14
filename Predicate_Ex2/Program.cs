using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Ex2
{
    internal class Program
    {
        public static bool CheckEvenNumber(int arg) { 
        return arg % 2 == 0? true: false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int value=int.Parse(Console.ReadLine());

            Predicate<int> check = CheckEvenNumber;
            bool result=check(value);
            Console.WriteLine("\nResult is: " + result);
            Console.ReadKey();
        }
    }
}
