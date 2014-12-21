using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace _1dv404_laboration_3
{
    public class Schedule
    {
        private List<string[]> _schedulelist = new List<string[]>();
        private string FullContest = null;

        private List<string[]> ScheduleList
        {
            get { return _schedulelist; }
        }

        public void AddContest(DateTime date, List<string> events, IList<string> referee)
        {
            string[] newContest = new string[3];
            string eventsString;
            string refereeString;

            eventsString = "Grenar:\n";
            foreach (string item in events)
            {
                eventsString = eventsString + item + "\n";
            }

            refereeString = "Domare:\n";
            foreach (string item in referee)
            {
                refereeString = refereeString + item + "\n";
            }

            newContest[0] = date.ToString("f");
            newContest[1] = eventsString;
            newContest[2] = refereeString;

            ScheduleList.Add(newContest);
        }

        public override string ToString()
        {
            foreach (string[] item in ScheduleList)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    FullContest = FullContest + item[i].ToString() + "\n";
                }    
            }

            return FullContest;
        }
    }
}
