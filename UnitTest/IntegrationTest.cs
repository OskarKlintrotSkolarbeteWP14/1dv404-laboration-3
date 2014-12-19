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
        public void SaveCompleteContestToSchedule()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.setTime("2015-05-12 11:45");
            
            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            testContest.Referee.Add("Anna");
            testContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
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
        public void SaveContestWithEmptyTimeToSchedule()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            testContest.Referee.Add("Anna");
            testContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
            }
            catch (Exception)
            {
                return;
            }
            #endregion

            #region Assert

            Assert.Fail();

            #endregion
        }

        [TestMethod]
        public void SaveContestWithEmptyEventToSchedule()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.setTime("2015-05-12 11:45");

            testContest.Referee.Add("Anna");
            testContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
            }
            catch (Exception)
            {
                return;
            }
            #endregion

            #region Assert

            Assert.Fail();

            #endregion
        }

        [TestMethod]
        public void SaveContestWithEmptyReferee()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.setTime("2015-05-12 11:45");

            testContest.Event.Add("Barr");
            testContest.Event.Add("Trampets");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.AddContest(testContest.Time, testContest.Event, testContest.Referee);
            }
            catch (Exception)
            {
                return;
            }
            #endregion

            #region Assert

            Assert.Fail();

            #endregion
        }
    }
}
