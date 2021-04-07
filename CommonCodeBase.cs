using Lab04_Interfejsy.Animal_Interfaces;
using Lab04_Interfejsy.Animals;
using Lab04_Interfejsy.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab04_Interfejsy
{
    class CommonCodeBase
    {
        public List<Animal> animals = new List<Animal>();
        public List<IHerbivores> herbivores = new List<IHerbivores>();
        public List<ICarnivores> carnivores = new List<ICarnivores>();

        public void Move()
        {
            foreach (var item in animals)
            {
                if (item is IHerbivores)
                {
                    herbivores.Add((IHerbivores)item);
                }
                if (item is ICarnivores)
                {
                    carnivores.Add((ICarnivores)item);
                }
            }
        }

        public CommonCodeBase() { }

        public void DrawAnimals()
        {
            foreach (var item in animals)
            {
                item.Draw();
            }
        }

        public void AnimalsToString()
        {
            foreach (var item in animals)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void FindAnimalByName(String name)
        {
            foreach (var item in animals)
            {
                if(item.Name.Contains(name))
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public void HerbivoresToString()
        {
            foreach (var item in herbivores)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void CarnivoresToString()
        {
            foreach (var item in carnivores)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void AddAnimal(Animal animal, int age, float height, string name, string speed)
        {
            animal.Speed = speed;
            animal.Name = name;
            animal.Height = height;
            animal.Age = age;
            if (animal.Name.Length < 3)
            {
                throw new MyException($"The name cannot contain less than 3 characters.");
            }
            else if (int.Parse(animal.Speed.Substring(0, animal.Speed.Length - 4)) > 1225)
            {
                throw new MyException($"The animal cannot be faster than sound.");
            }
            else
            {
                animals.Add(animal);
            }
        }

        public void FeedingAllHerbivores()
        {
            foreach (var item in herbivores)
            {
                item.FindFood();
                item.EatThePlant();
            }
        }

        public void FeedingAllCarnivores()
        {
            foreach (var item in carnivores)
            {
                item.FindFood();
                item.EatTheMeat();
            }
        }

        public void FeedingOneHerbivore(IHerbivores herbivore)
        {
            herbivore.FindFood();
            herbivore.EatThePlant();
        }

        public void FeedingOneCarnivore(ICarnivores carnivore)
        {
            carnivore.FindFood();
            carnivore.EatTheMeat();
        }
    }
}
