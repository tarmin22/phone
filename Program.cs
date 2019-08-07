using System;
using System.Collections.Generic;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("S8", 100, "T-Mobile", "Doo do dooo");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringg ring ringgs");

            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            elevenHundred.DisplayInfo();
            System.Console.WriteLine(elevenHundred.Ring());
            System.Console.WriteLine(elevenHundred.Unlock());
            System.Console.WriteLine("");
        }
    }
}
