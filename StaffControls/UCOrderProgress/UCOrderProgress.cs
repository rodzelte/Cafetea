using Cafetea.Database.Staff.ProgressService;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Cafetea.StaffControls.UCOrderProgress
{
    public partial class UCOrderProgress : UserControl
    {
        private OrderProgressService orderService = new();
        private List<OrderProgressService.OrderProgress> orders = new();

        public UCOrderProgress()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            flowPanelOrder.Controls.Clear();
            orders = orderService.GetPendingOrders();

            foreach (var order in orders)
            {
                Panel orderCard = ClonePanel(orderTemplate);
                orderCard.Tag = order.Id;

                foreach (Control ctrl in orderCard.Controls)
                {
                    switch (ctrl.Name)
                    {
                        case "orderNumberLbl":
                            ctrl.Text = order.Name;
                            break;
                        case "ordercustomernameLbl":
                            ctrl.Text = order.NameOfPurchaser;
                            break;
                        case "listordernameLbl":
                            ctrl.Text = order.NameOfOrderPurchase;
                            break;
                        case "statusOrderLbl":
                            ctrl.Text = order.Status;
                            break;
                        case "totalOrderlbl":
                            ctrl.Text = order.Total.ToString("C2", CultureInfo.GetCultureInfo("en-US"));
                            break;
                        case "completeOrderBtn":
                            if (ctrl is Guna2Button btn)
                            {
                                btn.Tag = order.Id;
                                btn.Enabled = order.Status != "Completed"; // disable if already completed
                                btn.Click -= CompleteBtn_Click;
                                btn.Click += CompleteBtn_Click;
                            }
                            break;
                    }
                }

                flowPanelOrder.Controls.Add(orderCard);
            }
        }

        private void CompleteBtn_Click(object? sender, EventArgs e)
        {
            if (sender is Guna2Button btn && btn.Tag is int orderId)
            {
                var confirm = MessageBox.Show("Mark this order as Completed?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                try
                {
                    // 1️⃣ Update the database
                    orderService.MarkAsCompleted(orderId);

                    // 2️⃣ Update the status label
                    var parentPanel = btn.Parent;
                    if (parentPanel != null)
                    {
                        var statusLabel = parentPanel.Controls
                            .OfType<Label>()
                            .FirstOrDefault(l => l.Name == "statusOrderLbl");

                        if (statusLabel != null)
                            statusLabel.Text = "Completed";

                        // 3️⃣ Disable the button
                        btn.Enabled = false;
                        btn.FillColor = System.Drawing.Color.Gray; // optional visual cue
                    }

                    MessageBox.Show("Order marked as Completed!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating order: " + ex.Message);
                }
            }
        }

        private Panel ClonePanel(Panel template)
        {
            Panel newPanel = new()
            {
                Size = template.Size,
                BackColor = System.Drawing.Color.FromArgb(16, 22, 33),
                BorderStyle = template.BorderStyle
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
                else if (ctrl is Guna2Button gbtn)
                {
                    newCtrl = new Guna2Button
                    {
                        Name = gbtn.Name,
                        Text = gbtn.Text,
                        Location = gbtn.Location,
                        Size = gbtn.Size,
                        Font = gbtn.Font,
                        FillColor = gbtn.FillColor,
                        ForeColor = gbtn.ForeColor,
                        BorderRadius = gbtn.BorderRadius,
                        ShadowDecoration = gbtn.ShadowDecoration
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