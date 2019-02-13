using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismPrac
{
    class Sheep : Animal
    {
        public Sheep(string name) : base(name)
        { }

        public Sheep() : base()
        { }

        public override string getShoutSound()
        {
            return "咩";
        }
    }
}
