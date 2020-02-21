using System;
using System.Collections.Generic;

namespace PracticeProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            double EspressoPrice = 2.15;
            double CappuccinoPrice = 4.20;
            double LattePrice = 5.00;
            double AmericanoPrice = 3.55;
            double DripPrice = 1.25;
            double VanillaShotPrice = 0.75;
            double EspressoShotPrice = 0.80;

            

            List<double> drinklist = new List<double>();

                if (Console.ReadLine().ToLower() == "hello")
                {

                    do
                    {
                    double mainmenutotal = 0;
                    double extramenutotal = 0;
                    double grandtotal = 0;

                    Console.WriteLine($"Espresso : ${EspressoPrice}");
                        Console.WriteLine($"Cappuccino : ${CappuccinoPrice}");
                        Console.WriteLine($"Latte : ${LattePrice}");
                        Console.WriteLine($"Americano : ${AmericanoPrice}");
                        Console.WriteLine($"Drip : ${DripPrice}");
                        Console.WriteLine();
                        Console.WriteLine("What type of drink would you like? >>");
                        string drink = Console.ReadLine().ToLower();

                        if (drink == "espresso")
                        {
                            mainmenutotal = EspressoPrice;
                        }
                        else if (drink == "cappuccino")
                        {
                            mainmenutotal = CappuccinoPrice;
                        }
                        else if (drink == "latte")
                        {
                            mainmenutotal = LattePrice;
                        }
                        else if (drink == "americano")
                        {
                            mainmenutotal = AmericanoPrice;
                        }
                        else if (drink == "drip")
                        {
                            mainmenutotal = DripPrice;
                        }

                        Console.WriteLine();
                        Console.WriteLine($"Shot of Vanilla : ${VanillaShotPrice}");
                        Console.WriteLine($"Shot of Espresso : ${EspressoShotPrice}");
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add any additional shot? >> (Yes or No)");
                        string shots = Console.ReadLine().ToLower();

                        if (shots == "yes")
                        {
                            Console.WriteLine("What type of shot would you like? >> (Vanilla or Espresso)");
                            string shotselection = Console.ReadLine().ToLower();
                            Console.WriteLine("How many shots would you like?");
                            int numshots = Convert.ToInt32(Console.ReadLine());

                            if (shotselection == "vanilla")
                            {
                                extramenutotal = VanillaShotPrice * numshots;
                            }
                            else if (shotselection == "espresso")
                            {
                                extramenutotal = EspressoShotPrice * numshots;
                            }
                        }

                        grandtotal = (mainmenutotal + extramenutotal) * 1.075;
                        drinklist.Add(grandtotal);

                        Console.WriteLine("Woudld you like to add another drink? >> (Yes or No)");
                    } while (Console.ReadLine().ToLower() == "yes");

                    for (int i = 0; i < drinklist.Count; i++)
                    {
                    Console.WriteLine($"Drink {i + 1} = {drinklist[i].ToString("C2")}");
                    }

                }

            Console.ReadKey();

                
        }
    }
}
