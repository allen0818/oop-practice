using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolymorphismPrac
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

        public string Shout()
        {
            string result = String.Empty;
            for (int i = 0; i < shoutNum; i++)
            {
                result += getShoutSound() + ",";
            }

            return "我的名字是" + name + ", " + result;
        }

        public virtual string getShoutSound()
        {
            return String.Empty;
        }
    }
}
