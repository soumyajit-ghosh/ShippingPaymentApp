using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Interfaces
{
    interface ISlip
    {
        void GeneratePackingSlip();
        void GenerateDuplicatePackingSlip();
        void AddCouponToSlip();
    }
}
