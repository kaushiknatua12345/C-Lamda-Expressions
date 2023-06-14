using System;
using System.Linq;


namespace LinqMethods_WithLamda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 15, 10, 4, 28, 1, 7,5 };

            Console.WriteLine("Greatest Number in array: " +numberArray.Max());
            Console.WriteLine("Small Number in array: " +numberArray.Min());

            //sort and display data in ascending manner. Display only sorted odd numbers
           var result=numberArray.
                                  Where(x => x %2!=0)
                                  .OrderBy(x => x).
                                  Select(x => x).ToList();


            Console.WriteLine("\nDisplay sorted data: ");
            foreach(var data in result)
            {
                Console.WriteLine(data);
            }


            Console.ReadKey();
                
           }
    }
}
