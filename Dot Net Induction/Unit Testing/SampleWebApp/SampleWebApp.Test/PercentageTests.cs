
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleWebApp.Test
{
    [TestClass]
    public class PercentageTests
    {
        [TestMethod]
        public void ConvertPercentage_WithValidValues()
        {
            ParsePercentage parsePercentage = new ParsePercentage();
            String inputPercentage = "72";
            double expectedPercentage = 72.0;

            double actualPercentage=parsePercentage.ConvertPercentage(inputPercentage);

            Assert.AreEqual(expectedPercentage, actualPercentage,"Valid Percentage Conversion Failure");
        }
        [TestMethod]
        public void ConvertPercentage_WithValueSmallerThanZero()
        {
            String inputPercentage = "-15";
            ParsePercentage parsePercentage = new ParsePercentage();

            try
            {
                parsePercentage.ConvertPercentage(inputPercentage);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, ParsePercentage.percentageBelowZeroMessage);
                return;
            }
            Assert.Fail("No Exception was thrown");
        }
        [TestMethod]
        public void ConvertPercentage_WithValueGreaterThanHundred()
        {
            String inputPercentage = "104";
            ParsePercentage parsePercentage = new ParsePercentage();

            try
            {
                parsePercentage.ConvertPercentage(inputPercentage);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, ParsePercentage.percentageAboveHundredMessage);
                return;
            }
            Assert.Fail("No Exception was thrown");
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void ConvertPercentage_WithInvalidInput()
        {
            String inputPercentage = "hello";
            ParsePercentage parsePercentage = new ParsePercentage();

            try
            {
                parsePercentage.ConvertPercentage(inputPercentage);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.Message, ParsePercentage.stringToIntCastExceptionMessage);
                return;
            }
            Assert.Fail("No Exception was thrown");
        }

    }
}
