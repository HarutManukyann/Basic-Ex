using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Burger : IFoodInclude
    {

        public string size;
        public bool isDiet;
        public string includingFoods;
        public int kolori;
        public bool doubleCheese;
        public string comment;
        public static DateTime time = DateTime.Now;

        public Burger()
        {

        }
        public Burger(string size, bool isDiet, string includingFoods, int kolori, bool doubleCheese,string comment)
        {

            this.size = size;
            this.isDiet = isDiet;
            this.includingFoods = includingFoods;
            this.kolori = kolori;
            this.doubleCheese = doubleCheese;
            this.comment = comment;
        }

        public void Composition()
        {
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine($"Burger contains: {includingFoods}");
            if (doubleCheese)
            {
                Console.WriteLine($"Double Cheese:Yes! (price + 400)");
            }
            else
            {
                Console.WriteLine($"Double Cheese:NO!");
            }

            Console.WriteLine($"Size is: {size}.");
            Console.WriteLine($"Koloris in burger:{kolori }");
            
            if (isDiet)
            {
                Console.WriteLine("Diet burger");
            }
            else
            {
                Console.WriteLine("NOT Diet");
            }
            Console.WriteLine("Youe Comment:");
            Console.WriteLine("------------------------");
            Console.WriteLine(comment);
            Console.WriteLine("------------------------");

            IFoodInclude obj = new Burger();                  //connect interface method, which have a body
            Console.WriteLine($"Price: {obj.Price(includingFoods, time, doubleCheese,size)}");

        }
    }
}
