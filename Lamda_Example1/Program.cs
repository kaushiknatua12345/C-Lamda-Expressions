using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int,int,int> sum=(x,y) => x + y;
            Console.WriteLine("Addition of Two Numbers= "+sum(10,20));

            Action<int,int> multiplication=(x,y)=>Console.WriteLine("\nMultiplication Result: "+x*y);
            multiplication(10,5);
            Console.ReadKey();
        }
    }
}
