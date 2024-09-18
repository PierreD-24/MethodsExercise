using System.Runtime.InteropServices;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShortStory();
            
            Console.WriteLine(Add(5,10));
            Console.WriteLine(Multiply(5,10));
            Console.WriteLine(Subtract(5,10));
            Console.WriteLine(Divide(5, 10));
        }

        static void ShortStory()
        {
             Console.WriteLine("Hello, what is your name?");

            string? userName = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");

            string? favoriteFood = Console.ReadLine();

            Console.WriteLine("What grocery store do you shop at?");

            string? groceryStore = Console.ReadLine();

            Console.WriteLine("What color are your shoes?");

            string? shoeColor = Console.ReadLine();

            Console.WriteLine($"There once was a person named {userName}.");
            Console.WriteLine($"Thier favorite food was {favoriteFood}.");
            Console.WriteLine($"{userName} went to {groceryStore} to buy {favoriteFood}.");
            Console.WriteLine($"Sadly {groceryStore} was all out of {favoriteFood}.");
            Console.WriteLine($"{userName} walked home in the rain and accidentally got mud on their {shoeColor} shoes.");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Divide(int a, int b)
        {
            return a / b;
        }

    }
}
