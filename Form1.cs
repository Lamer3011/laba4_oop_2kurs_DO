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
    public partial class Form1 : Form
    {
        delegate void myType(int num);
        event myType myEvent;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2.Show();

            myType myDelegate1 = form2.myFunc1;
            myType myDelegate2 = form2.myFunc2;
            myType myDelegate3 = this.myFunc3;

            myEvent += myDelegate1;
            myEvent += myDelegate2;
            myEvent += myDelegate3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(textBox1.Text);
                count++;
                textBox1.Text = Convert.ToString(count, 10);
                myEvent(count);

                form2.button1 = this.button1;

                button1.Width += 2;
                button1.Height += 2;
            }
            catch(Exception)
            {
                MessageBox.Show("Щось пішло не так!");
            }
        }

        private void myFunc3(int d)
        {
            Random rand = new Random();

            int r = rand.Next(0, 255);
            int g = rand.Next(0, 255);
            int b = rand.Next(0, 255);

            button1.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
