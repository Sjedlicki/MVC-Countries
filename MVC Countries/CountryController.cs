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
        public bool run = true;

        public void CountryMenu()
        {


            do
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
                        view.CountryList(c, num);
                        num++;
                    }

                    do
                    {
                        view.CountrySelect();
                        int.TryParse(Console.ReadLine(), out index);

                        if (index > 0 && index <= 5)
                        {
                            Country c = countries[index - 1];
                            CountryDetails(c);
                            run = false;
                            break;
                        }
                        else
                        {
                            view.Error();
                        }
                    } while (run == true);

                }
                else if (input == 2)
                {
                    Asia a = new Asia();
                    countries = a.Countries;

                    int num = 1;
                    foreach (Country c in countries)
                    {
                        view.CountryList(c, num);
                        num++;
                    }

                    do
                    {
                        view.CountrySelect();
                        int.TryParse(Console.ReadLine(), out int index);

                        if (index > 0 && index <= 5)
                        {
                            Country c = countries[index - 1];
                            CountryDetails(c);
                            run = false;
                            break;
                        }
                        else
                        {
                            view.Error();
                        }
                    } while (run == true);
                }
                else if (input != 1 || input != 2)
                {
                    view.Error();
                    run = true;
                }
                else
                {
                    run = false;
                    break;
                }
            } while (run == true);
        }

        public void CountryDetails(Country c)
        {
            CountryDetails cd = new CountryDetails(c);

            cd.Display();
        }
    }
}
