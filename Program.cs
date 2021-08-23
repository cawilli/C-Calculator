using System;

namespace Week_5_Assignment_Test_Environment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator Console Application Simulator. Please follow the guided steps below.");
            var adding = true;
            try
            {
                while (adding)
                {

                    var ask = new AskForUserInput();
                    var number1 = ask.input1();               

                    Console.WriteLine("Insert second number:");
                    int number2 = Convert.ToInt32(Console.ReadLine());                    

                    Console.WriteLine("Insert math operator + (add), - (subtract), * (multiply), / (divide)");
                    var option = Console.ReadLine();


                    if (option == "+")
                        Console.WriteLine($"Answer = {number1 + number2}");

                    else if (option == "-")
                        Console.WriteLine($"Answer = {number1 - number2}");

                    else if (option == "*")
                        Console.WriteLine($"Answer = {number1 * number2}");

                    else if (option == "/")
                        Console.WriteLine($"Answer = {number1 / number2}");

                    else
                        Console.WriteLine("Not a valid option. Try again.");

                    Console.WriteLine("Add another calculation? y/n");
                    if (Console.ReadLine() != "y")
                        adding = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("You must enter a number. Exiting program");

            }
        }
    }
}
