using Lab04_Interfejsy.Animal_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy.Animals
{
    class Hamster : Animal, ICarnivores, IHerbivores
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Hamster");
        }

        public void EatTheMeat()
        {
            Console.WriteLine("The hamster is eating a spider.");
        }

        public void EatThePlant()
        {
            Console.WriteLine("The hamster is eating a sunflower seed.");
        }

        void IHerbivores.FindFood()
        {
            Console.WriteLine("The hamster found a sunflower feed.");
        }

        void ICarnivores.FindFood()
        {
            Console.WriteLine("The hamster found a spider.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
