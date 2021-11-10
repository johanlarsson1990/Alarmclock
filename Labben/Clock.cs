using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labben
{
    public class Clock : IClock 
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Time { get; set; }

        public int GetHours()
        {
            return Hour;
        }

        public int GetMinutes()
        {
            return Minute;
        }
        public void SetHour(int hour)
        {
            Hour = hour;
        }
        public void SetMinute(int minute)
        {
            Minute = minute;
        }

        public void SetTime(/*int hour, int minute*/)
        {
            //Hour = hour;
            //Minute = minute;
            Time = Hour + Minute ;
            //return Time;
        }

        public void StartClock()
        {
            throw new NotImplementedException();
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }
     
    }
}
