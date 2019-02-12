using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InheritPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Cat_Shout_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("小咪");
            cat.ShoutNum = 5;
            MessageBox.Show(cat.Shout());
        }

        private void Button_Dog_Shout_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog("黑皮");
            dog.ShoutNum = 3;
            MessageBox.Show(dog.Shout());
        }
    }
}
