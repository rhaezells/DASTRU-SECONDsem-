using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atillo_Activty10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueueClass queue = new QueueClass(5);
            int choice;

            do
            {
                Console.WriteLine("\n===== QUEUE MENU =====");
                Console.WriteLine("1. Enqueue");
                Console.WriteLine("2. Dequeue");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: queue.Enqueue(); break;
                        case 2: queue.Dequeue(); break;
                        case 3: queue.Peek(); break;
                        case 4: queue.Display(); break;
                        case 5: Console.WriteLine("Exiting..."); break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input! Numbers only.");
                    choice = 0;
                }

            } while (choice != 5);
        }
    }
}
    
    
