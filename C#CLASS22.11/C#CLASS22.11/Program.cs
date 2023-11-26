using C_CLASS22._11;
namespace MysSpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPayment payment = new CreditCardPayment();
            payment.ProcessPayment();

            IPayment payment1 = new PaypalPayment();
            payment1.ProcessPayment();
        }
    }
}