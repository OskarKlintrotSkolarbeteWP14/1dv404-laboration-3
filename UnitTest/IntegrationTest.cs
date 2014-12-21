using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTest
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void SaveCompleteContestToScheduleWithControll()
        {
            #region Initiate

            Contest testContest = new Contest();
            Schedule testSchedule = new Schedule();
            Control testControll = new Control();

            testContest.setTime("2015-05-12 11:45");
            
            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            testContest.Referee.Add("Anna Brämström");
            testContest.Referee.Add("Carolina Klüft");

            #endregion

            #region Test

            try
            {
                if (testControll.TestBeforeAddingToSchedule(testContest.Time, testContest.Event, testContest.Referee))
                {
                    testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
                }
            }

            #endregion

            #region Assert

            catch (Exception)
            {
                Assert.Fail("Ett undantag kastades.");
            }
            
            #endregion
        }

        [TestMethod]
        public void SaveContestWithEmptyTimeToScheduleWithControll()
        {
            #region Initiate

            Contest testContest = new Contest();
            Schedule testSchedule = new Schedule();
            Control testControll = new Control();

            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            testContest.Referee.Add("Anna Brämström");
            testContest.Referee.Add("Carolina Klüft");

            #endregion

            #region Test

            try
            {
                if (testControll.TestBeforeAddingToSchedule(testContest.Time, testContest.Event, testContest.Referee))
                {
                    testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
                }
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Ett undantag kastades.");

            #endregion
        }

        [TestMethod]
        public void SaveContestWithEmptyEventToScheduleWithControll()
        {
            #region Initiate

            Contest testContest = new Contest();
            Schedule testSchedule = new Schedule();
            Control testControll = new Control();

            testContest.setTime("2015-05-12 11:45");

            testContest.Referee.Add("Anna Brämström");
            testContest.Referee.Add("Carolina Klüft");

            #endregion

            #region Test

            try
            {
                if (testControll.TestBeforeAddingToSchedule(testContest.Time, testContest.Event, testContest.Referee))
                {
                    testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
                }
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Ett undantag kastades.");

            #endregion
        }

        [TestMethod]
        public void SaveContestWithBadRefereeNamesToScheduleWithControll()
        {
            #region Initiate

            Contest testContest = new Contest();
            Schedule testSchedule = new Schedule();
            Control testControll = new Control();

            testContest.setTime("2015-05-12 11:45");

            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            testContest.Referee.Add("Anna L33t");
            testContest.Referee.Add("N00b Klüft");

            #endregion

            #region Test

            try
            {
                if (testControll.TestBeforeAddingToSchedule(testContest.Time, testContest.Event, testContest.Referee))
                {
                    testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
                }
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Ett undantag kastades.");

            #endregion
        }

        [TestMethod]
        public void SaveContestWithEmptyRefereeNamesToScheduleWithControll()
        {
            #region Initiate

            Contest testContest = new Contest();
            Schedule testSchedule = new Schedule();
            Control testControll = new Control();

            testContest.setTime("2015-05-12 11:45");

            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            #endregion

            #region Test

            try
            {
                if (testControll.TestBeforeAddingToSchedule(testContest.Time, testContest.Event, testContest.Referee))
                {
                    testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
                }
            }
            catch (Exception)
            {
                return;
            }

            #endregion

            #region Assert

            Assert.Fail("Ett undantag kastades.");

            #endregion
        }
    }
}
