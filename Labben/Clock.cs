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

        public int SetTime(int hour, int minute)
        {
            Hour = hour;
            Minute = minute;
            Time = Hour + Minute ;
            return Time;
        }

        public void StartClock()
        {
            throw new NotImplementedException();
        }

        public void StopClock()
        {
            throw new NotImplementedException();
        }
        public List<string> AlarmFunction()
        {
            var listOfAlarm = new List<string>();
            var embed = "<html><head>" +
                "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                "</head><body>" +
                "<iframe width=\"620\" height=\"340\" src=\"{0}\"" +
                "frameborder = \"0\" allow =\"autoplay;loop; encrypted-media\" allowfullscreen></iframe>" +
                "</body></html>";
            var url = "https://www.youtube.com/embed/iik25wqIuFo?autoplay=1&loop=1&playlist=iik25wqIuFo";
            listOfAlarm.Add(embed);
            listOfAlarm.Add(url);

            return listOfAlarm;
        }
    }
}
