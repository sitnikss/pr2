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

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
