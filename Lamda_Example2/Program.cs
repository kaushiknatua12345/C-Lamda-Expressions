using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                10,15,14,2,18,20,21,84,72,49
            };

            //Display the max and min number
            Console.WriteLine("Max Value: "+numbers.Max());
            Console.WriteLine("\nMin Value: " + numbers.Min());

            //Display even data in descending manner
            //chaning of methods using Lamda Expression
            Console.WriteLine("\nDisplay data in desc manner where data is even:");
            List<int> result=numbers
                                    .Where(x=>x%2==0)
                                    .OrderByDescending(x=>x)
                                    .Select(x=>x).ToList();
            foreach (var data in result)
                Console.WriteLine(data);
            
                                    
            Console.ReadKey();

           
        }
    }
}
