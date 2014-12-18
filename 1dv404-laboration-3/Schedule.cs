using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_laboration_3
{
    public class Schedule
    {
        private List<Contest> _schedulelist = new List<Contest>();
        private string FullContest = null;

        private List<Contest> ScheduleList
        {
            get
            {
                return _schedulelist;
            }
            set
            {

            }
        }

        public void Add(Contest value)
        {
            try
            {
                value.Time.ToString();
            }
            catch (Exception)
            {
                throw new Exception("Du måste lägga till ett datum innan du kan spara tävlingen!");
            }
            if (!value.Event.Any())
            {
                throw new Exception("Du måste lägga till grenar innan du kan spara tävlingen!");
            }
            
            if (!value.Event.Any() || !value.Referee.Any())
            {
                throw new Exception("Du måste lägga till domare innan du kan spara tävlingen!");
            }
            
            _schedulelist.Add(value);
        }
        public override string ToString()
        {
            foreach (Contest Con in ScheduleList)
            {
                FullContest = FullContest + Con.ToString();
            }

            return FullContest;
        }
    }
}
