using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public interface IFoodInclude
    {
        public static int price { get; set; }
        public static string size { get; set; }
        public static bool isDiet { get; set; }
        public static int kalori { get; set; }
        public static string[] food = new string[7] { "Meat", "Cheese", "Tomatoes", "Mushrooms", "Cucumbers", "Leaf lettuce", "Spinach " };
        public static string includingFoods { get; set; }
        public static DateTime time = new DateTime();


        public void Composition();
        public int Price(string includingFoods, DateTime time,bool doubleCheese,string size)
        {
            int price = 850;
            int cheeseCount = 0;
            if (doubleCheese)
            {
                cheeseCount = 2;
            }
            else
            {
                cheeseCount = 1;
            }

            if (cheeseCount ==2)
            {
                Console.WriteLine("Cheese: +900");
                price += 900;
            }
            if (cheeseCount == 1)
            {
                Console.WriteLine("Cheese: +500");
                price += 500;
            }
            if (includingFoods.ToLower().Contains("meat"))
            {
                Console.WriteLine("Meat: +1000");
                price += 1000;
            }
            time = DateTime.Now;
            Console.WriteLine($"Burger's Date :  {time}");
            if (size.ToLower().Contains("medium"))
            {
                price += 250;
            }
            else if (size.ToLower().Contains("big"))
            {
                price += 500;
            }
            return price;


        }
    }
}
