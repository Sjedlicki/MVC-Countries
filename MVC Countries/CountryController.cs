using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class CountryController
    {
        Viewer view = new Viewer();
        public int index;
        public void CountryMenu()
        {
            view.Continent();
            int.TryParse(Console.ReadLine(), out int input);
            List<Country> countries;

            if (input == 1)
            {
                NorthAmerica na = new NorthAmerica();
                countries = na.Countries;
                int num = 1;
                foreach (Country c in countries)
                {
                    //view.CountryList(c);
                    
                    Console.WriteLine($"{num}: {c.Name}");
                    num++;
                }

                bool run = true;

                do
                {
                    //view.CountrySelectNA(index);
                    Console.Write("Select a country: ");
                    int.TryParse(Console.ReadLine(), out index);
                    if (index > 0 && index <= 5)
                    {
                        Country c = countries[index-1];
                        CountryDetails(c);
                        break;
                    }
                    else
                    {
                        view.Error();
                    }
                } while (run == true);

            }
            else
            {
                Asia a = new Asia();
                countries = a.Countries;
                int num = 1;
                foreach (Country c in countries)
                {
                    Console.WriteLine($"{num}: {c.Name}");
                    num++;
                }
                bool run = true;
                do
                {
                    Console.Write("Select a country: ");
                    int.TryParse(Console.ReadLine(), out int index);
                    if (index > 0 && index <= 5)
                    {
                        Country c = countries[index - 1];
                        CountryDetails(c);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Try Again");
                    }
                } while (run == true);
            }
        }

        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);

            cd.Display();
        }
    }
}
