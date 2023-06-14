using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Delegate
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            AdditionEx ex= new AdditionEx();
            int result = ex.addition(10, 20);
            Console.WriteLine("Addition Result= "+result);

            Console.WriteLine("Multiplication Result= " + ex.dmultiply(5,7));
            Console.ReadLine();
        }
    }
}
