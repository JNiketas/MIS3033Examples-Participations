using System;
using System.Collections.Generic;

namespace PracticeProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> results = new List<double>();
            string goagain = "yes";

            while (goagain != "no")
            {
                Console.WriteLine("Please input a value for the left operand. >>");
                double left = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please input a value for the right operand. >>");
                double right = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Which calculation would you like to perform? >> (Add, Subtract, Multiply, Leftpower, Rightpower)");
                string calculation = Console.ReadLine().ToLower();

                Equation eq = new Equation(left, right);

                if (calculation == "add")
                {
                    double add = eq.Add();
                    results.Add(add);

                }
                else if (calculation == "subtract")
                {
                    double subtract = eq.Subtract();
                    results.Add(subtract);
                }
                else if (calculation == "multiply")
                {
                    double multiply = eq.Multiply();
                    results.Add(multiply);
                }
                else if (calculation == "leftpower")
                {
                    Console.WriteLine("To what power would you like to raise the left operand to? >>");
                    int power = Convert.ToInt32(Console.ReadLine());
                    double leftpower = eq.LeftToThePower(power);
                    results.Add(leftpower);
                }
                else if (calculation == "rightpower")
                {
                    Console.WriteLine("To what power would you like to raise the right operand to? >>");
                    int power = Convert.ToInt32(Console.ReadLine());
                    double rightpower = eq.RightToThePower(power);
                    results.Add(rightpower);
                }
                else
                {
                    Console.WriteLine("Invalid operand");
                    Environment.Exit(0);
                }

                Console.WriteLine("Would you like to perform another calculation? >> (Yes or No)");
                 goagain = Console.ReadLine().ToLower();
            }

            foreach (var result in results)
            {
                Console.WriteLine(result.ToString());
            }

            Console.ReadKey();
            


        }
    }
}
