namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ExerciseOne();
            
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.Write(AreaOfCircle(radius));

        }

        public static void ExerciseOne()
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                 Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            }
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
        
    }
}
