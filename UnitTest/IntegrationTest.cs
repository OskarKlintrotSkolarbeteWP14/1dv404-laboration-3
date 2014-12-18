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
        public void TestSaveCompleteContest()
        {
            #region Initiate

            Contest StubContest = new Contest();

            StubContest.Time = "2015-05-12 11:45";
            
            StubContest.Event.Add("Barr");
            StubContest.Event.Add("Trampets");

            StubContest.Referee.Add("Anna");
            StubContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.Add(StubContest);
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
        public void TestSaveContestWithEmptyTime()
        {
            #region Initiate

            Contest StubContest = new Contest();

            StubContest.Event.Add("Barr");
            StubContest.Event.Add("Trampets");

            StubContest.Referee.Add("Anna");
            StubContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.Add(StubContest);
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
        public void TestSaveContestWithEmptyEvent()
        {
            #region Initiate

            Contest StubContest = new Contest();

            StubContest.Time = "2015-05-12 11:45";

            StubContest.Referee.Add("Anna");
            StubContest.Referee.Add("Sara");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.Add(StubContest);
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
        public void TestSaveContestWithEmptyReferee()
        {
            #region Initiate

            Contest StubContest = new Contest();

            StubContest.Time = "2015-05-12 11:45";

            StubContest.Event.Add("Barr");
            StubContest.Event.Add("Trampets");

            Schedule testSchedule = new Schedule();

            #endregion

            #region Test

            try
            {
                testSchedule.Add(StubContest);
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
