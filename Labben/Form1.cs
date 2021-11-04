using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int hourinput = 0;
        public int minuteinput = 0;
        
        private void ClockHourInput(object sender, EventArgs e)
        {
            Int32.TryParse(textBox1.Text, out hourinput);
            if (hourinput < 0)
            {
                textBox1.Text = "0";
                label7.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (hourinput >= 24)
            {
                textBox1.Text = "23";
                label7.Text = "!!  Maximum allowed number is 23  !!";
            }

            TextBox textbox = sender as TextBox;
            label4.Text = textbox.Text;
        }

        private void MinuteHourInput(object sender, EventArgs e)
        {
            Int32.TryParse(textBox2.Text, out minuteinput);
            if (minuteinput < 0)
            {
                textBox2.Text = "0";
                label7.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (minuteinput >= 60)
            {
                textBox2.Text = "59";
                label7.Text = "!!  Maximum allowed number is 23  !!";
            }


            TextBox textbox = sender as TextBox;
            label5.Text = textbox.Text;
        }

        private void HourOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label7.Text = "!!  Please only enter valid numeric numbers.  !!";
            }
        }

        private void MinuteOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                label7.Text = "!!  Please only enter valid numeric numbers.  !!";
            }
        }
    }
}
