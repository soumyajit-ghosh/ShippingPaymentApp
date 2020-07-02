using Shipping.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Concrete_Classes
{
    public class Email : IEmail
    {
        public void SendActivation()
        {
            Console.WriteLine("Sent Activation Email");
        }

        public void SendUpgrade()
        {
            Console.WriteLine("Sent Upgrade Email");
        }
    }
}
