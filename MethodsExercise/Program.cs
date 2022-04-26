using System;

namespace MethodsExercise
{
    internal class Program
    {
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


        static void Main(string[] args)
        {
            int num1;
            int num2;
            void 
            
            Console.WriteLine("Please enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The sum of the two numbers is " +Sum);
        }
    }
}
