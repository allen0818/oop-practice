using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritPrac
{
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public Cat() : base()
        {
        }

        public string Shout()
        {
            string result = String.Empty;
            for (int i = 0; i < shoutNum; i++)
            {
                result += "喵 ";
            }

            return "我的名字是" + name + ", " + result;
        }
    }
}
