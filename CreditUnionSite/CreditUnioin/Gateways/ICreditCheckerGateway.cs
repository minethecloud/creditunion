namespace CreditUnioin.Gateways
{
    public interface ICreditCheckerGateway
    {
        bool HasGoodCreditHistory(string personsName); 
    }
}