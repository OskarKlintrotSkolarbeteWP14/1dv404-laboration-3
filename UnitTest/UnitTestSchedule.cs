using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTest
{
    //public interface IContest
    //{
    //    public DateTime Time;
    //    public List<string> Event = new List<string>();
    //    public List<string> Referee = new List<string>();
    //    public string FullContest = null;
    //}

    [TestClass]
    public class UniTestSchedule
    {
        //private IContest stubContest;
        //public UnitTestSchedule(IContest obj) {
        //    stubContest = obj;
        //}
        //public class Contest{
        //    return stubContest;
        //}
        [TestMethod]
        public void TestPropertyScheduleList()
        {
            #region Initiate

            Contest StubContest = new Contest();

            //StubContest.Time = DateTime.ParseExact("2015-05-12 11:45", "yyyy-MM-dd HH:mm",
            //                           System.Globalization.CultureInfo.InvariantCulture);

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
    }
}
