using Shipping.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Concrete_Classes
{
    public class ThirdPartyPayment : IThirdPartyPayment
    {
        public void AddCommissionToAgent()
        {
            Console.WriteLine("Added commission to agent");
        }
    }
}
