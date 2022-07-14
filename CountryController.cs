using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsLab
{
    internal class CountryController
    {
        //prop
        public List<Country> CountryDb { get; set; }

        //constructor
        public CountryController()
        {
            CountryDb = new List<Country>()
            {
            new Country("Japan", "Asia", new List<string>{"Red", "White"}),
            new Country("Brazil", "South America", new List<string>{"Blue", "Green", "Yellow"}),
            new Country("Mexico", "North America", new List<string>{"Green", "Red", "White"}),
            new Country("USA", "North America", new List<string>{"Red", "Blue", "White"}),
            new Country("Germany", "Europe", new List<string>{"Red", "Black", "Yellow"}),
            new Country("China", "Asia", new List<string>{"Red", "Yellow"}),
            new Country("Sweden", "Europe", new List<string>{"Yellow", "Blue"}),
            };
        }

        public void CountryAction(Country c)
        {
            CountryView testing = new CountryView(c);
            testing.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryList = new CountryListView(CountryDb);
            Console.WriteLine("Welcome to the country app! This app displays the continent the country is on, along with its colors. " +
                "Please select a country from the following list: ");
            while (true)
            {
                countryList.Display();
                Console.WriteLine("Please choose which country you'd like to learn about: ");
                int choice = int.Parse(Console.ReadLine());
                CountryAction(CountryDb[choice]);

                Console.WriteLine("Choose another country? y/n");
                string input = Console.ReadLine().ToLower().Trim();
                if (input.Contains("y"))
                {
                    continue;
                }
                else if (input.Contains("n"))
                {
                    Console.WriteLine("Have a great day :)");
                    break;
                }
                else
                {
                    Console.WriteLine("please make valid choice");
                }

            }

        }
    }

}

