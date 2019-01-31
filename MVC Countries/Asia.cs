using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Asia
    {
        public List<Country> Countries = new List<Country>();
        public Asia()
        {
            string[] JPColors = { "Red, ", "White" };
            Countries.Add(new Country("Japan", "Japanese", "Kon'nichiwa sekai!", JPColors));

            string[] RAColors = { "White, ", "Blue, ","Red" };
            Countries.Add(new Country("Russia", "Russian", "Privet, mir!", RAColors));

            string[] CHColors = { "Red, ", "Gold" };
            Countries.Add(new Country("China", "Chinese", "Nǐ hǎo, shìjiè!", CHColors));

            string[] YMColors = {"Red, ","White, ","Black" };
            Countries.Add(new Country("Yemen","Arabic", "Marhabaan bialealam!", YMColors));

            string[] SKColors = {"White, ","Red, ", "Blue, ", "Black" };
            Countries.Add(new Country("South Korea", "Korean", "Annyeong sesang!", SKColors));
        }
    }
}
