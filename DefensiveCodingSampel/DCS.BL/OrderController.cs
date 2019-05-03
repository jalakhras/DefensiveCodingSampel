using Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DCS.BL
{
   public class OrderController
    {
        private readonly CustomerRepository customerRepository;
        private readonly OrderRepository orderRepository;
        private readonly InventoryRepository inventoryRepository;
        private readonly EmailLibrary emailLibrary;
        public OrderController()
        {
             customerRepository = new CustomerRepository();
             orderRepository = new OrderRepository();
             inventoryRepository = new InventoryRepository();
             emailLibrary = new EmailLibrary();
        }
        public  void PlaceOrder(Customer customer,
                                Order order,
                                Payment payment,
                                bool allowSplitOrder, bool emailReceipt)
        {
            customerRepository.Add(customer);

            orderRepository.Add(order);

            inventoryRepository.OrderItems(order, allowSplitOrder);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                customer.ValidateEmail();
                customerRepository.Update();
                emailLibrary.SendEmail(customer.EmailAddress, "Here is your receipt");
            }
        }

    }
}
