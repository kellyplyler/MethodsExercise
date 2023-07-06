using System;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Are you a man or a woman?");
            string gender = Console.ReadLine();
            Console.WriteLine("Where do you live?");
            string location = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"{name} is a {gender} who lives in {location} with their pet {animal} in a {color} house.");
            Console.WriteLine("Give me a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine("Give me a number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to multiply with the first number");
            int num4 = int.Parse(Console.ReadLine());

            int product = Multiply(num3, num4);
            Console.WriteLine($"The product is {product}");
            Console.WriteLine("Give me a number");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to divide from the first number");
            int num6 = int.Parse(Console.ReadLine());

            int division = Divide(num5, num6);
            Console.WriteLine($"The answer is {division}");
            Console.WriteLine("Give me another number");
            int num7 = int.Parse(Console.ReadLine()) ;
            Console.WriteLine("Give me a number to subtract from the first number");
            int num8 = int.Parse(Console.ReadLine() );
            int subtract = Subtract(num7, num8);
            Console.WriteLine($"The answer is {subtract}");

        }

        public static int Sum(int num1, int num2)
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
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
