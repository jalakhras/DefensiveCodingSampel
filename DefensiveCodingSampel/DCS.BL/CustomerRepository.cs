using System;
using System.Collections.Generic;
using System.Text;

namespace DCS.BL
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            // -- If this is a new customer, create the customer record --
            // Determine whether the customer is an existing customer.
            // If not, validate entered customer information
            // If not valid, notify the user.
            // If valid,
            // Open a connection
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.

        }

        public void Update()
        {
            // Open a connection
            // Set stored procedure parameters with the customer data.
            // Call the save stored procedure.
        }
    }
}
