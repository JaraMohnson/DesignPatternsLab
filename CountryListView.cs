using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryListView
    {
        public List<Country> Countries { get; set; }

        //constructor
        public CountryListView (List <Country> _countries)
        {
            Countries = _countries;

        }

        //method 

        public void Display()
        {
            foreach (Country c in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(c)} - {c.Name}");
            }
        }
        
      







    }

}
