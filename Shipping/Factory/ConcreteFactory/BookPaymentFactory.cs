using Shipping.Concrete_Classes;
using Shipping.Interfaces;
using Shipping.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Factory
{
    public class BookPaymentFactory: PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
            ISlip slip = new Slip();
            slip.GeneratePackingSlip();
            IThirdPartyPayment thirdPartyPayment = new ThirdPartyPayment();
            thirdPartyPayment.AddCommissionToAgent();
            base.ReportingCollection();
        }
    }
}
