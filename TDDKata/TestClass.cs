using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        private StringCalc stringCalc;

        [SetUp]
        public void SetUp()
        {
            stringCalc = new StringCalc();
        }

        [Test]
        public void Sum_TwoPositiveDigits_CorrectResult()
        {
            int value = stringCalc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }

        [Test]
        public void Sum_OneDigitIsEmptyString_CorrectResult()
        {
            int value = stringCalc.Sum(" ,2");
            Assert.That(value, Is.EqualTo(2), "Wrong actual value");
        }

        [Test]
        public void Sum_OneDigit_CorrectResult()
        {
            int value = stringCalc.Sum("1");
            Assert.That(value, Is.EqualTo(1), "Wrong actual value");
        }

        [Test]
        public void Sum_OneDigitIsNegative_CorrectResult()
        {
            int value = stringCalc.Sum("1,-4");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void Sum_LineBreaskAsSeparator_CorrectResult()
        {
            int value = stringCalc.Sum("1\n4\n4");
            Assert.That(value, Is.EqualTo(9), "Wrong actual value");
        }

        [Test]
        public void Sum_DifferentSeparators_CorrectResult()
        {
            int value = stringCalc.Sum("1\n4\n4,4,4\n4\n4");
            Assert.That(value, Is.EqualTo(25), "Wrong actual value");
        }
    }
}
