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
            Alarm1message.ForeColor = Color.Red;
            alarm2message.ForeColor = Color.Red;
        }
        public bool setalarm = false;
        public bool setalarm2 = false;
        Clock clock = new Clock();
        Alarm alarm1 = new Alarm();
        Alarm alarm2 = new Alarm();
        
        
        private void ClockHourInput(object sender, EventArgs e) //Tar emot användarens tim-val och ser till så de bara skrivs nummer mellan 0-23.
        {
            try
            {
                Hour hour = new Hour();
                hour.HourValue = Convert.ToInt32(clockHourInput.Text);
                
                if (hour.HourValue >= 0 && hour.HourValue < 24)
                {
                    clock.SetHour(hour.HourValue);
                }
                else if (hour.HourValue < 0)
                {
                    clockHourInput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                    clock.SetHour(0);
                }
                else if (hour.HourValue >= 24)
                {
                    clockHourInput.Text = "23";
                    errormessage.Text = "!!  Maximum allowed number is 23  !!";
                    clock.SetHour(23);
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

                if (minute.MinuteValue >= 0 && minute.MinuteValue < 60)
                {
                    clock.SetMinute(minute.MinuteValue);
                }
                else if (minute.MinuteValue < 0)
                {
                    clockMinuteInput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                    clock.SetMinute(0);
                }
                else if (minute.MinuteValue >= 60)
                {
                    clockMinuteInput.Text = "59";
                    errormessage.Text = "!!  Maximum allowed number is 59  !!";
                    clock.SetMinute(59);
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

        private void timer1_Tick(object sender, EventArgs e) // Timer-funktion för Minute-räknare i Klockan.
        {
            var hourString = clock.Hour < 9 ? "0" + clock.Hour : clock.Hour.ToString();
            var minuteString = clock.Minute > 9 ? clock.Minute++.ToString() : "0" + clock.Minute++;
            int count = alarm1.AlarmMinute + 10;
            int count2 = alarm2.AlarmMinute + 10;
            clockminute.Text = minuteString;
            clockhour.Text = hourString;
            AddHourIfMin60();
            //alarm1.SetAlarm(alarm1.AlarmHour, alarm1.AlarmMinute);
            //alarm2.SetAlarm(alarm2.AlarmHour, alarm2.AlarmMinute);
            //setalarm = alarm1.CheckAlarm(int.Parse(clockhour.Text), int.Parse(clockminute.Text));
            //setalarm2 = alarm2.CheckAlarm(int.Parse(clockhour.Text), int.Parse(clockminute.Text));
            
            if(int.Parse(clockminute.Text) >= alarm1.AlarmMinute && int.Parse(clockminute.Text) == count) //Stänger av larm
            {
                Alarm1message.Text = "";
                setalarm = false;
                this.webBrowser1.DocumentText = "";
            }
            
            if (alarm1.AlarmHour == int.Parse(clockhour.Text) & alarm1.AlarmMinute == int.Parse(clockminute.Text) & setalarm == true)
            {
                Alarm alarm = new Alarm();
                var test = alarm.AlarmFunction();
                Alarm1message.Text = "WAKI WAKI HANDS OFF SNAKEY!!!!";
                this.webBrowser1.DocumentText = string.Format(test[0],test[1]);
            }
            if (int.Parse(clockminute.Text) >= alarm2.AlarmMinute && int.Parse(clockminute.Text) == count2)
            {
                alarm2message.Text = "";
                setalarm2 = false;
            }

            if (alarm2.AlarmHour == int.Parse(clockhour.Text) & alarm2.AlarmMinute == int.Parse(clockminute.Text) & setalarm2 == true)
            {
                Alarm alarm2 = new Alarm();
                var test2 = alarm2.AlarmFunction();
                alarm2message.Text = "För att stänga av ljudet, hitta knappen";
                this.webBrowser1.DocumentText = string.Format(test2[0], test2[1]);
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
                alarmHinput.ReadOnly = false;
                alarmMinput.ReadOnly = false;
                errormessage.Text = ""; 
            }
            else
            {
                setalarm = true;
                button2.Text = "Unset Alarm";
                alarmHinput.ReadOnly = true;
                alarmMinput.ReadOnly = true;   
            }
        }
        private void AddHourIfMin60() // If-sats som inkrementerar Hour med 1 när det blir 60 minuter.
        {
            try
            {
                if (int.Parse(clockminute.Text) == 59 && timer1.Enabled)
                {
                    clock.Minute = 0;
                    int addonehour = clock.Hour++;
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
                    clock.Hour = 0;
                    clockhour.Text = "00";
                }
            }
            catch (Exception)
            {

            }
        }

        private void AlarmHourInput(object sender, EventArgs e)
        {
            try
            {
                alarm1.AlarmHour = Convert.ToInt32(alarmHinput.Text);
                if (alarm1.AlarmHour < 0)
                {
                    alarmHinput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                    
                }
                else if (alarm1.AlarmHour >= 24)
                {
                    alarmHinput.Text = "23";
                    errormessage.Text = "!!  Maximum allowed number is 23  !!";
                    
                }

                TextBox textbox = sender as TextBox;
                alarmHinput.Text = textbox.Text;
            }
            catch (Exception)
            {

            }
        
        }

        private void AlarmMinuteInput(object sender, EventArgs e)
        {
            try
            {
                alarm1.AlarmMinute = Convert.ToInt32(alarmMinput.Text);
                if (alarm1.AlarmMinute < 0)
                {
                    alarmMinput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                    
                }
                else if (alarm1.AlarmMinute >= 60)
                {
                    alarmMinput.Text = "59";
                    errormessage.Text = "!!  Maximum allowed number is 59  !!";
                }
                TextBox textbox = sender as TextBox;
                alarmMinput.Text = textbox.Text;
            }
            catch (Exception)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.webBrowser1.DocumentText = "";
        }

        private void SetAlarm2(object sender, EventArgs e)
        {
            if (setalarm2)
            {
                setalarm2 = false;
                button4.Text = "Start Alarm";
                alarm2Hinput.ReadOnly = false;
                alarm2Minput.ReadOnly = false;
                errormessage.Text = "";
            }
            else
            {
                setalarm2 = true;
                button4.Text = "Unset Alarm";
                alarm2Hinput.ReadOnly = true;
                alarm2Minput.ReadOnly = true;
            }
        }

        private void Alarm2HourInput(object sender, EventArgs e)
        {
            try
            {
                alarm2.AlarmHour = Convert.ToInt32(alarm2Hinput.Text);
                if (alarm2.AlarmHour < 0)
                {
                    alarm2Hinput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                }
                else if (alarm2.AlarmHour >= 24)
                {
                    alarm2Hinput.Text = "23";
                    errormessage.Text = "!!  Maximum allowed number is 23  !!";
                }

                TextBox textbox = sender as TextBox;
                alarm2Hinput.Text = textbox.Text;
            }
            catch (Exception)
            {
            }
        }

        private void Alarm2MinuteInput(object sender, EventArgs e)
        {
            try
            {
                alarm2.AlarmMinute = Convert.ToInt32(alarm2Minput.Text);
                if (alarm2.AlarmMinute < 0)
                {
                    alarm2Minput.Text = "0";
                    errormessage.Text = "!!  Minimum allowed number is 0  !!";
                }
                else if (alarm2.AlarmMinute >= 60)
                {
                    alarm2Minput.Text = "59";
                    errormessage.Text = "!!  Maximum allowed number is 59  !!";
                }

                TextBox textbox = sender as TextBox;
                alarm2Minput.Text = textbox.Text;
            }
            catch (Exception)
            {
            }
        }
    }
}
