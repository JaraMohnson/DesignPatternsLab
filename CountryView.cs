using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsLab;

namespace DesignPatternsLab
{
    internal class CountryView
    {
        //prop
        public Country DisplayCountry { get; set; }

        //constructor 

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}\nContinent: {DisplayCountry.Continent}\nCountry Colors:"); //displays country name, and continent it's on 
            for (int i = 0; i < DisplayCountry.Colors.Count; i++)
            {
                Console.ForegroundColor = Enum.Parse<ConsoleColor>(DisplayCountry.Colors[i]); // determine what color we write in 
                    
                if (DisplayCountry.Colors[i] == "Black") // add a bit in case a color is black 
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }

                Console.WriteLine(DisplayCountry.Colors[i]); //get the colors out to user 
                Console.ResetColor(); //reset 
            }

        }

        //(typeof(ConsoleColor),(DisplayCountry.Colors[i]), true);




    }
}
