using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cafetea.Database.Staff.OrderService;

namespace Cafetea.StaffControls.UCOrder
{
    public partial class UCOrder : UserControl
    {
        public event EventHandler? OnOrderPlaced; // event for dashboard

        private List<(string productName, decimal price, int quantity)> currentOrder;
        private OrderService orderService;

        public UCOrder()
        {
            InitializeComponent();
            currentOrder = new List<(string, decimal, int)>();
            orderService = new OrderService();
        }

        private void ProductBtn_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            string productName = btn.Text;
            decimal price = productName switch
            {
                "Capuccino" => 80,
                "Blueberry Muffin" => 50,
                "Water" => 20,
                "Matcha Latte" => 100,
                _ => 0
            };

            currentOrder.Add((productName, price, 1));
            RefreshOrderDetails();
        }

        private void BuyBtn_Click(object? sender, EventArgs e)
        {
            if (currentOrder.Count == 0)
            {
                MessageBox.Show("No items in order!");
                return;
            }

            string promoCode = promoTb.Text;

            orderService.CreateOrder(currentOrder, promoCode);

            currentOrder.Clear();
            orderdetailsPanel.Controls.Clear();

            MessageBox.Show("Order successfully placed!");

            // Trigger event for dashboard to refresh
            OnOrderPlaced?.Invoke(this, EventArgs.Empty);
        }

        private void RefreshOrderDetails()
        {
            orderdetailsPanel.Controls.Clear();
            foreach (var item in currentOrder)
            {
                orderdetailsPanel.Controls.Add(new Label
                {
                    Text = $"{item.productName} - {item.price:C}",
                    AutoSize = true
                });
            }
        }
    }
}