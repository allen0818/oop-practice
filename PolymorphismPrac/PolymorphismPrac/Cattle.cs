using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismPrac
{
    class Cattle : Animal
    {
        public Cattle(string name) : base(name)
        { }

        public Cattle() : base()
        { }

        public override string getShoutSound()
        {
            return "哞";
        }
    }
}
