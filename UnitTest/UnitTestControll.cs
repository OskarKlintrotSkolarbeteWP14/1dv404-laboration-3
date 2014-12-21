using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;

namespace UnitTest
{
    [TestClass]
    public class UnitTestControll
    {
        [TestMethod]
        public void TestBeforeAddingToSchedule()
        {
            #region Initiate

            Control testControll = new Control();
            bool TestSucced;
            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);

            Event.Add("Barr");
            Event.Add("Trampets");

            Referee.Add("Anna Karlsson");
            Referee.Add("Sara Gästriksson");

            #endregion

            #region Test

            TestSucced = testControll.TestBeforeAddingToSchedule(Time, Event, Referee);

            #endregion

            #region Assert

            Assert.IsTrue(TestSucced, "Testet misslyckades");

            #endregion
        }
        [TestMethod]
        public void TestBeforeAddingToScheduleWithoutCompleteNames()
        {
            #region Initiate

            Control testControll = new Control();
            bool TestSucced;
            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);

            Event.Add("Barr");
            Event.Add("Trampets");

            Referee.Add("Anna");
            Referee.Add("Gästriksson");

            #endregion

            #region Test

            try
            {
                TestSucced = testControll.TestBeforeAddingToSchedule(Time, Event, Referee);
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Testet misslyckades");

            #endregion
        }
        [TestMethod]
        public void TestBeforeAddingToScheduleWithoutEvents()
        {
            #region Initiate

            Control testControll = new Control();
            bool TestSucced;
            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();

            Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);

            Referee.Add("Anna Karlsson");
            Referee.Add("Karl Gästriksson");

            #endregion

            #region Test

            try
            {
                TestSucced = testControll.TestBeforeAddingToSchedule(Time, Event, Referee);
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Testet misslyckades");

            #endregion
        }
        [TestMethod]
        public void TestBeforeAddingToScheduleWithoutTime()
        {
            #region Initiate

            Control testControll = new Control();
            bool TestSucced;
            DateTime Time;
            List<string> Event = new List<string>();
            List<string> Referee = new List<string>();

            Time = DateTime.ParseExact("0001", "yyyy",
                                       System.Globalization.CultureInfo.InvariantCulture);

            Event.Add("Barr");
            Event.Add("Trampets");

            Referee.Add("Anna Karlsson");
            Referee.Add("Karl Gästriksson");

            #endregion

            #region Test

            try
            {
                TestSucced = testControll.TestBeforeAddingToSchedule(Time, Event, Referee);
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Testet misslyckades");

            #endregion
        }
    }
}
