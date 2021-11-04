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

        private void ClockHourInput(object sender, EventArgs e) //Tar emot användarens tim-val och ser till så de bara skrivs nummer mellan 0-23.
        {
            Int32.TryParse(clockhourinput.Text, out hourinput);
            if (hourinput < 0)
            {
                clockhourinput.Text = "0";
                errormessage.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (hourinput >= 24)
            {
                clockhourinput.Text = "23";
                errormessage.Text = "!!  Maximum allowed number is 23  !!";
            }

            TextBox textbox = sender as TextBox;
            clockminute.Text = textbox.Text;
        }

        private void MinuteHourInput(object sender, EventArgs e) //Tar emot användarens minut-val och ser till så de bara skrivs nummer mellan 0-59.
        {
            Int32.TryParse(clockminuteinput.Text, out minuteinput);
            if (minuteinput < 0)
            {
                clockminuteinput.Text = "0";
                errormessage.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (minuteinput >= 60)
            {
                clockminuteinput.Text = "59";
                errormessage.Text = "!!  Maximum allowed number is 23  !!";
            }


            TextBox textbox = sender as TextBox;
            clockhour.Text = textbox.Text;
        }

        private void HourOnlyNumbers(object sender, KeyPressEventArgs e) // Ser till så det inte skrivs in bokstäver/andra tecken i Set Hour:
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errormessage.Text = "!!  Please only enter valid numeric numbers.  !!";
            }
        }

        private void MinuteOnlyNumbers(object sender, KeyPressEventArgs e) // Ser till så det inte skrivs in bokstäver/andra tecken i Set Minute:
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errormessage.Text = "!!  Please only enter valid numeric numbers.  !!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // Timer-funktion för Minute-räknare i Klockan.
        {
            clockhour.Text = minuteinput++.ToString();
        }

        private void startButton(object sender, EventArgs e) //Start-knappen till klock-timern.
        {
            if (timer1.Enabled)
            {
                button1.Text = "Start Clock";
                timer1.Stop();
                clockhourinput.ReadOnly = false;
                clockminuteinput.ReadOnly = false;
            }
            else
            {
                button1.Text = "Stop Clock";
                timer1.Start();
                clockhourinput.ReadOnly = true;
                clockminuteinput.ReadOnly = true;
            }
        }
        private void label5_TextChanged(object sender, EventArgs e) // If-sats som inkrementerar Hour med 1 när det blir 60 minuter.
        {
            if (int.Parse(clockhour.Text) == 59)
            {
                minuteinput = 1;
                clockminute.Text = (hourinput + 1).ToString();
            }
        }
    }
}
