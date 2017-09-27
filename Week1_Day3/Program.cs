using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a whole number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another whole number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            if(firstNumber > secondNumber)
            {
                Console.WriteLine("The first number is greater!");
            } else if(firstNumber < secondNumber)
            {
                Console.WriteLine("The second number is greater!");
            } else
            {
                Console.WriteLine("Both numbers are equal!");
            };
        }
    }
}
