using System;

namespace labb18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Creature
    {
        public int Health { get; set; }
        public int Shield { get; set; }
        protected string Name { get; set; }

        public Creature(string name)
        {
            Name = name;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Health: {Health}, Shield: {Shield}, Name: {Name}");
        }
    }

    class Knight : Creature
    {
        protected string Weapon { get; set; }

        public Knight(string name, string weapon) : base(name)
        {
            Weapon = weapon;
        }
        public void Attack()
        {
            Console.WriteLine($"Knight {Name} attacks with {Weapon}");
        }
    }

    class Dragon : Creature
    {
        protected string Color { get; set; }

        public Dragon(string name, string color) : base(name)
        {
            Color = color;
        }
        public void Attack()
        {
            Console.WriteLine($"{Color} Dragon {Name} attacks with ice");
        }
    }
}
