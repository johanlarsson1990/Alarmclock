using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labben
{
    class Alarm
    {
        public int AlarmHour { get; set; }
        public int AlarmMinute { get; set; }
        
        public Alarm()
        {

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
