﻿using System;
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
            /*
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
            


            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge == 0 || userAge == 1)
            {
                Console.WriteLine("You're just a baby!");
                
            } else if (userAge > 1 && userAge < 4)
            {
                Console.WriteLine("Yay toddlers!");
            } else if (userAge >= 4 && userAge < 13)
            {
                Console.WriteLine("Enjoy your childhood!");
            } else if (userAge >= 13 && userAge < 65)
            {
                Console.WriteLine("Life is awkward.");
            } else if (userAge >= 65 && userAge < 100)
            {
                Console.WriteLine("Enjoy your retirement!");
            } else
            {
                Console.WriteLine("That's not your real age");
            }
            */

            Console.WriteLine("How many points did you earn?");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("You lose.");
                    break;
                /* if(pointsEarned == 0)
                 * {
                 *      Console.WriteLine("You lose.");
                 * }
                 */

                case 1:
                    Console.WriteLine("Need practice.");
                    break;


                case 2:
                    Console.WriteLine("On target.");
                    break;

                case 3:
                    Console.WriteLine("Superstar.");
                    break;

                case 4:
                    Console.WriteLine("Overacheiver.");
                    break;

                case 5:
                    Console.WriteLine("You cheated.");
                    break;

                default:
                    Console.WriteLine("Invalid score entered");
                    break;
                /* else
                 * {
                 *      Console.WriteLine("Invalid score entered");
                 * }
                 */
            }
        }
    }
}
