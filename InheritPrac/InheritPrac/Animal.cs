using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritPrac
{
    class Animal
    {
        protected string name = String.Empty;
        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {
            this.name = "Unknown";
        }

        protected int shoutNum = 3;
        public int ShoutNum
        {
            get { return shoutNum; }
            set { this.shoutNum = value; }
        }
    }
}
