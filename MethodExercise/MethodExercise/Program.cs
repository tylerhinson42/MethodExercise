using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"Your fav color is {favoriteColor}");


            Console.WriteLine("What is your name?");
            var fullName = Console.ReadLine();

            Console.WriteLine($"Your full name is {fullName}");


            Console.WriteLine("What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"Your favorite animal is {favoriteAnimal}");


            Console.WriteLine("What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Your favorite band is {favoriteBand}");



        }
    }
}
