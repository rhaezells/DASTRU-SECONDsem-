using Activity5___Atillo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Activity5___Atillo
{
    internal class Country
    {
        
        
       
         public string Name { get; set; }
        public string Capital { get; set; }
        public string Language { get; set; }

        public Country(string name, string capital, string language)
        {
            Name = name;
            Capital = capital;
            Language = language;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Country  : {Name}");
            Console.WriteLine($"Capital  : {Capital}");
            Console.WriteLine($"Language : {Language}");
        }
    }
    class Japan : Country
    {
        public string PrimeMinister { get; set; }

        public Japan(string name, string capital, string language, string primeMinister)
            : base(name, capital, language)
        {
            PrimeMinister = primeMinister;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Japan Info ---");
            Console.WriteLine($"Prime Minister: {PrimeMinister}");
            base.DisplayInfo();
        }
    }

    class Philippines : Country
    {
        public string President { get; set; }

        public Philippines(string name, string capital, string language, string president)
            : base(name, capital, language)
        {
            President = president;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n--- Philippines Info ---");
            Console.WriteLine($"President: {President}");
            base.DisplayInfo();
        }
    }
    internal class UserInput
    {
        public static string GetString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}

//    internal class Country
//    {
//        public string Name { get; set; }
//        public string Capital { get; set; }
//        public string Language { get; set; }


//        public Country(string name, string capital, string language)
//        {
//            Name = name;
//            Capital = capital;
//            Language = language;
//        }
//        public virtual void displayInfo()     
//        {
//            Console.WriteLine($"Country: {Name}");
//            Console.WriteLine($"Capital : {Capital}");
//            Console.WriteLine($"Language: {Language}");

//        }

//    }
//}

//class Japan : Country
//{
//    public string PrimeMinester { get; set; }
//    //Parameterized Constructor
//    public Japan (string name, string capital, string lanuage, string primeMinester) : base (name, capital, lanuage)
//    {
//        PrimeMinester = primeMinester;
//    }

//    public override void displayInfo()
//    {
//        Console.WriteLine("\n---Japan Infor---\n");
//        Console.WriteLine($"Prime Minester: {PrimeMinester}");
//        base.displayInfo();
//    }
//}
//// Derived Class 2
//class Phillipines : Country
//{
//    public string President { get; set; }   

//    public Phillipines(string name, string capital, string language, string president) : base (name, capital, language)
//    {
//        President = president;
//    }

//    public override void displayInfo()
//    {
//        Console.WriteLine("\n---Phillipines Info---");
//        Console.WriteLine($"President: {President}");
//        base.displayInfo ();
//    }
//}
