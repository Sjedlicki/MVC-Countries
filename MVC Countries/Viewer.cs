using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Viewer
    {
        public void Continent()
        {
            Console.WriteLine("***** CONTINENTS ******");
            Console.WriteLine("1:) North America");
            Console.WriteLine("2:) Asia");
        }
        public void CountryList(Country c)
        {
            int num = 1;
            Console.WriteLine($"{num}: {c.Name}");
            num++;
        }

        public int CountrySelectNA(int index)
        {
            Console.Write("Select a country: ");
            int.TryParse(Console.ReadLine(), out index);
            return index - 1;
        }

        public void Error()
        {
            Console.WriteLine("Invalid Input. Try Again");
        }
    }
}
