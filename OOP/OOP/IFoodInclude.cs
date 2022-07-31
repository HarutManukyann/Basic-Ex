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
        public static string includingFoods { get; set; }
        public static DateTime time = new DateTime();


        public void Composition();
        public int Price(string includingFoods, DateTime time)
        {
            int price = 850;
            if (includingFoods.ToLower().Contains("cheese"))
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
            return price;


        }
    }
}
