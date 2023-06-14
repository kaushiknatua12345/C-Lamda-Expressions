using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_SimpleExample
{
    public class Calculation
    {
        public void Add(Data data)
        {
            Console.WriteLine("Sum of two numbers: " + (data.Number1 + data.Number2));
        }
        public void Substract(Data data)
        {
            Console.WriteLine("Substraction of two numbers: " +
                (data.Number1 > data.Number2 ?
                (data.Number1 - data.Number2) : (data.Number2 - data.Number1)));
        }
        public void Multiply(Data data)
        {
            Console.WriteLine("Multiplication of two numbers: " + (data.Number1 * data.Number2));
        }
        public void Divide(Data data)
        {
            if (data.Number2 == 0)
                throw new ArithmeticException("Number can not be divided by zero");
            Console.WriteLine("Division of two numbers: "+
                 data.Number1 / data.Number2);

        }
    }
}
