using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atillo_Act7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: John Rhaezel C. Atillo
            // Section: IT401P
            // Activity: Reuse Activity 6 with Exception Handling and Sorting

            LinkedList<string> list = new LinkedList<string>();
            int numOfNames = 0;

            // Exception handling for number of names
            try
            {
                Console.Write("Enter number of names (minimum 5, maximum 10): ");
                numOfNames = int.Parse(Console.ReadLine());

                if (numOfNames < 5 || numOfNames > 10)
                {
                    Console.WriteLine("Invalid number of names. Please enter between 5 and 10 only.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a NUMBER only.");
                return;
            }

            // Input names
            Console.WriteLine("\nEnter the names:");
            for (int i = 0; i < numOfNames; i++)
            {
                Console.Write("Name " + (i + 1) + ": ");
                string name = Console.ReadLine();
                list.AddLast(name);
            }

            // Display original linked list
            Console.WriteLine("\n--- Original Linked List ---");
            foreach (string name in list)
            {
                Console.Write(name + " -> ");
            }

            // Convert linked list to array
            string[] namesArray = new string[list.Count];
            list.CopyTo(namesArray, 0);

            // Sort array
            Array.Sort(namesArray);

            // Display sorted elements
            Console.WriteLine("\n\n--- Sorted Linked List Elements ---");
            foreach (string name in namesArray)
            {
                Console.Write(name + " -> ");
            }

            Console.ReadKey();
        }
    }   
}
