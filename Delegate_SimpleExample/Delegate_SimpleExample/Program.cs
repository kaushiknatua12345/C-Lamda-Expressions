using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_SimpleExample
{
    public delegate void CalculationHandler(Data data);
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data(50, 7);
            Calculation calculation = new Calculation();
            //Through delegates we can easily point to methods and create flexible framework
            //Once we create a delegate any method which matches the delegate signature can be called through delegate
            //Hence we can easily add more methods in business class (Calculation class) and do not have to make much
            //changes in client sidec(Program class) which gives the framework better flexibility
            CalculationHandler handler = new CalculationHandler(calculation.Add);
            handler += new CalculationHandler(calculation.Substract);
            handler += new CalculationHandler(calculation.Multiply);
            handler += new CalculationHandler(calculation.Divide);
            //handler(data);
            handler.Invoke(data);
            Console.ReadKey();
        }
    }
}
