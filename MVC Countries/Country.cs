using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Countries
{
    class Country
    {
        public string Name;
        public string Lang;
        public string Hello;
        public string[] Colors;

        public Country(string Name, string Lang, string Hello, string[] Colors)
        {
            this.Name = Name;
            this.Lang = Lang;
            this.Hello = Hello;
            this.Colors = Colors;
        }
    }
}
