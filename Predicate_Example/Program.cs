using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predicate_Example
{
    internal class Program
    {

        public static bool CheckUpperCase(string data)
        {
            return data.Equals(data.ToUpper());
        }
        static void Main(string[] args)
        {
            Predicate<string> isUpper = CheckUpperCase;
            bool result = isUpper("KAUSHIK");
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
