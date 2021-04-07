using Lab04_Interfejsy.Animal_Subclass;
using Lab04_Interfejsy.Animal_Subclass.Human_Compare;
using Lab04_Interfejsy.Animal_Subclass.Human_Subclass;
using Lab04_Interfejsy.Animals;
using Lab04_Interfejsy.Exceptions;
using System;
using System.Collections.Generic;

namespace Lab04_Interfejsy
{
    class Program
    {
        public static CommonCodeBase commonCodeBase = new CommonCodeBase();
        static void Main(string[] args)
        {
            try
            {
                Turtle turtle = new Turtle();
                commonCodeBase.AddAnimal(turtle, 73, 10, "Frank", "0km/h");
                Hamster hamster = new Hamster();
                commonCodeBase.AddAnimal(hamster, 1, 5, "Borys", "12km/h");
                Dog dog = new Dog();
                commonCodeBase.AddAnimal(dog, 12, 50, "Meggi", "48km/h");
                Cow cow = new Cow();
                commonCodeBase.AddAnimal(cow, 2, 140, "Siódemka", "40km/h");
            }
            catch (MyException ex)
            {
                ExceptionInfo.ShowException(ex);
            }

            Console.WriteLine("Draw animals.");
            commonCodeBase.DrawAnimals();
            Console.WriteLine("----------------");
            commonCodeBase.Move();
            Console.WriteLine("List all animals:");
            commonCodeBase.AnimalsToString();
            Console.WriteLine("----------------");
            Console.WriteLine("Feeding all herbivores:");
            commonCodeBase.FeedingAllHerbivores();
            Console.WriteLine("----------------");
            Console.WriteLine("Feeding all carnivores");
            commonCodeBase.FeedingAllCarnivores();
            Console.WriteLine("----------------");
            Console.WriteLine("Find by name 'Meggi':");
            commonCodeBase.FindAnimalByName("Meggi");
            Console.WriteLine("----------------");

            List<Human> people = new List<Human>();
            Human human = new Human
            {
                Name = "Natalia",
                Age = 21,
                Height = 163,
                Speed = "1 km/h",
                IQ = 200,
                Homes = new List<Home>
                {
                    new Home {
                        Area = 25,
                        Price = 700
                    },
                    new Home {
                        Area = 50,
                        Price = 1200
                    }
                },
                Cars = new List<Car>
                {
                    new Car {Model = "Opel", Price = 10000},
                    new Car {Model = "Dacia", Price = 20000},
                    new Car {Model = "Dacia", Price = 20000}
                }
            };
            Human human2 = new Human
            {
                Name = "Natalia_2",
                Age = 22,
                Height = 164,
                Speed = "2 km/h",
                IQ = 201,
                Homes = new List<Home>
                {
                    new Home {Area = 26,Price = 701},
                    new Home {Area = 26,Price = 701},
                    new Home {Area = 51,Price = 1201}
                },
                Cars = new List<Car>
                {
                    new Car {Model = "Opel", Price = 10001},
                    new Car {Model = "Dacia", Price = 20001}
                }
            };
            people.Add(human2);
            people.Add(human);
            people.Add(human2);

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
                item.ShowCarsAndHumans();
                Console.WriteLine("- - -");
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Browsing cars:");
            foreach (Car car in human)
                Console.WriteLine(car.Model);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Browsing houses: (limit - 1000)");
            foreach (Home home in human.GetTheHouses(1000))
                Console.WriteLine($"Area: {home.Area}, Price: {home.Price}");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Browsing houses: (no limit)");
            foreach (Home home in human.GetTheHouses())
                Console.WriteLine($"Area: {home.Area}, Price: {home.Price}");
            Console.WriteLine("---------------------------------");

            people.Sort();
            Console.WriteLine("Sort by IQ:");
            foreach (var item in people)
                Console.WriteLine($"{item.Name}, IQ: {item.IQ}");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine("Sort by number of cars:");
            people.Sort(new HumanCarComparer());
            foreach (var item in people)
                Console.WriteLine($"{item.Name}, number of cars: {item.Cars.Count}");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Sort by number of houses:");
            people.Sort(new HumanHouseComparer());
            foreach (var item in people)
                Console.WriteLine($"{item.Name}, number of houses: {item.Homes.Count}");
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Sort by money:");
            people.Sort(new MoneyHumanComparer());
            foreach (var item in people)
                Console.WriteLine($"Cars: {item.Cars.Count}, Houses: {item.Homes.Count}");
            Console.WriteLine("---------------------------------");

            try
            {
                Turtle turtle = new Turtle();
                commonCodeBase.AddAnimal(turtle, 73, 10, "Fr", "0km/h");
                Hamster hamster = new Hamster();
                commonCodeBase.AddAnimal(hamster, 1, 5, "Borys", "12000km/h");
            }
            catch (MyException ex)
            {
                ExceptionInfo.ShowException(ex);
            }
        }
    }
}
