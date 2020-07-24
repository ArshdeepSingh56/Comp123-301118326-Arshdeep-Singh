using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comp123_301118326_Arshdeep_Singh
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;


        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // The CONTRUCTOR have four arguments 
        public GiantPlanet(string name, double diameter, double mass, string type) :
            base(name, diameter, mass)
        {

            this._type = type;


        }
    }
}