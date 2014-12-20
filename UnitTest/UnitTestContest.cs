using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _1dv404_laboration_3;
using Microsoft.QualityTools.Testing.Fakes;

namespace UnitTest
{
    [TestClass]
    public class UniTestContest
    {
        [TestMethod]
        public void ContestComplete()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.Referee.Add("Anders Bertilsson");
            testContest.Referee.Add("Hugo Andersson");
            testContest.Event.Add("Barr");
            testContest.Event.Add("Ringar");
            testContest.setTime("2015-01-12 12:45");

            #endregion

            #region Test

            #endregion

            #region Assert

            Assert.AreEqual("Barr", testContest.Event[0], "Fel vid att lägga till grenar.");
            Assert.AreEqual("Ringar", testContest.Event[1], "Fel vid att lägga till grenar.");
            Assert.AreEqual("Anders Bertilsson", testContest.Referee[0], "Fel vid att lägga till domare.");
            Assert.AreEqual("Hugo Andersson", testContest.Referee[1], "Fel vid att lägga till domare.");

            #endregion
        }
        [TestMethod]
        public void ContestNoTime()
        {
            #region Initiate

            Contest testContest = new Contest();

            testContest.Referee.Add("Anders Bertilsson");
            testContest.Referee.Add("Hugo Andersson");
            testContest.Event.Add("Barr");
            testContest.Event.Add("Ringar");

            #endregion

            #region Test

            try
            {
                testContest.Time.ToString();
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
