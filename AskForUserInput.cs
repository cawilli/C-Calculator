using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_Assignment_Test_Environment
{
    public class AskForUserInput
    {//this is a class. classes help to help keep code clean and organized but also help with mutiple executions.
     //will learn more about classes. 
        public int input1()
        {
            Console.WriteLine("Insert first number:");
            return int.Parse(Console.ReadLine());
        }
        
    }
}
