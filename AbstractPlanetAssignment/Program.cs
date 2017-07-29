using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 28 2017
 Description:  Driver Class
 Version: 0.5- created one more object each of giantplanet and terrestrial planet
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
            GiantPlanet bigPlanet = new GiantPlanet("Acolia", 50000, Math.Pow(4,6), "Ice");
            Console.WriteLine(bigPlanet.ToString());
            Console.WriteLine();
            GiantPlanet anotherBigPlanet = new GiantPlanet("Frelia", 350000, Math.Pow(5, 7), "Gas");
            Console.WriteLine(anotherBigPlanet.ToString());

            bigPlanet.HasMoons();
            Console.WriteLine();

            Console.WriteLine("List of Terrestrial Planets:");
            Console.WriteLine("-----------------------------");
            TerrestrialPlanet hugePlanet = new TerrestrialPlanet("Dolerth", 320000, Math.Pow(9,5), true);
            Console.WriteLine(hugePlanet.ToString());
            Console.WriteLine();
            TerrestrialPlanet giganticPlanet = new TerrestrialPlanet("Zyneroid", 550000, Math.Pow(12, 7), false);
            Console.WriteLine(giganticPlanet.ToString());
           
            Program.WaitForAnyKey();  
        }
       

    }
}


