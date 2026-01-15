using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_4_2_Array_of_Objects
{
    internal class Country : Place
    {
        public Country(string name) : base(name)
        {
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("Country: " + name);
        }

    }
}
