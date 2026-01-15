using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_4_2_Array_of_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Place[,] places = new Place[2, 3]
            {
                {
                    new Country("Philippines"),
                    new Country("Japan"),
                    new Country("Canada")
                },
                {
                    new Country("Australia"),
                    new Country("India"),
                    new Country("USA")
                }
            };

            Console.WriteLine("=== TWO DIMENSIONAL ARRAY OF OBJECTS ===\n");

            // Access the 2D array using loop structures
            for (int row = 0; row < places.GetLength(0); row++)
            {
                for (int col = 0; col < places.GetLength(1); col++)
                {
                    places[row, col].DisplayInfo();
                }
                Console.WriteLine();
            }

            Console.ReadKey();



        }
    }
}
