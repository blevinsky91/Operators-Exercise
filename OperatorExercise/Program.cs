﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine(ExerciseOne);
        }

        public static void ExerciseOne()
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                 Console.WriteLine($"{quotient} is {b} {remainder} 1");
            }
        }
        
    }
}
