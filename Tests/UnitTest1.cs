using NUnit.Framework;
using src;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sut = new Class1(1);
            Assert.That(sut.Number, Is.EqualTo(1));
            Assert.That(3,Is.Not.EqualTo(1));
        }
    }
}