using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismPrac
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        { }

        public Cat() : base()
        { }

        public override string getShoutSound()
        {
            return "喵";
        }
    }
}
