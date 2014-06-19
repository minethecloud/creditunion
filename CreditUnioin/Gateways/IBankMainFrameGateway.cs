using CreditUnioin.Entities;

namespace CreditUnioin.Gateways
{
    public interface IBankMainFrameGateway
    {
        int CreateNew(CreditCardApplication application); 
    }
}