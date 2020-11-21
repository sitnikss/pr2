using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var str = textBox1.Text;

            var tuple = Check(str);
            if (tuple.Item1)
                textBox2.Text = ("Правильность расстановки скобок правильная.");
            else if (tuple.Item2 >= 0)
                textBox2.Text = ($"В позизиции {tuple.Item2} обнаружена непарная закрывающая скобка!");
            else
                textBox2.Text = ($"В строке не хватает {tuple.Item3} закрывающих скобок!");
        }
            private static Tuple<bool, int, int> Check(string str)
            {
                int counter = 0;
                for (int i = 0, len = str.Length; i < len; ++i)
                {
                    var c = str[i];
                    switch (c)
                    {
                        case '(':
                            ++counter;
                            break;
                        case ')':
                            if (counter > 0)
                                --counter;
                            else
                                return new Tuple<bool, int, int>(false, i, 0);
                            break;
                    }
                }
                return counter > 0 ? new Tuple<bool, int, int>(false, -1, counter) : new Tuple<bool, int, int>(true, -1, 0);
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
    
   
        

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }
    }
}
