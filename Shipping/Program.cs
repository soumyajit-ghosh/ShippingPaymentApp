using Shipping.Factory;
using Shipping.Models;
using System;
using static Shipping.Enums;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {

            PaymentClientService makePayment = new PaymentClientService();

            Console.WriteLine("************ Activte Membership  **************");
            Payment membershipPayment = new Payment { Type = OrderTypes.Membership, Amount = 200, OrderMode = OrderMode.ActivateMembership };
            makePayment.PaymentMade(membershipPayment);

            Console.WriteLine("************ Payment for Book  **************");
            Payment bookPayment = new Payment { Type = OrderTypes.Book, Amount = 100};         
            makePayment.PaymentMade(bookPayment);

            Console.ReadKey();
            
        }
    }
}
