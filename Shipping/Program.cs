using Shipping.Factory;
using Shipping.Models;
using System;
using static Shipping.Enums;

namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
                bool wrongInput = true;          
                Payment payment = new Payment();
                while (wrongInput)
                {
                    try
                    {
                        Console.WriteLine("Enter 1 for Physical Products \n Enter 2 for Books \n Enter 3 for Video \n Enter 4 for Membership \n 5 to quit");
                        OrderTypes productType = (OrderTypes)(Convert.ToInt32(Console.ReadLine()) - 1);
                        payment.Type = productType;
                        if (productType == OrderTypes.Membership)
                        {
                            Console.WriteLine("Enter 1 for Activate Membership \n Enter 2 for Update Membership\n");
                            OrderMode orderMode = (OrderMode)(Convert.ToInt32(Console.ReadLine()) - 1);
                            payment.OrderMode = orderMode;
                        }

                        Console.WriteLine("Enter Amount");
                        payment.Amount = Convert.ToDecimal(Console.ReadLine());
                        wrongInput = false;
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Bad Input, try again");
                    }
                }


                try
                {
                    PaymentClientService makePayment = new PaymentClientService();
                    makePayment.PaymentMade(payment);
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Internal Server Error");
                }     
        }
    }
}
