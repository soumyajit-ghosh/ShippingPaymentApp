using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Shipping
{
    public class Enums
    {
        public enum OrderTypes
        {
            PhysicalProduct,
            Book,
            Video,
            Membership
            
        }

        public enum OrderMode
        {
           ActivateMembership,
           UpgradeMemebership
        }
    }
}
