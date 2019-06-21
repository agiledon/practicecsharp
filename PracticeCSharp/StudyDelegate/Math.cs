using System;
namespace PracticeCSharp.StudyDelegate
{
    public class Math
    {
        public int Add(int x, int y)
        {
            Console.WriteLine("add method");
            return x + y;
        }

        public int Substract(int x, int y)
        {
            Console.WriteLine("substract method");
            return x - y;
        }

        public int Multiple(int x, int y)
        {
            Console.WriteLine("multiple method");
            return x * y;
        }

        public double Divide(int x, int y)
        {
            Console.WriteLine("divide method");
            if (y == 0)
            {
                return 0;
            }

            return x / y;
        }
    }

    public delegate int Cal(int x, int y);


    public class Calculator
    {

        public int Calculate(int x, int y, Cal cal)
        {
            return cal.Invoke(x, y);
        }
    }
}
