using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atillo_activity9
{
    internal class Program
    {

        // Global stack variables (Procedural approach)
        static int[] stack = new int[5];
        static int top = -1;
        static int max = 5;

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n===== STACK MENU =====");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Display");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Push();
                            break;
                        case 2:
                            Pop();
                            break;
                        case 3:
                            Peek();
                            break;
                        case 4:
                            Display();
                            break;
                        case 5:
                            Console.WriteLine("Exiting program...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a number only.");
                    choice = 0;
                }

            } while (choice != 5);

            Console.ReadLine();
        }

        static void Push()
        {
            try
            {
                if (top == max - 1)
                {
                    throw new Exception("Stack Overflow! Stack is full.");
                }

                Console.Write("Enter value to push: ");
                int value = Convert.ToInt32(Console.ReadLine());

                top++;
                stack[top] = value;

                Console.WriteLine("Value pushed successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Pop()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("Stack Underflow! Stack is empty.");
                }

                Console.WriteLine("Popped value: " + stack[top]);
                top--;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Peek()
        {
            try
            {
                if (top == -1)
                {
                    throw new Exception("Stack is empty. Nothing to peek.");
                }

                Console.WriteLine("Top value: " + stack[top]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
    

