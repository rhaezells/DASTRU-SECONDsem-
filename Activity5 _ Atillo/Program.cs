using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5___Atillo
{
    internal class Program
    {
        static void Main(string[] args)
        {

       //Name: John Rhaezel C.Atilo         
            {
                Country[,] countries = new Country[2, 2];

                Console.WriteLine("=== Enter Japan Details ===");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\nJapan Entry {i + 1}");
                    string capital = UserInput.GetString("Enter Capital: ");
                    string language = UserInput.GetString("Enter Language: ");
                    string primeMinister = UserInput.GetString("Enter Prime Minister: ");

                    countries[0, i] = new Japan("Japan", capital, language, primeMinister);
                }

                Console.WriteLine("\n=== Enter Philippines Details ===");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"\nPhilippines Entry {i + 1}");
                    string capital = UserInput.GetString("Enter Capital: ");
                    string language = UserInput.GetString("Enter Language: ");
                    string president = UserInput.GetString("Enter President: ");

                    countries[1, i] = new Philippines("Philippines", capital, language, president);
                }

                Console.WriteLine("\n=== Country Information ===");
                foreach (Country country in countries)
                {
                    country.DisplayInfo();
                }

                Console.ReadKey();
            }
        }


        //Country[,] countries = new Country[2, 2];

        ////Assign values for each object
        //countries[0, 0] = new Japan("Japan", "Tokyo", "Japanese", "Fumio Kishida");
        //countries[0, 1] = new Japan("Japan", "Tokushima","Japanesh/English","Ms. TAKAISHI Sanae");


        //countries[1, 0] = new Phillipines("Phillipines", "Cebu", "Cebuano","Pamela Baricuatro");
        //countries[1, 1] = new Phillipines("Phillipines", "Manila","Tagalog","Ferdinand Marcos Jr.");

        //// Display music information
        //foreach (Country country in countries)
        //{
        //    country.displayInfo();
        //}

        //Console.ReadKey();
    }
}


