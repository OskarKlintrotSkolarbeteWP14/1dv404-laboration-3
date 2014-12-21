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
        #region Methods

        /// <summary>
        /// Check if the string contains a full name or not
        /// </summary>
        /// <param name="testString"></param>
        /// <returns>If the string contains a full name with a first name and a last name, return true</returns>
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

        /// <summary>
        /// Validates the variables that's being added to the schedule.
        /// </summary>
        /// <param name="date">The date and time when the contest is being held</param>
        /// <param name="events">The events for the contest</param>
        /// <param name="referee">The referees for the contest</param>
        /// <returns>Method is true if the DateTime and List's are correct and could be added to a schedule</returns>
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

        #endregion
    }
}
