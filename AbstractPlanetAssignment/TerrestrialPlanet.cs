using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Rosa Munguia
 Date: July 20 2017
 Description:  TerrestrialPlanet class
 Version: 0.2- update public methods
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

        public override bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else { return false; }
        }

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