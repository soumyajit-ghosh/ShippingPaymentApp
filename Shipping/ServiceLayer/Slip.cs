using Shipping.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipping.Concrete_Classes
{
    public class Slip : ISlip
    {
        public void AddCouponToSlip()
        {
            Console.WriteLine("Added First Aid Coupon");
        }

        public void GenerateDuplicatePackingSlip()
        {
            Console.WriteLine("Generated Duplicate Payslip for Royality");
        }

        public void GeneratePackingSlip()
        {
            Console.WriteLine("Generated Paylip");
        }
    }
}
