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
            
        }
    }
}
