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
        public static DateTime time = DateTime.Now;

        public Burger()
        {

        }
        public Burger(string size, bool isDiet, string includingFoods,int kolori)
        {

            this.size = size;
            this.isDiet = isDiet;
            this.includingFoods = includingFoods;
            this.kolori = kolori;
        }

        public void Composition()
        {
            if (isDiet)
            {
                Console.WriteLine("Diet burger");
            }
            else
            {
                Console.WriteLine("NOT Diet");
            }
            Console.WriteLine($"Size is: {size}.");
            Console.WriteLine($"Burger contains: {includingFoods}");
            Console.WriteLine($"Koloris in burger:{kolori }");

            IFoodInclude obj = new Burger();                  //connect interface method, which have a body
            Console.WriteLine($"Price: {obj.Price(includingFoods,time)}");

        }
    }
}
