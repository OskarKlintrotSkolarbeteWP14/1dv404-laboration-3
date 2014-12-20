using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;
using System.Diagnostics;

namespace UnitTest
{
    [TestClass]
    public class UniTestSchedule
    {
        [TestMethod]
        public void ScheduleListComplete()
        {
            #region Initiate
            
            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();
            string excpectedTestScheduleToString;

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
            Event.Add("Barr");
            Event.Add("Trampets");

            Referee.Add("Anna");
            Referee.Add("Sara");

            excpectedTestScheduleToString = "den 12 maj 2015 11:45\nGrenar:\nBarr\nTrampets\n\nDomare:\nAnna\nSara\n\n";

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            testSchedule.AddContest(Time, Event, Referee);

            #endregion

            #region Assert

            Assert.AreEqual(excpectedTestScheduleToString, testSchedule.ToString());
            
            #endregion
        }
        [TestMethod]
        public void ScheduleListWithEmptyEvent()
        {
            #region Initiate

            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();
            string excpectedResult = "den 12 maj 2015 11:45\nGrenar:\n\nDomare:\nAnna\nSara\n\n";
            
            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            Referee.Add("Anna");
            Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            testSchedule.AddContest(Time, Event, Referee);

            #endregion

            #region Assert

            Assert.AreEqual(excpectedResult, testSchedule.ToString());

            #endregion
        }
        [TestMethod]
        public void ScheduleListWithEmptyReferee()
        {
            #region Initiate

            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();
            string excpectedResult = "den 12 maj 2015 11:45\nGrenar:\nBarr\nTrampets\n\nDomare:\n\n";

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
            Event.Add("Barr");
            Event.Add("Trampets");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            testSchedule.AddContest(Time, Event, Referee);
            
            #endregion

            #region Assert

            Assert.AreEqual(excpectedResult, testSchedule.ToString());

            #endregion
        }
    }
}
