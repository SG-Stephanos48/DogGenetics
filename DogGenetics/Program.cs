using System;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {

            string dogname;

            Console.WriteLine("What is your dog's name?");
            dogname = Console.ReadLine();

            Console.WriteLine("");

            Random random = new Random();

            int ShibaInu = random.Next(1, 50);
            int SiberianHusky = random.Next(1, 10);
            int SepalaSiberian = random.Next(1, 15);
            int Akita = random.Next(1, 20);
            int Chow = 100 - ShibaInu - SiberianHusky - SepalaSiberian - Akita;

            Console.WriteLine("Well then, I have this highly reliable report on " + dogname + "'s prestigious background right here.");
            Console.WriteLine("");
            Console.WriteLine(dogname + " is");
            Console.WriteLine("");
            Console.WriteLine(ShibaInu + "% Shiba Inu");
            Console.WriteLine(SiberianHusky + "% Siberian Husky");
            Console.WriteLine(SepalaSiberian + "% Sepala Siberian");
            Console.WriteLine(Akita + "% Akita");
            Console.WriteLine(Chow + "% Chow");
            Console.WriteLine("");
            Console.WriteLine("Wow, that's quite the dog!");

        }
    }
}
