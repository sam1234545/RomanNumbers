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

        [Test]
        public void Given_6_Then_return_VI()
        {
            //arrange 
            int number = 6;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("VI", result);
        }
        [Test]
        public void Given_7_Then_return_VII()
        {
            //arrange 
            int number = 7;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("VII", result);
        }
        [Test]
        public void Given_8_Then_return_VIII()
        {
            //arrange 
            int number = 8;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("VIII", result);
        }
        private string getRomanNumber(int number)
        {
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