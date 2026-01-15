using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACTIVITY_4_2_Array_of_Objects
{
    internal class Place
    {
        public string name;

        public Place(string name)
        {
            this.name = name;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Place: " + name);
        }



    }
}
