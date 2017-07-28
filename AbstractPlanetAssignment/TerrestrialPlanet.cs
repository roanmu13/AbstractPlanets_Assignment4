using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 20 2017
 Description:  TerrestrialPlanet class
 Version: 0.4- refactoring to try and include oxygen
 */
namespace AbstractPlanetAssignment
{
    public class TerrestrialPlanet : Planet, IHabitable, IHasMoons
    {
        //Private Instance Variables
        private bool _oxygen;
        //Constructors
        /// <summary>
        /// this is the main constructor for the terrestrial planet class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
            Console.WriteLine("Oxygen: " + oxygen);
          
        }
        //public Methods

            //this method checks if mooncount is greater than 0 and returns true if so
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else { return false; }
        }

        //this method checks if the planet is habitable and return true if so
        public bool Habitable()
        {
            if(this._oxygen == true)
            {
                return true;
            }
            else { return false; }
        }
      
    }
}