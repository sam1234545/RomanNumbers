using NUnit.Framework;
using System;

namespace RomanNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given_1_Then_return_I()
        {
            //arrange 
            int number = 1;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("I", result);
        }
        [Test]
        public void Given_2_Then_return_II()
        {
            //arrange 
            int number = 2;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("II", result);
        }
        [Test]
        public void Given_3_Then_return_III()
        {
            //arrange 
            int number = 3;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("III", result);
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
        public void Given_number_bigger_than_5_Then_return_The_right_roman_presentation(int number,  string expected )
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
        private string getRomanNumber(int number)
        {
            if (number == 9) return "IX";
            if (number > 5) return ComputeNumberOverFive(number);
            if (number == 5) return "V";
            if (number == 4) return "IV";
            return ComputeNumberUnderFour(number);
        }

        private string ComputeNumberOverFive(int number)
        {
            string result = "V";
            for (int i =1; i <= number-5 ; i++)
            {
                result += "I";
            }

            return result;
        }

        private static string ComputeNumberUnderFour(int number)
        {
            string result = "";
            for (int i = 1; i <= number; i++)
            {
                result += "I";
            }

            return result;
        }
    }
}