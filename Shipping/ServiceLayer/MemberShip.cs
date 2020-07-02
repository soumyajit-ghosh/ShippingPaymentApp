using Shipping.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Concrete_Classes
{
    public class MemberShip : IMembership
    {
        public void ActivateMembership()
        {
            Console.WriteLine("Activated Membership");
            Email email = new Email();
             email.SendActivation();

        }

        public void UpgradeMembership()
        {
            Console.WriteLine("Upgraded Membership");
            Email email = new Email();
            email.SendUpgrade();
        }
    }
}
