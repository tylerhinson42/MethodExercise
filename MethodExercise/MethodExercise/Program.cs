﻿using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var fullName = Console.ReadLine();

            Console.WriteLine($"Your full name is {fullName}");

            Console.WriteLine($"Hi, {fullName}, what is your favorite color?");
            var favoriteColor = Console.ReadLine();

            Console.WriteLine($"{favoriteColor} is an awesome color! What is your favorite animal?");
            var favoriteAnimal = Console.ReadLine();

            Console.WriteLine($"Awesome, your favorite animal is {favoriteAnimal}");

            Console.WriteLine("What is your favorite band?");
            var favoriteBand = Console.ReadLine();

            Console.WriteLine($"Sweet, love it. Your favorite band is {favoriteBand}");

            AddNumbers(2, 4);
            Console.WriteLine(AddNumbers(2, 4));
            Console.WriteLine(Product(10, 2));

        }

        public static int AddNumbers(int x, int y)
        {
            return x + y;

        }

        public static int Product(int a, int b)
        {
            return a * b;

        }
           

       
        


    }

}
