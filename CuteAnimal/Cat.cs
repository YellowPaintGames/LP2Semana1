using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CuteAnimal;

namespace CuteAnimal
{
    public class Cat
    {
        private Random random;
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int energy;
        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                energy = Math.Clamp(value, 0, 100);
            }
        }
        public Feed FoodLevel
        {
            get;
            set;
        }
        public Mood MoodLevel
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{Name} is {FoodLevel} and {MoodLevel} with an energy value of {energy}";
        }

        public Cat(string name, Feed food, Mood mood)
        {
            Name = name;
            FoodLevel = food;
            MoodLevel = mood;
            energy = 21;
        }
        private Cat()
        {
            random = new Random();
        }
        public Cat(string name) : this()
        {
            Name = name;
            FoodLevel = (Feed)random.Next(5);
            MoodLevel = (Mood)random.Next(4);
            energy = random.Next(1, 21);
        }

    }
}