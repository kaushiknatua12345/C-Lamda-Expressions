using System;

/* public delegate TResult Func<int T, out TResult>(T arg);   */

namespace Function_Delegate
{
    internal class AdditionEx
    {
        public static int Add(int number1, int number2)
        {
           return number1 + number2;
        }

        public static int Multiply(int number1,int number2)
        {
            return number1*number2;
        }
       

        public Func<int, int, int> addition = Add;

        public Func<int,int,int> dmultiply = Multiply;
        
    }
}
