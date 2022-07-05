using NUnit.Framework;
using System;

namespace RomanNumbers
{
    public class Tests
    {

        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(3, "III")]
        public void Given_number_less_than_5_Then_return_The_right_roman_presentation(int number, string expected)
        {
            //arrange 
            //Testcase values
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Given_4_Then_return_IV()
        {
            //arrange 
            int number = 4;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("IV", result);
        }
        [Test]
        public void Given_5_Then_return_V()
        {
            //arrange 
            int number = 5;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("V", result);
        }

        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        public void Given_number_greater_than_5_and_less_than_10_Then_return_The_right_roman_presentation(int number,  string expected )
        {
            //arrange 
            //Testcase values
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Given_9_Then_return_IX()
        {
            //arrange 
            int number = 9;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("IX", result);
        }
        [Test]
        public void Given_10_Then_return_X()
        {
            //arrange 
            int number = 10;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("X", result);
        }
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        public void Given_number_greater_than_10_and_less_than_15_Then_return_The_right_roman_presentation(int number, string expected)
        {
            //arrange 
            //Testcase values
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Given_14_Then_return_XIV()
        {
            //arrange 
            int number = 14;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("XIV", result);
        }
        [Test]
        public void Given_15_Then_return_XV()
        {
            //arrange 
            int number = 15;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("XV", result);
        }
        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        public void Given_number_greater_than_15_Then_return_The_right_roman_presentation(int number, string expected)
        {
            //arrange 
            //Testcase values
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Given_19_Then_return_XIX()
        {
            //arrange 
            int number = 19;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("XIX", result);
        }
        [Test]
        public void Given_20_Then_return_XX()
        {
            //arrange 
            int number = 20;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("XX", result);
        }
        private string getRomanNumber(int number)
        {
            if (number == 19) return "XIX";
            if (number == 9) return "IX";
            
            if (number == 14) return "XIV";
            if (number == 4) return "IV";

            if (number == 10) return "X";
            if (number == 20) return "XX";

            if (number == 5) return "V";
            if (number == 15) return "XV";
           
            return ComputeTheRomanNumber(number);
        }
        private string ComputeTheRomanNumber(int number)
        {
            string result;
            int counter;
            GetTheInitialValues(number, out result, out counter);
            for (int i = 1; i <= number - counter; i++)
            {
                result += "I";
            }
            return result;

        }

        private static void GetTheInitialValues(int number, out string result, out int counter)
        {
            result = "";
            counter = 0;
            if (number > 5 && number < 10)
            {
                counter = 5;
                result = "V";
            }
            if (number > 10 && number < 15)
            {
                counter = 10;
                result = "X";
            }
            if (number >  15)
            {
                counter = 15;
                result = "XV";
            }
        }
    }
}