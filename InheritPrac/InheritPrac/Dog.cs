﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritPrac
{
    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public Dog() : base()
        {
        }

        public string Shout()
        {
            string result = String.Empty;
            for (int i = 0; i < shoutNum; i++)
            {
                result += "汪 ";
            }

            return "我的名字是" + name + ", " + result;
        }
    }
}
