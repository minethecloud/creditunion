using CreditUnioin.Loans;
using NUnit.Framework;

namespace CreditUnion.UnitTests
{
    [TestFixture]
    [Category("Drivers License Tests")]
    public class DriversLicenceNumberValidatorTests
    {
        [Test]
        public void ShouldBeInvalidWhenAllSpaces()
        {
            var sut = new DriversLicenseValidator();
            Assert.That(sut.IsValid("   "),Is.False);
        }
        [Test]
        public void ShouldBeInvalidWhenBlack()
        {
            var sut = new DriversLicenseValidator();
            Assert.That(sut.IsValid(""), Is.False);
        }
         
        [Test]
        public void ShouldBeInvalidWhenMoreThan8Characters()
        {
            var sut = new DriversLicenseValidator();
            const string driversLicenseNumber = "T12343434433";
            Assert.That(sut.IsValid(driversLicenseNumber), Is.False);
        }

        [Test]
        public void ShouldBeValidWhen8DigitsAndStartsWithLetter()
        {
            var sut = new DriversLicenseValidator();
            const string driversLicenseNumber = "A5522123";
            Assert.That(sut.IsValid(driversLicenseNumber), Is.True);
        }
    }
}