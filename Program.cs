using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator_HW
{
    class Program
    {
        static void Main(string[] args)
        {
           /*    Beverage theBeverage = new Espresso();
            Console.WriteLine(theBeverage.getDescription() + "$" + theBeverage.cost());
            Console.ReadKey();

            Beverage theBeverage2 = new Espresso();
            theBeverage2 = new Mocha(theBeverage2);
            theBeverage2 = new Mocha(theBeverage2);
            
            Console.WriteLine(theBeverage2.getDescription() + "$" + theBeverage2.cost());
            Console.ReadKey();
            */
            int choice = 0;
            bool valid = false;
            while (!valid)
            {
                Console.Clear();
                Console.WriteLine("Choose your size\n1.Small $2.00\n2.Medium $3.00\n3.Large $4.00");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 3)
                {
                    continue;
                }
                valid = true;
            }

            Pizza thePizza = null;
            switch (choice)
            {
                case 1:
                    thePizza = new Small();
                    break;
                case 2:
                    thePizza = new Medium();
                    break;
                case 3:
                    thePizza = new Large();
                    break;
            }
            valid = false;
            while (!valid)
            {
                Console.Clear();
                Console.WriteLine("Choose your Crust\n1.Standard $1.99\n2.Deep Dish $4.00\n3.Chicago Style $3.50\n4.Thin-Crust $3.25\n5.Artisan $4.99");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice >5)
                {
                    continue;
                }
                valid = true;
            }

          
            switch (choice)
            {
                case 1:
                    thePizza = new Standard(thePizza);
                    break;
                case 2:
                    thePizza = new DeepDish(thePizza);
                    break;
                case 3:
                    thePizza = new Chicago(thePizza);
                    break;
                case 4:
                    thePizza = new ThinCrust(thePizza);
                    break;
                case 5:
                    thePizza = new Artisan(thePizza);
                    break;
            }
            bool hamOn = false, pineappleOn = false, onionOn = false, pepperoniOn = false, jalepenoOn = false;

            valid = false;
            while (!valid)
            {
                Console.Clear();
                Console.WriteLine("Current Order: " + thePizza.getDescription() + " $" + thePizza.cost());
                Console.WriteLine("Choose your Toppings\n1.Ham $1.00\n2.Pineapple $.75\n3.Onion $.50\n4.Pepperoni $.50\n5.Jalepeno $.50\n6.Checkout");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 1 || choice > 7)
                    continue;
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        if (!hamOn)
                        {
                            thePizza = new Ham(thePizza);
                            hamOn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cannot add ham again\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        if (!pineappleOn)
                        {
                            thePizza = new Pineapple(thePizza);
                            pineappleOn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cannot add pineapple again\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        if (!onionOn)
                        {
                            thePizza = new Onion(thePizza);
                            onionOn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cannot add onion again\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        if (!pepperoniOn)
                        {
                            thePizza = new Pepperoni(thePizza);
                            pepperoniOn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cannot add pepperoni again\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                    case 5:
                        if (!jalepenoOn)
                        {
                            thePizza = new Jalepeno(thePizza);
                            jalepenoOn = true;
                        }
                        else
                        {
                            Console.WriteLine("Cannot add jalepenos again\nPress any key to continue...");
                            Console.ReadKey();
                        }
                        break;
                }
            }
            Console.Clear();
            Console.WriteLine("Total for " + thePizza.getDescription() + " is $" + thePizza.cost());
            Console.ReadKey();
        }
    }
}
