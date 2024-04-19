using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FinalAssignment.Test
{
    [TestFixture]
    class CalculateMETtestScript
    {
        [Test]
        public void Test_GetMET_For_Walking_Casual()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Walking", "Casual");
            Assert.AreEqual(2.0f, result);
        }

        [Test]
        public void Test_GetMET_For_Swimming_Leisurely()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Swimming", "Leisurely");
            Assert.AreEqual(5.8f, result);
        }

        [Test]
        public void Test_GetMET_For_Running_Moderate()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Running", "Moderate");
            Assert.AreEqual(12.8f, result);
        }

        [Test]
        public void Test_GetMET_For_Cycling_Medium()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Cycling", "Medium");
            Assert.AreEqual(8.0f, result);
        }

        [Test]
        public void Test_GetMET_For_Jump_Rope()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Jump Rope", "Any intensity");
            Assert.AreEqual(12.0f, result);
        }

        [Test]
        public void Test_GetMET_For_Yoga_Hatha()
        {
            CalculateMET calculator = new CalculateMET();
            float result = calculator.getMET("Yoga", "Hatha");
            Assert.AreEqual(2.5f, result);
        }
    }
}
