using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatePrac
{
    class Cat
    {
        private string name;
        public Cat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);
        public event CatShoutEventHandler CatShout;

        public void Shout()
        { 
            Console.WriteLine("喵, 我是{0}.", name);

            if (CatShout != null) //如果有物件登記 CatShout 事件，則執行 CatShout().
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;
                CatShout(this, e); 
            } 
        }
    }

    public class CatShoutEventArgs : EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
    }
}
