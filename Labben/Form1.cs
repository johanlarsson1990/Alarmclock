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
            errormessage.ForeColor = Color.Red;
        }
        public bool setalarm = false;
        //public int hourInput = 00;
        //public int minuteInput = 00;
        public int alarmhour = 00;
        public int alarmminute = 00;
        Clock clock = new Clock();
        
        private void ClockHourInput(object sender, EventArgs e) //Tar emot användarens tim-val och ser till så de bara skrivs nummer mellan 0-23.
        {
            try
            {
                Hour hour = new Hour();
                hour.HourValue = Convert.ToInt32(clockHourInput.Text);
                clock.SetHour(hour.HourValue);
                //Int32.TryParse(clockHourInput.Text, out hourInput);
                if (hour.HourValue < 0)
                {
                    clockHourInput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                }
                else if (hour.HourValue >= 24)
                {
                    clockHourInput.Text = "23";
                    errormessage.Text = "!!  Maximum allowed number is 23  !!";
                }

                TextBox textbox = sender as TextBox;
                clockhour.Text = textbox.Text;

            }
           catch (Exception) { }
        }

        private void ClockMinuteInput(object sender, EventArgs e) //Tar emot användarens minut-val och ser till så de bara skrivs nummer mellan 0-59.
        {
            try
            {
                Minute minute = new Minute();
                minute.MinuteValue = Convert.ToInt32(clockMinuteInput.Text);
                clock.SetMinute(minute.MinuteValue);
                //Int32.TryParse(clockMinuteInput.Text, out minuteInput);
                if (minute.MinuteValue < 0)
                {
                    clockMinuteInput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                }
                else if (minute.MinuteValue >= 60)
                {
                    clockMinuteInput.Text = "59";
                    errormessage.Text = "!!  Maximum allowed number is 59  !!";
                }
                TextBox textbox = sender as TextBox;
                clockminute.Text = textbox.Text;

            }
            catch (Exception) { }
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e) // Ser till så det inte skrivs in bokstäver/andra tecken i Set Hour & Set Minute:
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errormessage.Text = "!!  Please only enter valid numeric numbers.  !!";
            }
        }

        //private void MinuteOnlyNumbers(object sender, KeyPressEventArgs e) // Ser till så det inte skrivs in bokstäver/andra tecken i Set Minute:
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //        errormessage.Text = "!!  Please only enter valid numeric numbers.  !!";
        //    }
        //}

        private void timer1_Tick(object sender, EventArgs e) // Timer-funktion för Minute-räknare i Klockan.
        {
            var hourString = clock.Hour < 9 ? "0" + clock.Hour : clock.Hour.ToString();
            var minuteString = clock.Minute > 9 ? clock.Minute++.ToString() : "0" + clock.Minute++;
            int count = alarmminute + 10;
            clockminute.Text = minuteString;
            clockhour.Text = hourString;
            if(int.Parse(clockminute.Text) >= alarmminute && int.Parse(clockminute.Text) == count)
            {
               this.webBrowser1.DocumentText = "";
                errormessage.Text = "";
                setalarm = false;
            }
            
            if (alarmhour == int.Parse(clockhour.Text) & alarmminute == int.Parse(clockminute.Text) & setalarm == true)
            {
                Alarm alarm = new Alarm();
                var test = alarm.AlarmFunction();
                errormessage.Text = "WAKI WAKI HANDS OFF SNAKEY!!!!";
                //var embed = "<html><head>" +
                //"<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                //"</head><body>" +
                //"<iframe width=\"620\" height=\"340\" src=\"{0}\"" +
                //"frameborder = \"0\" allow =\"autoplay;loop; encrypted-media\" allowfullscreen></iframe>" +
                //"</body></html>";
                //var url = "https://www.youtube.com/embed/iik25wqIuFo?autoplay=1&loop=1&playlist=iik25wqIuFo";

                this.webBrowser1.DocumentText = string.Format(test[0],test[1]);
                
                
                

            }
        }

        private void startButton(object sender, EventArgs e) //Start-knappen till klock-timern.
        {
            try
            {
                if(timer1.Enabled)
                {
                    button1.Text = "Start Clock";
                    timer1.Stop();
                    clockHourInput.ReadOnly = false;
                    clockMinuteInput.ReadOnly = false;
                    clockhour.Text = clockHourInput.Text.ToString();
                    clockminute.Text = clockMinuteInput.Text.ToString();
                    //minuteInput = int.Parse(clockMinuteInput.Text);
                    //hourInput = int.Parse(clockHourInput.Text);
                    clock.Minute = int.Parse(clockMinuteInput.Text);
                    clock.Hour = int.Parse(clockHourInput.Text);
                }
                else
                {
                    button1.Text = "Stop Clock";
                    timer1.Start();
                    clockHourInput.ReadOnly = true;
                    clockMinuteInput.ReadOnly = true;
                }

            }
            catch (Exception)
            {
                
                
            }
        }
        private void SetAlarm(object sender, EventArgs e)
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
                if (int.Parse(clockminute.Text) == 59 && timer1.Enabled)
                {
                    clock.Minute = 0;
                    int addonehour = clock.Hour++;
                    clockhour.Text = (addonehour).ToString();
                }
                if (int.Parse(clockhour.Text) == 23 && int.Parse(clockminute.Text) >= 59 && timer1.Enabled)
                {
                    clock.Hour = 0;
                    clock.Minute = 0;
                    clockhour.Text = "00";
                    clockminute.Text = "00";
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
                    clock.Hour = 0;
                    //clockhour.Text = hourInput.ToString();
                    clockhour.Text = clock.Hour.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
 
        private void AlarmHourInput(object sender, EventArgs e)
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

        private void AlarmMinuteInput(object sender, EventArgs e)
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
                errormessage.Text = "!!  Maximum allowed number is 59  !!";
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
