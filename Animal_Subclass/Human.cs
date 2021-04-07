using Lab04_Interfejsy.Animal_Subclass.Human_Subclass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab04_Interfejsy.Animal_Subclass
{
    class Human : Animal, IEnumerable<Car>, ICloneable, IComparable<Human>
    {
        public int IQ { get; set; }
        public List<Car> Cars;
        public List<Home> Homes;

        public Human()
        {
            Cars = new List<Car>();
            Homes = new List<Home>();
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a human");
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in Cars)
            {
                yield return item;
            }
        }
        public IEnumerator<Car> GetEnumerator()
        {
            return Cars.GetEnumerator();
        }
        public IEnumerable GetTheHouses(int limit=0)
        {
            foreach (var item in Homes)
            {
                if(item.Price > limit)
                    yield return item;
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(Human other)
        {
            return this.IQ.CompareTo(other.IQ);
        }
        public void ShowCarsAndHumans()
        {
            Console.WriteLine("Cars:");
            foreach (var item in Cars)
                Console.WriteLine($"{item.Model}, price: {item.Price}");
            Console.WriteLine("Houses:");
            foreach (var item in Homes)
                Console.WriteLine($"Area: {item.Area}, price: {item.Price}");
        }
    }
}
