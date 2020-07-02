using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Interfaces
{
    interface IEmail
    {
        void SendActivation();
        void SendUpgrade();
    }
}
