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
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderColor = BackColor;
            button3.FlatAppearance.MouseOverBackColor = BackColor;
            button3.FlatAppearance.MouseDownBackColor = BackColor;
        }
        public bool setalarm = false;
        public int hourinput = 0;
        public int minuteinput = 0;
        public int alarmhour = 0;
        public int alarmminute = 0;

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
            clockhour.Text = textbox.Text;
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
            clockminute.Text = textbox.Text;
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
            int count = alarmminute + 10;
            clockminute.Text = minuteinput++.ToString();
            if(int.Parse(clockminute.Text) >= alarmminute && int.Parse(clockminute.Text) == count)
            {
               // this.webBrowser1.DocumentText = "";
                errormessage.Text = "";
                setalarm = false;
            }
            
            if (alarmhour == int.Parse(clockhour.Text) & alarmminute == int.Parse(clockminute.Text) & setalarm == true)
            {
                errormessage.Text = "WAKI WAKI HANDS OFF SNAKEY!!!!";
                var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head><body>" +
                "<iframe width=\"620\" height=\"340\" src=\"{0}\"" +
                "frameborder = \"0\" allow =\"autoplay;loop; encrypted-media\" allowfullscreen></iframe>" +
                "</body></html>";
                var url = "https://www.youtube.com/embed/iik25wqIuFo?autoplay=1&loop=1&playlist=iik25wqIuFo";
                this.webBrowser1.DocumentText = string.Format(embed, url);
            }
        }

        private void startButton(object sender, EventArgs e) //Start-knappen till klock-timern.
        {
            if (timer1.Enabled)
            {
                button1.Text = "Start Clock";
                timer1.Stop();
                clockhourinput.ReadOnly = false;
                clockminuteinput.ReadOnly = false;
                clockhour.Text = clockhourinput.Text.ToString();
                clockminute.Text = clockminuteinput.Text.ToString();
                minuteinput = int.Parse(clockminuteinput.Text);
                hourinput = int.Parse(clockhourinput.Text);
            }
            else
            {
                button1.Text = "Stop Clock";
                timer1.Start();
                clockhourinput.ReadOnly = true;
                clockminuteinput.ReadOnly = true;
            }
        }
        private void setAlarm(object sender, EventArgs e)
        {
            if (setalarm)
            {
                setalarm = false;
                button2.Text = "Start Alarm";
               // timer1.Stop();
                alarmHinput.ReadOnly = false;
                alarmMinput.ReadOnly = false;
                errormessage.Text = ""; 
            }
            else
            {
                setalarm = true;
                button2.Text = "Unset Alarm";
              //  timer1.Start();
                alarmHinput.ReadOnly = true;
                alarmMinput.ReadOnly = true;   
            }
        }
        private void AddHourIfMin60(object sender, EventArgs e) // If-sats som inkrementerar Hour med 1 när det blir 60 minuter.
        {
            try
            {
                if (int.Parse(clockminute.Text) == 59)
                {
                    minuteinput = 0;
                }
                if (int.Parse(clockminute.Text) == 0)
                {
                    int addonehour = ++hourinput;
                    clockhour.Text = (addonehour).ToString();
                }
            }
            catch (Exception)
            {

            }
        }

        private void RestartHourIf24(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(clockhour.Text) == 24)
                {
                    hourinput = 0;
                    clockhour.Text = hourinput.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
 
        private void alarmHourInput(object sender, EventArgs e)
        {
            Int32.TryParse(alarmHinput.Text, out alarmhour);
            if (alarmhour < 0)
            {
                alarmHinput.Text = "0";
                errormessage.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (alarmhour >= 24)
            {
                alarmHinput.Text = "23";
                errormessage.Text = "!!  Maximum allowed number is 23  !!";
            }

            TextBox textbox = sender as TextBox;
            alarmHinput.Text = textbox.Text;
        }

        private void alarmMinuteInput(object sender, EventArgs e)
        {
            Int32.TryParse(alarmMinput.Text, out alarmminute);
            if (alarmminute < 0)
            {
                alarmMinput.Text = "0";
                errormessage.Text = "!!  Minimum allowed number is 0  !!";
            }
            else if (alarmminute >= 60)
            {
                alarmMinput.Text = "59";
                errormessage.Text = "!!  Maximum allowed number is 23  !!";
            }


            TextBox textbox = sender as TextBox;
            alarmMinput.Text = textbox.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.webBrowser1.DocumentText = "";
        }
    }
}
