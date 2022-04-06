using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4_oop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Button button1 { get; set; }

        public void myFunc1(int numl)
        {
            string str = "Кнопка натиснута: "
                + Convert.ToString(numl)
                + "раз";
            label1.Text = str;
        }

        public void myFunc2(int nump)
        {
            progressBar1.Value = nump % 100;

            if (nump % 10 == 0)
            {
                button1.Location = new Point(button1.Location.X + 10, button1.Location.Y);
            }
        }
    }
}
