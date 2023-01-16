namespace OppositeNumberTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KataTestinguUsingAPositiveNumber()
        {
            Assert.That(Kata.Opposite(1), Is.EqualTo(-1));
        }

        [Test]
        public void KataTestingUsingANegativeNumber()
        {
            Assert.That(Kata.Opposite(-1), Is.EqualTo(1));
        }

        [Test]
        public void KataTestingUsingALargePositiveNumber()
        {
            Assert.That(Kata.Opposite(10000000), Is.EqualTo(-10000000));
        }

        [Test]
        public void KataTestingUsingALargeNegativeNumber()
        {
            Assert.That(Kata.Opposite(-10000000), Is.EqualTo(10000000));
        }
    }
}