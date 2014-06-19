using System.Collections.Generic;

namespace CreditUnioin.Loans
{
    public class ApplicationDetailsValidator :IApplicationValidator
    {
        private readonly INumberValidator _driversLicenseValidator;

        public ApplicationDetailsValidator(INumberValidator numberValidator)
        {
            _driversLicenseValidator = numberValidator;
        }

        public List<string> Validate(Entities.CarLoanApplication application)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(application.ApplicantName))
            {
                errors.Add("Name cannot be blank.");
            }

            if (!_driversLicenseValidator.IsValid(application.DriversLicense))
            {
                errors.Add("Drivers License number is invalid");
            }

            return errors;
        }
    }
}