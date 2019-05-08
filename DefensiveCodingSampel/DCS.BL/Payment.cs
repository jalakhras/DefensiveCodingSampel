using System;
using System.ComponentModel;

namespace DCS.BL
{
    public enum PaymentType
    {
        CreditCard = 1,
        PayPal = 2
    }

    /// <summary>
    /// Manages a payment.
    /// </summary>
    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            PaymentType paymentTypeOption;
            if (!Enum.TryParse(PaymentType.ToString(), out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)PaymentType, typeof(PaymentType));
            }

            switch (paymentTypeOption)
            {

                case BL.PaymentType.CreditCard:
                    // Process credit card
                    break;

                case BL.PaymentType.PayPal:
                    // Process PayPal
                    break;

                default:
                    throw new ArgumentException();
            }

            // Open a connection
            // Set stored procedure parameters with the payment data.
            // Call the save stored procedure.

        }
    }
}