using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismPrac
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        { }

        public Dog() : base()
        { }

        public override string getShoutSound()
        {
            return "汪";
        }
    }
}
