using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Viewer
    {
        //int num = 1;
        public void Continent()
        {
            Console.WriteLine("***** CONTINENTS ******");
            Console.WriteLine("1:) North America");
            Console.WriteLine("2:) Asia");
            Console.Write("Select a continent: ");
            
        }
        public void CountryList(Country c, int num)
        {
            Console.WriteLine($"{num}: {c.Name}");            
        }

        public void CountrySelect()
        {            
            Console.Write("Select a country: ");
        }

        public void Error()
        {
            Console.WriteLine("Invalid Input. Try Again");
        }
    }
}
