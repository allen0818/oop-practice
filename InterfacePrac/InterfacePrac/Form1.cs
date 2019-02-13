using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfacePrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_ChangeThing_Click(object sender, EventArgs e)
        {
            MachineCat mcat = new MachineCat("哆啦A夢");
            StoneMonkey wukong = new StoneMonkey("孫悟空");

            IChange[] array = new IChange[2];
            array[0] = mcat;
            array[1] = wukong;

            MessageBox.Show(array[0].ChangeThing("各式各樣的東西!"));
            MessageBox.Show(array[1].ChangeThing("各式各樣的東西!"));
        }
    }
}
