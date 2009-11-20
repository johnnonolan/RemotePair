using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuoteThingTest
{
    /// <summary>
    /// Summary description for PremiumTest
    /// </summary>
    [TestClass]
    public class PremiumTest
    {
        [TestMethod]
        public void Calculate_EmptyInput_EmptyOutput()
        {
            Premium p = new Premium();
            string input = string.Empty;
            string output = p.Calculate(input);
            Assert.AreEqual(input, output); 
        }

        [TestMethod]
        public void Calculate_MultiLineInput_SameCountOfLinesInOutput()
        {
            Premium p = new Premium();
            string input = "sfdgfd\nfgdgdfg\ndfssdf";
            string output = p.Calculate(input);
            Assert.AreEqual(3, GetCountOfNewLines(output));
        }

        [TestMethod]
        public void GetBaseRating_SingleTrip_Return20()
        {
            BasePremium b = new BasePremium("SingleTrip");
            var result = b.GetBaseRating();
            Assert.AreEqual(20.0, result, 0.0000001);
        }

        [TestMethod]
        public void GetBaseRating_AnualTrip_Return80()
        {
            BasePremium b = new BasePremium("AnnualTrip");
            var result = b.GetBaseRating();
            Assert.AreEqual(80.0, result, 0.0000001);
        }

        [TestMethod]
        public void AgeGetRating_ZeroYears_Return1point2()
        {
            AgeModifier age = new AgeModifier();
            double result = age.GetRating(0);
            Assert.AreEqual(1.2,result);

        }

        private static int GetCountOfNewLines(string input)
        {
            return input.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).Count();
        }

    }

    public class AgeModifier
    {
        public double GetRating(int input)
        {
            return 1.2;
        }
    }
}
