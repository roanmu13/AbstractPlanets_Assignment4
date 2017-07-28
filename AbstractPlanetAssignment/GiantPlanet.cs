using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 26 2017
 Description:  GiantPlanet class
 Version: 0.4- refactoring to try and include type
 */
namespace AbstractPlanetAssignment
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
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
            Console.WriteLine("Type: " + type);
          


        }
        //public Methods

            //this method returns true if mooncount is greater than 0
        public bool HasMoons()
        {
            return MoonCount > 0;
           
        }

        //this method returns true if ringcount is greater than 0
        public bool HasRings()
        {
            return RingCount > 0;
        }

    }
}
