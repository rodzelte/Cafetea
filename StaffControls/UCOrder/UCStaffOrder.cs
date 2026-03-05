using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Cafetea.Database.Staff.OrderService;
using Cafetea.Database.Client.CustomerService;

namespace Cafetea.StaffControls.UCOrder
{
    public partial class UCStaffOrder : UserControl
    {
        private List<(string productName, decimal price, int quantity)> cart = new();
        private decimal total = 0;
        private StaffOrderService orderService = new();
        private CustomerService customerService = new();

        public UCStaffOrder()
        {
            InitializeComponent();

            // Product buttons
            capuccinoBtn.Click += (s, e) => AddItem("Cappuccino", 30);
            blueberryMuffinBtn.Click += (s, e) => AddItem("Blueberry Muffin", 45);
            waterBtn.Click += (s, e) => AddItem("Water", 15);
            matchalatteBtn.Click += (s, e) => AddItem("Matcha Latte", 50);

            // Buy button
            buyBtn.Click += BuyBtn_Click;
        }

        private void AddItem(string name, decimal price)
        {
            var existing = cart.FirstOrDefault(i => i.productName == name);

            if (existing.productName != null)
            {
                cart.Remove(existing);
                cart.Add((name, price, existing.quantity + 1));
            }
            else
            {
                cart.Add((name, price, 1));
            }

            RefreshOrderDisplay();
        }

        private void RefreshOrderDisplay()
        {
            orderDetailslbl.Text = "";
            total = 0;

            foreach (var item in cart)
            {
                decimal itemTotal = item.price * item.quantity;
                orderDetailslbl.Text += $"{item.productName} x{item.quantity} - ${itemTotal}\n";
                total += itemTotal;
            }

            totalLbl.Text = $"Total: ${total}";
        }

        private void BuyBtn_Click(object? sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("No items in the order.");
                return;
            }

            string customerName = csNameOrdertb.Text.Trim();
            string email = emailCsTb.Text.Trim();
            string promo = promoTb.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Customer name is required.");
                return;
            }

            try
            {
                int customerId;

                // 1️⃣ Lookup customer by name + email
                var existingCustomer = customerService.SearchCustomers(customerName)
                    .FirstOrDefault(c =>
                        string.Equals(c.Name, customerName, StringComparison.OrdinalIgnoreCase) &&
                        (string.IsNullOrWhiteSpace(email) || string.Equals(c.Email, email, StringComparison.OrdinalIgnoreCase))
                    );

                if (existingCustomer != null)
                {
                    customerId = existingCustomer.Id;
                }
                else
                {
                    // 2️⃣ Create new customer if not found
                    customerId = orderService.CreateCustomer(customerName, email);
                }

                // 3️⃣ Create order
                orderService.CreateOrder(customerId, customerName, cart, promo);

                MessageBox.Show("Order placed successfully!");
                ClearOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error placing order: " + ex.Message);
            }
        }

        private void ClearOrder()
        {
            cart.Clear();
            total = 0;
            orderDetailslbl.Text = "";
            totalLbl.Text = "Total: $0";
            promoTb.Text = "";
            csNameOrdertb.Text = "";
            emailCsTb.Text = "";
        }
    }
}