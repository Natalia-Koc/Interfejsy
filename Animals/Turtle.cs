using Lab04_Interfejsy.Animal_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy.Animals
{
    class Turtle : Animal, IHerbivores, ICarnivores
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Turtle");
        }

        public void EatTheMeat()
        {
            Console.WriteLine("The trutle is eating the meat.");
        }

        public void EatThePlant()
        {
            Console.WriteLine("The trutle is eating the plant.");
        }

        void IHerbivores.FindFood()
        {
            Console.WriteLine("The trutle found plant.");
        }

        void ICarnivores.FindFood()
        {
            Console.WriteLine("The trutle found meat.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
