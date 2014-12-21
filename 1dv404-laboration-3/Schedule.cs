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
        #region Fields

        private List<string[]> _schedulelist = new List<string[]>();
        private string FullContest = null;

        #endregion

        #region Properties

        /// <summary>
        /// Property sorrunding the _schedulelist field
        /// </summary>
        private List<string[]> ScheduleList
        {
            get { return _schedulelist; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adding a new contest to the schedule
        /// </summary>
        /// <param name="date">The date and time when the contest is being held</param>
        /// <param name="events">The events for the contest</param>
        /// <param name="referee">The referees for the contest</param>
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

        /// <summary>
        /// Override base class method
        /// </summary>
        /// <returns>Returns the schedule as a string</returns>
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

        #endregion
    }
}