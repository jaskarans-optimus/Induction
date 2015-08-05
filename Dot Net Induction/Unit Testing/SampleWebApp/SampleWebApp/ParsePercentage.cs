using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleWebApp
{
    public class ParsePercentage
    {

        public const string stringToIntCastExceptionMessage = "String to int type conversion failed";
        public const string percentageBelowZeroMessage = "Percentage is below zero";
        public const string percentageAboveHundredMessage = "Percentage is above 100";
        public float ConvertPercentage(String percentage)
        {
            float percentageNum;
            if (!float.TryParse(percentage, out percentageNum))
                throw new InvalidCastException(stringToIntCastExceptionMessage);
            if (percentageNum < 0)
                throw new ArgumentOutOfRangeException("Percentage", percentageNum, percentageBelowZeroMessage);
            if (percentageNum > 100)
                throw new ArgumentOutOfRangeException("Percentage", percentageNum, percentageAboveHundredMessage);
            return percentageNum;
        }
    }
}