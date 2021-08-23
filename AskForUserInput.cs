using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_Assignment_Test_Environment
{
    public class AskForUserInput
    {
        public int input1()
        {
            Console.WriteLine("Insert first number:");
            return int.Parse(Console.ReadLine());
        }
        
    }
}
