using System.Collections.Generic;
using CreditUnioin.Entities;

namespace CreditUnioin.Loans
{
    public interface IApplicationValidator
    {
        List<string> Validate(CreditCardApplication application); 
    }
}