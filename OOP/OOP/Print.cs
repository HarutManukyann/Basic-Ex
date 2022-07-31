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
            Console.WriteLine("________________________________");
            Console.WriteLine("Do you want DOUBLE CHEESE?");
            Console.WriteLine("1: YES!!");
            Console.WriteLine("2: NOO!!");
            int dch = Convert.ToInt32(Console.ReadLine()); // doubl cheese checking
            bool doubleCheese;
            if (dch == 1)
            {
               
                doubleCheese = true;
            }
            else
            {
                doubleCheese = false;
            }
            Console.WriteLine("________________________________");
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
            Console.WriteLine("________________________________");
            Console.WriteLine("ADD your comment");
            string comment = Console.ReadLine();
            Console.WriteLine("________________________________");

            string includingFoods = null;
            switch (choose)
            {
                case 1:

                    includingFoods = "Meat,Cheese" ;
                    Burger burger = new Burger(size, false, includingFoods, kolori,doubleCheese,comment);
                    burger.Composition();
                    break;
                case 2:
                    includingFoods = "Meat, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ";
                    Burger burger1 = new Burger(size, false, includingFoods, kolori,doubleCheese,comment);
                    burger1.Composition();
                    break;
                case 3:
                    includingFoods = "Cheese, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ";
                    Burger burger2 = new Burger(size, true,includingFoods , kolori,doubleCheese,comment);
                    burger2.Composition();
                    break;
                case 4:
                    includingFoods = "Meat";
                    Burger burgerMeat = new Burger(size, true, includingFoods, kolori,  doubleCheese,comment);
                    burgerMeat.Composition();
                    break;
                case 5:
                    includingFoods = "Meat,cheese, tomatoes, mushrooms, cucumbers, leaf lettuce, spinach ";
                    Burger burgerAll = new Burger(size, false,includingFoods , kolori,doubleCheese,comment);
                    burgerAll.Composition();
                    break;
                default:

                    break;
            }


        }
    }
}
