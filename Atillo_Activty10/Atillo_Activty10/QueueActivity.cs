using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atillo_Activty10
{
    internal class QueueClass
    {
        private Queue<int> queue = new Queue<int>();
        private int maxSize;

        public QueueClass(int size)
        {
            maxSize = size;
        }

        public void Enqueue()
        {
            try
            {
                if (queue.Count == maxSize)
                    throw new Exception("Queue Overflow! Queue is full.");

                Console.Write("Enter value to enqueue: ");
                int value = Convert.ToInt32(Console.ReadLine());

                queue.Enqueue(value);
                Console.WriteLine("Value enqueued successfully.");
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

        public void Dequeue()
        {
            try
            {
                if (queue.Count == 0)
                    throw new Exception("Queue Underflow! Queue is empty.");

                Console.WriteLine("Dequeued value: " + queue.Dequeue());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Peek()
        {
            try
            {
                if (queue.Count == 0)
                    throw new Exception("Queue is empty.");

                Console.WriteLine("Front value: " + queue.Peek());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Display()
        {
            if (queue.Count == 0)
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            foreach (int item in queue)
                Console.WriteLine(item);
        }
    }

}

