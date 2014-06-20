using CreditUnioin.Entities;
using CreditUnioin.Loans;
using Moq;
using NUnit.Framework;

namespace CreditUnion.UnitTests
{
    [TestFixture]
    public class ApplicationDetailsValidatorTests
    {
        [Test]
        public void ShouldDetectBlankName()
        {
            var fakeNumberValidator = new Mock<INumberValidator>();

            var application = new CarLoanApplication
                                  {
                                      ApplicantName = ""
                                  };
            var sut = new ApplicationDetailsValidator(fakeNumberValidator.Object);

            var errors = sut.Validate(application);

            Assert.That(errors, Has.Exactly(1).EqualTo("Name cannot be blank."));
        }
         
    }
}