using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_6_Inserting_Nodes_to_the_Linked_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Name: John Rhaezel C. Atillo
            //Section: IT401P
            //Date: January 22 , 2026
            //Activity 6: Inserting Nodes to the Linked List

                
            // Create a Linked List
            LinkedList<string> list = new LinkedList<string>();

            // Ask the user to enter names
            Console.WriteLine("Enter Number of Names (minimum 5, maximum 10");
            int numofnames = int.Parse(Console.ReadLine());

            // Prompt the user to enter names
            Console.WriteLine("Enter the Names of your Classmates");
            if (numofnames < 5 || numofnames > 10)
            {
              Console.WriteLine("Invalid number of names. Please enter a number between 5 and 10.");return;
            }

            // Loop to add names to the linked list
            for (int i = 0; i < numofnames; i++)
            {
                string name = Console.ReadLine();
                list.AddLast(name);
            }
            Console.Clear();
            Console.WriteLine("\n---List of Names---\n");
            // Display the names in the linked list
            foreach (string name in list)
            {
              
                Console.Write("\t" + name+"-->");
            }

            Console.ReadKey();

          

            


        }
    }
}
