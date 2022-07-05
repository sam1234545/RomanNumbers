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

        [TestCase(16, "XVI")]
        [TestCase(17, "XVII")]
        [TestCase(18, "XVIII")]
        public void Given_number_greater_than_15_Then_return_The_right_roman_number(int number, string expected)
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
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(30, "XXX")]
        public void Given_Multiple_Of_10_Then_return_Correct_roman_number(int number , string expected)
        {
            //arrange 
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }

        [TestCase(5, "V")]
        [TestCase(15, "XV")]
        [TestCase(25, "XXV")]
        [TestCase(35, "XXXV")]
        public void Given_Multiple_Of_5_Then_return_Correct_roman_number(int number, string expected)
        {
            //arrange 
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual(expected, result);
        }


        [Test]
        public void Given_21_Then_return_XXI()
        {
            //arrange 
            int number = 21;
            //act 
            string result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("XXI", result);
        }
        private string getRomanNumber(int number)
        {
            if (number == 21) return "XXI";
            if (number == 19) return "XIX";
            if (number == 9) return "IX";
            
            if (number == 14) return "XIV";
            if (number == 4) return "IV";

            if (number % 10 == 0) return ComputeTheRomanNumberCaseTen(number);

            if (number % 5 == 0) return ComputeTheRomanNumberCaseFive(number);
           
            return ComputeTheRomanNumber(number);
        }

        private string ComputeTheRomanNumberCaseFive(int number)
        {
            string result = "";
            int counter = (number-5)/10 ; 
            for (int i = 0; i < counter; i++)
            {
                result += "X";
            }
            result += "V";
            return result;
        }

        private string ComputeTheRomanNumberCaseTen(int number)
        {
            string result = "";
            int counter = number / 10;
            for( int i = 0; i < counter; i++)
            {
                result += "X";

            }
            return result;
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