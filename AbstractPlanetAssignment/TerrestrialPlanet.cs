using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 20 2017
 Description:  TerrestrialPlanet class
 Version: 0.1- created TerrestrialPlanet class
 */
namespace AbstractPlanetAssignment
{
    public class TerrestrialPlanet : Planet
    {
        //Private Instance Variables
        private bool _oxygen;
        //Constructor
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
        //public Methods

        public bool HasMoons()
        {
            return (MoonCount > 0);
        }

        public bool Habitable()
        {
            if(this._oxygen == true)
            {
                
            }
            return _oxygen;
        }
    }
}