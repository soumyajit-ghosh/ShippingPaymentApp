using Shipping.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Shipping.Enums;

namespace Shipping.Factory
{
    public class PaymentClientService : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
            switch (payment.Type)
            {
                case OrderTypes.Book:
                    BookPaymentFactory bookPaymentFactory =  new BookPaymentFactory();
                    bookPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.PhysicalProduct:
                    PhysicalProductPaymentFactory physicalProductPaymentFactory = new PhysicalProductPaymentFactory();
                    physicalProductPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.Video:
                    VideoPaymentFactory videoPaymentFactory = new VideoPaymentFactory();
                    videoPaymentFactory.PaymentMade(payment);
                    break;

                case OrderTypes.Membership:
                    MembershipFactory membershipFactory = new MembershipFactory();
                    membershipFactory.PaymentMade(payment);
                    break;
            }
        }
    }
}
