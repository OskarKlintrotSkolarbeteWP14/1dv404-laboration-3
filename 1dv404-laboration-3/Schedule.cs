using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddContest(DateTime date, List<string> events,List<string> referee)
        {
            string[] newContest = new string[3];
            string eventsString;
            string refereeString;

            if (date.Year == 0001)
            {
                throw new Exception("Du måste lägga till ett datum innan du kan spara tävlingen!");
            }
            if (!events.Any())
            {
                throw new Exception("Du måste lägga till grenar innan du kan spara tävlingen!");
            }
            
            if (!referee.Any())
            {
                throw new Exception("Du måste lägga till domare innan du kan spara tävlingen!");
            }

            //List<string> newContest = new List<string>();

            //newContest.Add(date.ToString("f"));

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
