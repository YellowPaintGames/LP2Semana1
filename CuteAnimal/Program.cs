using System;

namespace CuteAnimal
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Cat cat = new Cat("Big Bernard");
            Cat cat2 = new Cat("Big Bertha", Feed.AboutToExplode, Mood.HyperActive);
            Console.WriteLine(cat);
            Console.WriteLine(cat2);
        }
    }
}
