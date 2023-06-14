using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_With_Lamda_And_Linq
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Use Delegate+Linq+Lamda for display filtered even data from array in Descending manner
            int[] numberArray = { 7, 4, 18, 9, 28, 12, 11, 10, 5, 6 };

            Console.WriteLine("\nDisplay Data Before Filter and Sort: ");
            foreach (var data in numberArray)
            {
                Console.WriteLine(data);
            }

            Func<int[], int[]> calc = (int[] arg)=>           

                    arg.Where(x => x % 2 == 0)
                   .OrderByDescending(x => x)
                   .Select(x => x).ToArray();

            Console.WriteLine("\nDisplay Sorted Even Data: ");
            foreach(var data in calc(numberArray))
            {
                Console.WriteLine(data);
            }
        }        
    }
}
