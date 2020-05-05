using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy; 
        public bool IsSweet; 
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string nam, int cal, bool spcy, bool swt)
        {
            Name = nam;
            Calories = cal;
            IsSpicy = spcy;
            IsSweet = swt;
        }
    }
    class Buffet
    {
        public List<Food> Menu;
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Chicken", 200, true, true),
                new Food("Beef", 500, false, true),
                new Food("Pork", 600, true, true),
                new Food("Fish", 400, true, false),
                new Food("Rice", 500, false, false),
                new Food("Noodles", 600, false, true),
                new Food("Soup", 100, false, false)
            };
        }
        
        public Food Serve()
        {
            int foodie = 0;
            Random rand = new Random();
                foodie = rand.Next(0,6);
                return Menu[foodie];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public void Eat(Food item)
        {

            if (IsFull == false)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                if (item.IsSpicy == true && item.IsSweet == true)
                {
                    Console.WriteLine($"{item.Name} is Sweet and Spicy!!!");
                }
                else if (item.IsSpicy == true)
                {
                    Console.WriteLine($"{item.Name} is Spicy!!!");
                }
                else if (item.IsSweet == true)
                {
                    Console.WriteLine($"{item.Name} is Sweet!!!");
                }
                else
                {
                    Console.WriteLine($"{item.Name} is not Sweet or Spicy!!!");
                }
            }
            if (IsFull == true)
            {
                Console.WriteLine("You are Full and cannot eat anymore!!!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Buffet country = new Buffet();
            Ninja Richard = new Ninja();
            Food meal1=country.Serve();
            Richard.Eat(meal1);
            Food meal2=country.Serve();
            Richard.Eat(meal2);
            Food meal3=country.Serve();
            Richard.Eat(meal3);
            Food meal4=country.Serve();
            Richard.Eat(meal4);
        }
    }
}
