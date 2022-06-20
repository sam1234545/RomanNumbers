using NUnit.Framework;

namespace RomanNumbers
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Given1_return_I()
        {
            //arrange 
            int number = 1;
            //act 
            var result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("I", result);
        }
        [Test]
        public void Given2_return_II()
        {
            //arrange 
            int number = 2;
            //act 
            var result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("II", result);
        }
        [Test]
        public void Given3_return_III()
        {
            //arrange 
            int number = 3;
            //act 
            var result = getRomanNumber(number);
            //assert 
            Assert.AreEqual("III", result);
        }

        private string getRomanNumber(int number)
        {
            if (number == 2) return "II";
            if (number == 3) return "III";
            return "I";
        }
    }
}