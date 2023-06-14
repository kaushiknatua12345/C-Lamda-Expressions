using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action_Delegate
{    
    internal class Program
    {
        private static int result;
        public static void Multiplication(int number1,int number2)
        {
            result = number1 * number2;
        }
        static void Main(string[] args)
        {
            Action<int, int> multiply = Multiplication;
            multiply(10, 5);
            Console.ReadKey();
        }
    }
}
