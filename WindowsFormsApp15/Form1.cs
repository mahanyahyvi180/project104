using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textBox1.Text);

            switch (x % 2)
            {
                case 0:
                    lable3.Text = "Even";
                    break;

                case 1:
                    lable3.Text = "Odd";
                    break;

                case 2:
                    lable3.Text = "Invalid number";
                    break;
            }
        }
    }
}
