using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PolymorphismPrac
{
    public partial class Form1 : Form
    {
        private List<Animal> animalList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            animalList = new List<Animal>();
            animalList.Add(new Cat("小花"));
            animalList.Add(new Dog("黑皮"));
            animalList.Add(new Dog("賓果"));
            animalList.Add(new Cat("小咪"));
            animalList.Add(new Cat("魯賓遜"));
        }

        private void Button_ShoutGame_Click(object sender, EventArgs e)
        {
            if (animalList == null || animalList.Count() == 0) return;

            foreach (Animal animal in animalList)
            {
                MessageBox.Show(animal.Shout());
            }
        }
    }
}
