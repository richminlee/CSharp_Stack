using System;

namespace DojoDachi.Models
{
    public class Dachi
    {
        public int Fullness{get; set;}
        public int Happiness{get; set;}
        public int Energy{get; set;}
        public int Meals{get; set;}
        public string Message{get; set;}
        public Dachi()
        {
            Fullness = 20;
            Happiness = 20;
            Energy = 50;
            Meals = 3;
            Message = "Welcome to Dojodachi! Where you learn to raise a pet!";
        }
        public Dachi(int full, int happ, int ener, int meal, string mess)
        {
            Fullness = full;
            Happiness = happ;
            Energy = ener;
            Meals = meal;
            Message = mess;
        }
    }
}