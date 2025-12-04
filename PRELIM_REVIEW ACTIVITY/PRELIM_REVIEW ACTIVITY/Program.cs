using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRELIM_REVIEW_ACTIVITY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string tryAgain = "y";

                // Main loop – keeps repeating as long as the user enters 'y'
                while (tryAgain.ToLower() == "y")
                {
                    Console.WriteLine("This program will determine what type of number and display its range.\n");
                    Console.Write("Please enter a number: ");
                    string userInput = Console.ReadLine();

                    int number;



                    if (!int.TryParse(userInput, out number))
                    {
                        Console.WriteLine("Please re-try to enter a numeric value.\n");
                        Console.Write("Do you want to try again (y/n)? ");
                        tryAgain = Console.ReadLine();
                        Console.WriteLine();
                        continue;  // restart loop
                    }


                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even number\n");
                        Console.WriteLine("This is the range of numbers based from the number entered.");

                        // Display descending even numbers
                        for (int i = number; i >= 2; i -= 2)
                        {
                            Console.Write(i + " ");
                        }
                        Console.WriteLine("\n");
                    }
                    else
                    {

                        Console.WriteLine($"Sorry, I cannot provide the range of numbers based from the number you entered.\n");
                    }


                    Console.Write("Do you want to try again (y/n)? ");
                    tryAgain = Console.ReadLine();
                    Console.WriteLine();
                }


                Console.WriteLine("Thank you for using this program.");
            }

        }

    }

    
