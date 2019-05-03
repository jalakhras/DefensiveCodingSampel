using DCS.BL;
using System;
using System.Windows.Forms;
using Core.Common;

namespace DefensiveCodingSampel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrder();

        }

        private void PlaceOrder()
        {
            var customer = new Customer();
            //Populate the customer instance

            var order = new Order();
            //Populate the order instance
            var payment = new Payment();
            //Populate the payment instance

            var allowSplitOrder = true;
            var emailReceipt = true;
            var orderController = new OrderController();
            orderController.PlaceOrder(customer, order, payment, allowSplitOrder, emailReceipt);
        }
    }
}
