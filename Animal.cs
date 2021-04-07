using System;

namespace Lab04_Interfejsy
{
    public abstract class Animal : Object
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public string Speed { get; set; }

        public abstract void Draw();

        public Animal()
        {
        }

        public Animal(string name, int age, float height, string speed)
        {
            Name = name;
            Age = age;
            Height = height;
            Speed = speed;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Height: {Height}, Speed: {Speed}";
        }
    }
}
