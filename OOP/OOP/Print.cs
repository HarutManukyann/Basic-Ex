using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Print
    {

        public void PrintConsol()
        {
            Console.WriteLine("Choose includings:");
            Console.WriteLine("1: Meat + Cheese");
            Console.WriteLine("2: Meat + Vegetables");
            Console.WriteLine("3: Cheese + Vegetables");
            Console.WriteLine("4: Only Meat");
            Console.WriteLine("IF YOU Want All press 5:");
            int choose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write Burger size:");
            Console.WriteLine("SMALL | MEDIUM | BIG");
            string size = Console.ReadLine();
            int kolori = 0;
            if (size.ToLower().Contains("small"))
            {
                kolori = 240;
            }
            else if (size.ToLower().Contains("medium"))
            {
                kolori = 280;
            }
            else if (size.ToLower().Contains("big"))
            {
                kolori = 320;
            }

            switch (choose)
            {
                case 1:
                    Burger burger = new Burger(size, false, "Meat, Cheese", kolori);
                    burger.Composition();
                    break;
                case 2:
                    Burger burger1 = new Burger(size, false, "Meat, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ", kolori);
                    burger1.Composition();
                    break;
                case 3:
                    Burger burger2 = new Burger(size, true, "Cheese, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ", kolori);
                    burger2.Composition();
                    break;
                case 4:
                    Burger burgerMeat = new Burger(size, true, "Meat", kolori);
                    burgerMeat.Composition();
                    break;
                case 5:
                    Burger burgerAll = new Burger(size, false, "Meat,cheese, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ", kolori);
                    burgerAll.Composition();
                    break;
                default:
                    break;
            }
               
               
        }
    }
}
