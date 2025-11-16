using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCExam
{
    public class ExamModel
    {
        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }

        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }

        public int GetDifferenceInMinutes()
        {
            int examTime = ExamHour * 60 + ExamMinute;
            int arrivalTime = ArrivalHour * 60 + ArrivalMinute;

            return arrivalTime - examTime;
            
        }

        public string GetStatus()
        {
            int diff = GetDifferenceInMinutes();

            if (diff > 0)
                return "Late";

            if (diff >= -30)
                return "On time";

            return "Early";
        }

        public string GetDetailedMessage()
        {
            int diff = GetDifferenceInMinutes();

            if (diff == 0)
                return "";

            int absDiff = Math.Abs(diff);
            int hours = absDiff / 60;
            int minutes = absDiff % 60;

            if (diff < 0) 
            {
                if (hours == 0)
                    return $"{minutes} minutes before the start";

                return $"{hours}:{minutes:D2} hours before the start";
            }
            else 
            {
                if (hours == 0)
                    return $"{minutes} minutes after the start";

                return $"{hours}:{minutes:D2} hours after the start";
            }
        }
    }
}
