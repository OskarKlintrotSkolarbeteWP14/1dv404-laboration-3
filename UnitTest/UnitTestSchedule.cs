using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;
using Microsoft.QualityTools.Testing.Fakes;

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

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
            Event.Add("Barr");
            Event.Add("Trampets");

            Referee.Add("Anna");
            Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(Time, Event, Referee);
            }

            #endregion

            #region Assert

            catch (Exception)
            {

                Assert.Fail();
            }

            #endregion
        }
        [TestMethod]
        public void ScheduleListWithEmptyEvent()
        {
            #region Initiate

            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();
            
            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            Referee.Add("Anna");
            Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(Time, Event, Referee);
            }

            #endregion

            #region Assert

            catch (Exception)
            {
                return;
            }

            Assert.Fail();

            #endregion
        }
        [TestMethod]
        public void ScheduleListWithEmptyReferee()
        {
            #region Initiate

            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            
            Event.Add("Barr");
            Event.Add("Trampets");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(Time, Event, Referee);
            }

            #endregion

            #region Assert

            catch (Exception)
            {
                return;
            }

            Assert.Fail();

            #endregion
        }

    }
}
