using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class NorthAmerica
    {
        public List<Country> Countries = new List<Country>();

        public NorthAmerica()
        {
            string[] USColors = { "Red, ", "White, ", "Blue" };
            Countries.Add(new Country("USA", "Engish", "Hello World!", USColors));

            string[] CAColors = { "Red, ", "White" };
            Countries.Add(new Country("Canada", "English and French", "Hello World!, Bonjour le Monde!", CAColors));

            string[] MXColors = { "Red, ", "White, ", "Green" };
            Countries.Add(new Country("Mexico", "Spanish", "Hola Mundo!", MXColors));


            string[] CUColors = { "Red, ", "White, ", "Blue" };
            Countries.Add(new Country("Cuba", "Spanish", "Hola Mundo", CUColors));

            string[] CRColors = { "Red", "White", "Blue" };
            Countries.Add(new Country("Costa Rica", "Spanish", "Hola Mundo", CRColors));
        }
    }
}
