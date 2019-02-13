using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfacePrac
{
    class MachineCat : Cat, IChange
    {
        public MachineCat() 
            : base()
        { }

        public MachineCat(string name)
            : base(name)
        { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + " 我有萬能百寶袋，可變出" + thing;
        }
    }
}
