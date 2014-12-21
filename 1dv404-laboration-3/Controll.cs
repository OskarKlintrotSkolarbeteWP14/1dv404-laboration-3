using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _1dv404_laboration_3
{
    public class Controll
    {
        public bool RegExTest(string testString)
        {
            Regex regexLetters = new Regex(@"^([\w]+)[ ]([\w]+)$", RegexOptions.IgnoreCase);
            Regex regexNumbers = new Regex(@"^([^\d]+)[ ]([^\d]+)$", RegexOptions.IgnoreCase);
            Match match = regexLetters.Match(testString);
            Match match2 = regexNumbers.Match(testString);
            if (match.Success && match2.Success)
            {
                return true;
            }
            return false;
        }
        public bool TestBeforeAddingToSchedule(DateTime date, List<string> events, List<string> referee)
        {
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
            else
            {
                foreach (string item in referee)
	            {
                    if (!RegExTest(item))
                    {
                        throw new Exception("Domare " + item + " måste ha både för- och efternamn!");
                    }
	            }
            }
            return true;
        }
    }
}
