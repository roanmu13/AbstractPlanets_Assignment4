﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 28 2017
 Description:  Driver
 Version: 0.4- properly implemented waitForAnyKey method in program class
 */
namespace AbstractPlanetAssignment
{
    class Program
    {
        //method to wait for user keypress in order to exit
        static void WaitForAnyKey()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("List of Giant Planets: ");
            Console.WriteLine("-------------------------");
            GiantPlanet bigPlanet = new GiantPlanet("Acolia", 50000, 100, "Ice");
            Console.WriteLine(bigPlanet.ToString());

            // bigPlanet.HasMoons();
            Console.WriteLine();

            Console.WriteLine("List of Terrestrial Planets:");
            Console.WriteLine("-----------------------------");
            TerrestrialPlanet hugePlanet = new TerrestrialPlanet("Dolerth", 320000, 250, true);
            Console.WriteLine(hugePlanet.ToString());
            //  Console.WriteLine();
            Program.WaitForAnyKey();  
        }
       

    }
}


