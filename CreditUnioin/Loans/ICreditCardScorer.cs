using CreditUnioin.Entities;

namespace CreditUnioin.Loans
{
    public interface ICreditCardScorer
    {
        int? ScoreApplication(CreditCardApplication application); 
    }
}