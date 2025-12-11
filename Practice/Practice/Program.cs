using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] WorkerName = { "John", "Vin", "Spem", "Brad" };
            //Array.Sort(WorkerName);


            //foreach (string workerName in WorkerName)
            //{
            // Console.WriteLine(workerName);
            //}


            //Console.ReadKey();


            // string[] BusunessPartner = { "Beca", "RD", "VIc", "Nann" };
            //  int[] Soldout = { 20, 13, 21, 23 };

            // foreach (string busunessPartner in BusunessPartner)
            // {
            // //   Console.WriteLine(busunessPartner);
            //}

            //foreach (int soldoutPartner in Soldout)
            //{
            //    Console.WriteLine(soldoutPartner);
            //}

            string[] Name = { "Ben", "Josh", "Sil", "Bran" };
            Console.WriteLine("Here are the name:");

            foreach (string name in Name)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
