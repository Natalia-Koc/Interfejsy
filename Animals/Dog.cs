using Lab04_Interfejsy.Animal_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy.Animals
{
    class Dog : Animal, ICarnivores, IHerbivores
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a dog.");
        }

        public void EatTheMeat()
        {
            Console.WriteLine("The dog is eating a ham.");
        }

        public void EatThePlant()
        {
            Console.WriteLine("The dog is eating an apple.");
        }

        void IHerbivores.FindFood()
        {
            Console.WriteLine("The dog found the apple.");
        }

        void ICarnivores.FindFood()
        {
            Console.WriteLine("The dog found a ham.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
