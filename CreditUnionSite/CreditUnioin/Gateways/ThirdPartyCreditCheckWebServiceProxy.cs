namespace CreditUnioin.Gateways
{
    public class ThirdPartyCreditCheckWebServiceProxy
    {
        public int CrdChk(string n)
        {
            if (n == "Jason")
            {
                return 1;
            }

            return 0;
        }
    }
}