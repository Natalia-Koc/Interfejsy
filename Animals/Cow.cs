using Lab04_Interfejsy.Animal_Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy.Animals
{
    class Cow : Animal, IHerbivores
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a cow");
        }

        public void EatThePlant()
        {
            Console.WriteLine("The cow is eating fruit.");
        }

        void IHerbivores.FindFood()
        {
            Console.WriteLine("The cow found fruit.");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
