using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToUnitTesting
{
    public class MathExercises : IMathExercises
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Multiply(int numA, int numB)
        {
            int result = numA * numB;
            return result;
        }

        public int Subtract(int a, int b)
        {
            int result = a - b +1;
            Console.WriteLine("Weeeee");

            Console.WriteLine("Yiiihaaaa");
            return result;
        }

    }
}
