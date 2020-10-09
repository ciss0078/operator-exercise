using System;

namespace OperatorExercise
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int a, b, quotient, remainder;
            a = 17;
            b = 4;
            quotient = a / b;
            remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine();
            Console.WriteLine("Enter radius of a circle:");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of circle with radius of {radius} is {AreaOfCircle(radius)}");
            
            //Console.WriteLine($" enter radius:");
            //var radius = double.Parse(Console.ReadLine(r));
            //Console.WriteLine("Area of Circle is {0}, AreaOfCircle");

            

        }
        public static double AreaOfCircle(double r)
        {
            return (Math.PI * (r * r));
        }
        
    }
     
}
