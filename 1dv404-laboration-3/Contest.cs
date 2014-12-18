﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_laboration_3
{
    class Contest
    {
        private DateTime _time;
        private List<string> _event = new List<string>();
        private List<string> _referee = new List<string>();
        private string FullContest = null;

        public string Time
        {
            get
            {
                if (_time.Year == 0001)
                {
                    throw new Exception("Datumet är inte satt!");
                }

                return _time.ToString("f");
            }
            set
            {
                _time = DateTime.ParseExact(value, "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
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

            FullContest = FullContest + "\nDatum:\n" + Time + "\n";
            return FullContest;
        }
    }
}
