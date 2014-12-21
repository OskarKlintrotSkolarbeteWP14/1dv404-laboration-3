using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_laboration_3
{
    public class Contest
    {
        #region Fields
        
        private DateTime _time;
        private List<string> _event = new List<string>();
        private List<string> _referee = new List<string>();
        private string FullContest = null;
        
        #endregion

        #region Properties
        
        /// <summary>
        /// Property sorrunding the _time field
        /// </summary>
        public DateTime Time
        {
            //If now date is set, throw an exception!
            get
            {
                if (_time.Year == 0001)
                {
                    throw new Exception("Datumet är inte satt!");
                }
                return _time;
            }

            set
            {
                _time = value;
            }
        }
        /// <summary>
        /// Property sorrunding the _event field
        /// </summary>
        public List<string> Event
        {
            get { return _event; }
        }
        /// <summary>
        /// Property sorrunding the _referee field
        /// </summary>
        public List<string> Referee
        {
            get { return _referee; }
        }

        #endregion

        #region Methods
        /// <summary>
        /// Sets the time of the contest
        /// </summary>
        /// <param name="date">The date and time when the contest is behing held, written as "yyyy-MM-dd HH:mm"</param>
        public void setTime(string date)
        {
            Time = DateTime.ParseExact(date, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
        }
        /// <summary>
        /// Override base class method
        /// </summary>
        /// <returns>The whole contest as a string</returns>
        public override string ToString()
        {
            //Add each event to the FullContest-string
            FullContest = "Grenar:\n";
            foreach (string Eve in Event)
            {
                FullContest = FullContest + Eve + "\n";
            }
            
            //Add each referee to the FullContest-string
            FullContest = FullContest + "\nDomare:\n";
            foreach (string Ref in Referee)
            {
                FullContest = FullContest + Ref + "\n";
            }

            //Add date to the FullContest-string
            FullContest = FullContest + "\nDatum:\n" + Time.ToString("f") + "\n";
            return FullContest;
        }

        #endregion
    }
}
