using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePrac
{
    class Monkey : Animal
    {
        public Monkey(string name) : base(name)
        { }

        public Monkey() : base()
        { }

        public override string getShoutSound()
        {
            return "吱";
        }
    }
}
