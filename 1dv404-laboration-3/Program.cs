using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv404_laboration_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Contest tavling = new Contest();
            Contest tavling2 = new Contest();
            Schedule season = new Schedule();

            tavling.Referee.Add("Anders");
            tavling.Referee.Add("Hugo");
            tavling.Event.Add("Barr");
            tavling.Event.Add("Ringar");
            tavling.setTime("2015-01-12 12:45");

            tavling2.Referee.Add("Bertil");
            tavling2.Referee.Add("Jönsson");
            tavling2.Event.Add("Häck");
            tavling2.Event.Add("Lina");
            tavling2.setTime("2015-01-18 11:30");

            season.AddContest(tavling.Time, tavling.Event, tavling.Referee);
            season.AddContest(tavling2.Time, tavling2.Event, tavling2.Referee);

            Console.WriteLine(season);
        }
    }
}
