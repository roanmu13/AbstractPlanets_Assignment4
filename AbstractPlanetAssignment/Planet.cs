using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Rosa Munguia
 Date: July 20 2017
 Description:  Abstract Planet Class
 Version: 0.1- Created Abstract planet class 
 */
namespace AbstractPlanetAssignment
{
    /// <summary>
    /// Abstract Planet Class-this is the super class that other class will be derived from
    /// </summary>
    public abstract class Planet
    {
        //Private Instance Variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        #region //Public Properties
        public double Diameter
        {
            get
            {
                return this._diameter;
            }
        }
        public double Mass
        {
            get
            {
                return this._mass;
            }
        }
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
        }
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }
        #endregion
        //Constructors****************************************************************************
        /// <summary>
        /// Main constructor- takes three arguments: name(string), diameter(double), mass(double)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

        }
        //Public Methods
        public override string ToString()

        {
            string displayString = "";
            displayString += "Name: "  + this.Name + "\n" + "Diameter: " + this.Diameter +
              "\n" + "Mass: " + this.Mass;

            return displayString;
        }

        //public abstract void HasMoons();
        //Private Methods
    }
}
