using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                CountryController cc = new CountryController();
                cc.CountryMenu();
            } while (Continue() == true);

            Console.WriteLine("\nPress any key to escape...");
            Console.ReadLine();
        }

        public static bool Continue()
        {
            int i = 0;
            int x = 3;
            do
            {
                Console.Write("\nWould you like to continue (y/n)? ");
                string go = Console.ReadLine().ToLower();
                if (go == "y" || go == "yes")
                {
                    Console.Clear();
                    return true;
                }
                else if (go == "n" || go == "no" || go == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid. You have {0} attempts remaining", x);
                    i++; x--;
                }
            } while (i <= 3);
            return false;
        }
    }
}
