using Shipping.Concrete_Classes;
using Shipping.Interfaces;
using Shipping.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static Shipping.Enums;

namespace Shipping.Factory
{
    public class MembershipFactory : PaymentFactory
    {
        public override void PaymentMade(Payment payment)
        {
           
            switch (payment.OrderMode)
            {
               
                case OrderMode.ActivateMembership:
                    IMembership activateMembership = new MemberShip();
                    activateMembership.ActivateMembership();
                    break;

                case OrderMode.UpgradeMemebership:
                    IMembership upgradeMembership = new MemberShip();
                    upgradeMembership.ActivateMembership();
                    break;
            }

            base.ReportingCollection();
        }
    }
}
