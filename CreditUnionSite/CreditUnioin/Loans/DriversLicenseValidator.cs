namespace CreditUnioin.Loans
{
    public class DriversLicenseValidator : INumberValidator
    {

        public bool IsValid(string driversLicenseNumber)
        {
            var isIncorrectLength = driversLicenseNumber == "" || driversLicenseNumber.Length != 8;

            if (isIncorrectLength)
            {
                return false;
            }

            if (StartsWithALetterFollowedBy7Numbers(driversLicenseNumber))
            {
                return true;
            }

            return false;
        }
        private static bool StartsWithALetterFollowedBy7Numbers(string membershipNumber)
        {
            int dummy;

            return char.IsLetter(membershipNumber[0]) &&
                int.TryParse(membershipNumber.Substring(1), out dummy);
        }
    }
}