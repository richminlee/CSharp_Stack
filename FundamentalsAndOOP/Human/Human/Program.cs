using System;

namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get 
            {
                return health;
            }
        }
        public Human(string nam)
        {
            Name = nam;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string nam, int str, int intel, int dex, int heal)
        {
            Name = nam;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = heal;
        }
        public int Attack(Human target)
        {
            int dmg = 5* this.Strength;
            target.health -= dmg;
            if(target.health <= 0)
            {
                target.health = 0;
            }
            return target.health;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Human tag = new Human("Richard",100,100,100,1000);
            Human min = new Human("Minion");
            Console.WriteLine($"{tag.Name} has {tag.Strength} Strength, {tag.Intelligence} Intelligence, {tag.Dexterity} Dexterity & {tag.Health} Health");
            Console.WriteLine($"{min.Name} has {min.Strength} Strength, {min.Intelligence} Intelligence, {min.Dexterity} Dexterity & {min.Health} Health");
            min.Attack(tag);
            Console.WriteLine($"{tag.Name} has {tag.Health} health left!");
            tag.Attack(min);
            Console.WriteLine($"{min.Name} has {min.Health} health left!");
        }
    }
}
