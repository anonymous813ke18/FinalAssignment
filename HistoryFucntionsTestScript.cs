using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinalAssignment.Test
{
    [TestFixture]
    class HistoryFucntionsTestScript
    {
        private HistoryFunctions historyFunctions;

        [SetUp]
        public void SetUp()
        {
            historyFunctions = new HistoryFunctions();
        }

        [Test]
        public void Test_CheckHistory_Exists()
        {
            bool result = historyFunctions.checkHistory("hammy79826", "18 April 2024");
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_CheckHistory_NotExists()
        {
            bool result = historyFunctions.checkHistory("hammy79826", "20 April 2024");
            Assert.IsFalse(result);
        }

        [Test]
        public void Test_InsertHistory()
        {
            float result = historyFunctions.insertHistory("hammy79826", "19 April 2024", 500); // Assuming 500 calories burned
            Assert.AreEqual(500, result);
        }

        [Test]
        public void Test_UpdateHistory()
        {
            float result = historyFunctions.updateHistory("hammy79826", "19 April 2024", 200); // Assuming 200 calories burned
            Assert.AreEqual(700, result); // Assuming the previous value was 500, so the updated value should be 700
        }
    }
}
