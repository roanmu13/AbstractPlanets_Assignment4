﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 20 2017
 Description:  GiantPlanet class
 Version: 0.2- updated public methods
 */
namespace AbstractPlanetAssignment
{
    class GiantPlanet : Planet
    {
        //Private Instance Variables
        private string _type;

        //Constructor
        /// <summary>
        /// main constructor for giantplanet class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// 
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;


        }
        //public Methods
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else { return false; }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else { return false; }
        }

    }
}
