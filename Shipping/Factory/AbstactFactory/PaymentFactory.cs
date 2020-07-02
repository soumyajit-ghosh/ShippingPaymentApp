using Shipping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Factory
{
    public abstract class PaymentFactory
    {
        public abstract void PaymentMade(Payment payment);

        public void ReportingCollection()
        {
            Console.WriteLine("***** (Not Needed)capturing cold reporting data will be useful, so using class instead of interface");
        }
    }
}
