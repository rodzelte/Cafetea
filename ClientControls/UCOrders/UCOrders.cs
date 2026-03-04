using Cafetea.Database.OrderService;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Cafetea.AdminControls
{
    public partial class UCOrders : UserControl
    {
        public UCOrders()
        {
            InitializeComponent();
            orderPanel.Visible = false; // hide template

            // Setup ComboBoxes
            daterangeCb.DropDownStyle = ComboBoxStyle.DropDownList;
            statusOrderCb.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadDateRange();
            LoadStatusOrder();

            // Event handlers for filtering
            daterangeCb.SelectedIndexChanged += (s, e) => LoadOrders();
            statusOrderCb.SelectedIndexChanged += (s, e) => LoadOrders();
            customerTextbox.TextChanged += (s, e) => LoadOrders();

            LoadOrders();
        }

        private void LoadDateRange()
        {
            daterangeCb.Items.Clear();
            foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (!string.IsNullOrEmpty(month))
                    daterangeCb.Items.Add(month);
            }
            daterangeCb.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void LoadStatusOrder()
        {
            statusOrderCb.Items.Clear();

            // Add "All Orders" as first option
            statusOrderCb.Items.Add("All Orders");

            var orders = new OrderService().GetOrders();
            HashSet<string> statusSet = new HashSet<string>();
            foreach (var order in orders)
            {
                if (!string.IsNullOrEmpty(order.Status))
                    statusSet.Add(order.Status);
            }

            foreach (var status in statusSet)
                statusOrderCb.Items.Add(status);

            // Select "All Orders" by default
            statusOrderCb.SelectedIndex = 0;
        }

        private void LoadOrders()
        {
            flowLayoutPanelOrder.Controls.Clear();
            orderPanel.BackColor = Color.FromArgb(16, 22, 33);
            flowLayoutPanelOrder.AutoScroll = true;
            flowLayoutPanelOrder.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelOrder.WrapContents = false;

            var orders = new OrderService().GetOrders();

            // --- FILTERS ---
            // Month filter
            if (daterangeCb.SelectedIndex >= 0)
            {
                int selectedMonth = daterangeCb.SelectedIndex + 1;
                orders = orders.Where(o => o.OrderDate.Month == selectedMonth).ToList();
            }

            // Status filter
            if (statusOrderCb.SelectedItem != null)
            {
                string selectedStatus = statusOrderCb.SelectedItem.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All Orders")
                    orders = orders.Where(o => o.Status == selectedStatus).ToList();
            }

            // Customer search filter
            if (!string.IsNullOrWhiteSpace(customerTextbox.Text))
            {
                string search = customerTextbox.Text.Trim().ToLower();
                orders = orders.Where(o => !string.IsNullOrEmpty(o.NameOfPurchaser) && o.NameOfPurchaser.ToLower().Contains(search)).ToList();
            }

            // --- SUMMARY CALCULATIONS ---
            DateTime today = DateTime.Today;

            // Orders today
            int ordersToday = orders.Count(o => o.OrderDate.Date == today);

            // Orders this week (Monday as start)
            int diffToMonday = ((int)today.DayOfWeek + 6) % 7; // 0=Monday, 6=Sunday
            DateTime monday = today.AddDays(-diffToMonday);
            int ordersThisWeek = orders.Count(o => o.OrderDate.Date >= monday && o.OrderDate.Date <= today);

            // Total revenue
            decimal revenue = orders.Sum(o => o.Total);

            // Update labels
            orderTodaylbl.Text = ordersToday.ToString();
            orderthisweekLbl.Text = ordersThisWeek.ToString();
            revenueLbl.Text = revenue.ToString("C2", CultureInfo.GetCultureInfo("en-US"));

            // --- DISPLAY ORDERS ---
            foreach (var order in orders)
            {
                Panel orderCard = ClonePanel(orderPanel);
                orderCard.Tag = order.Id;

                // White border
                orderCard.BorderStyle = BorderStyle.None;
                orderCard.Paint += (s, e) =>
                {
                    using (Pen pen = new Pen(Color.White, 1))
                        e.Graphics.DrawRectangle(pen, 0, 0, orderCard.Width - 1, orderCard.Height - 1);
                };

                // Update labels
                foreach (Control ctrl in orderCard.Controls)
                {
                    switch (ctrl.Name)
                    {
                        case "orderNumberLbl":
                            ctrl.Text = order.Name ?? string.Empty;
                            break;
                        case "ordercustomernameLbl":
                            ctrl.Text = order.NameOfPurchaser ?? "Walk-In";
                            break;
                         
                        case "listordernameLbl":
                            ctrl.Text = order.NameOfOrderPurchase ?? string.Empty;
                            break;
                        case "statusOrderLbl":
                            ctrl.Text = order.Status ?? string.Empty;
                            break;
                        case "dateOrderlbl":
                            ctrl.Text = order.OrderDate.ToString("MMMM d, yyyy");
                            break;
                        case "timeOrderlbl":
                            ctrl.Text = order.OrderDate.ToString("h:mm tt");
                            break;
                        case "totalOrderlbl":
                            ctrl.Text = order.Total.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
                            break;
                    }
                }

                flowLayoutPanelOrder.Controls.Add(orderCard);
            }
        }

        private Panel ClonePanel(Panel template)
        {
            Panel newPanel = new Panel
            {
                Size = template.Size,
                BorderStyle = template.BorderStyle,
                BackColor = template.BackColor
            };

            foreach (Control ctrl in template.Controls)
            {
                Control newCtrl;

                if (ctrl is Label lbl)
                {
                    newCtrl = new Label
                    {
                        Name = lbl.Name,
                        Text = lbl.Text,
                        Location = lbl.Location,
                        Size = lbl.Size,
                        Font = lbl.Font,
                        ForeColor = lbl.ForeColor,
                        AutoSize = lbl.AutoSize
                    };
                }
                else if (ctrl is Button btn)
                {
                    newCtrl = new Button
                    {
                        Name = btn.Name,
                        Text = btn.Text,
                        Location = btn.Location,
                        Size = btn.Size,
                        Font = btn.Font,
                        BackColor = btn.BackColor
                    };
                }
                else if (ctrl is PictureBox pb)
                {
                    newCtrl = new PictureBox
                    {   
                        Name = pb.Name,
                        Size = pb.Size,
                        Location = pb.Location,
                        Image = pb.Image,
                        SizeMode = pb.SizeMode
                    };
                }
                else
                {
                    newCtrl = new Control
                    {
                        Name = ctrl.Name,
                        Location = ctrl.Location,
                        Size = ctrl.Size,
                        Font = ctrl.Font
                    };
                }

                newPanel.Controls.Add(newCtrl);
            }

            return newPanel;
        }
    }
}