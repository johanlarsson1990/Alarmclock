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

        
        public void SetHour(int hour)
        {
            Hour = hour;
        }
        public void SetMinute(int minute)
        {
            Minute = minute;
        }
    }
}
