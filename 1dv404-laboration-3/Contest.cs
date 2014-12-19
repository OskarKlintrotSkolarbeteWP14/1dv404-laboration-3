using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_laboration_3
{
    public class Contest
    {
        private DateTime _time;
        private List<string> _event = new List<string>();
        private List<string> _referee = new List<string>();
        private string FullContest = null;

        public DateTime Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (value.Year == 0001)
                {
                    throw new Exception("Datumet är inte satt!");
                }
                _time = value;
            }
        }

        public List<string> Event
        {
            get { return _event; }
        }
        public List<string> Referee
        {
            get { return _referee; }
        }

        public void setTime(string date)
        {
            Time = DateTime.ParseExact(date, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            FullContest = "Grenar:\n";
            foreach (string Eve in Event)
            {
                FullContest = FullContest + Eve + "\n";
            }

            FullContest = FullContest + "\nDomare:\n";
            foreach (string Ref in Referee)
            {
                FullContest = FullContest + Ref + "\n";
            }

            FullContest = FullContest + "\nDatum:\n" + Time.ToString("f") + "\n";
            return FullContest;
        }
    }
}
