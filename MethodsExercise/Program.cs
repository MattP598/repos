using System;

namespace MethodsExercise
{
    public class Exercises
    {
        public static int GetNumbers()
        {
            Console.WriteLine("Please enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
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