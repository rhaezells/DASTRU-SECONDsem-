using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRELIM_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] countries = new string[5];
            {
                //User Input
                Console.WriteLine("Enter country name:");
                for (int idx = 0; idx < countries.Length; idx++)
                {
                    countries[idx] = Console.ReadLine();
                }
                Console.WriteLine("\nThe countries you entered are:");


                foreach (string country in countries)
                {
                    Console.WriteLine(country);
                }
                Array.Sort(countries);

                //Displaying sorted countries
                Console.WriteLine("\nThe countries in alphabetical order are:");
                    foreach (string country in countries)
                {
                    Console.WriteLine(country);
                }

                {
                    Console.ReadKey();
                }
            }
        }
    }
}

