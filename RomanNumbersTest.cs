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

        private string getRomanNumber(int number)
        {
            return "I";
        }
    }
}