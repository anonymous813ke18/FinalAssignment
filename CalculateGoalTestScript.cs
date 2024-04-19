using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinalAssignment.Test
{
    [TestFixture]
    class CalculateGoalTestScript
    {
        private CalculateGoal goalCalculator;

        [SetUp]
        public void SetUp()
        {
            goalCalculator = new CalculateGoal();
        }

        [Test]
        public void Test_CalculateGoalPercent()
        {
            float result = goalCalculator.calculateGoalPercent(50, 100);
            Assert.AreEqual(50, result);
        }

        [Test]
        public void Test_GetGoal()
        {
            float result = goalCalculator.getGoal("hammy79826");
            Assert.AreEqual(7000, result); // Assuming 1500 is the expected value
        }

        [Test]
        public void Test_SetGoal()
        {
            bool result = goalCalculator.setGoal("hammy79826", 6000); // Assuming 2000 is the goal to be set
            Assert.IsTrue(result);
        }

        [Test]
        public void Test_CalculateCaloriesBurned()
        {
            float result = goalCalculator.calculateCaloriesBurned("hammy79826", 2, 5); // Assuming MET = 5, time = 60 mins
            Assert.AreEqual(880, result); // Assuming 300 is the expected value
        }

        [Test]
        public void Test_GetFromHistory()
        {
            float result = goalCalculator.getFromHistory("hammy79826", "18 April 2024");
            Assert.AreEqual(5332, result); // Assuming 500 is the expected value
        }
    }
}
