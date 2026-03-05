using Cafetea.ClientControls.UCCustomer;
using Cafetea.Database.Client.CustomerService;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cafetea.AdminControls
{
    public partial class UCCustomer : UserControl
    {
        private CustomerService customerService = new CustomerService();

        public UCCustomer()
        {
            InitializeComponent();
            csPanel.Visible = false; // Hide the template
            LoadCustomers();
        }

        // Load all customers
        private void LoadCustomers()
        {
            flpCustomer.Controls.Clear();
            var customers = customerService.GetAllCustomers();

            foreach (var cs in customers)
            {
                Panel panel = CloneCustomerPanel(csPanel);
                panel.Tag = cs; // pass the entire customer object

                PopulatePanel(panel, cs);

                flpCustomer.Controls.Add(panel);
            }
        }

        // Populate cloned panel with customer data
        private void PopulatePanel(Panel panel, CustomerModel cs)
        {
            var nameLbl = panel.Controls.Find("csNamelbl", true).FirstOrDefault() as Label;
            var contactLbl = panel.Controls.Find("csContactlbl", true).FirstOrDefault() as Label;
            var emailLbl = panel.Controls.Find("csEmailLbl", true).FirstOrDefault() as Label;
            var favoriteLbl = panel.Controls.Find("favoriteItemOrderlbl", true).FirstOrDefault() as Label;
            var visitsLbl = panel.Controls.Find("visitCslbl", true).FirstOrDefault() as Label;
            var lastOrderLbl = panel.Controls.Find("customerLastOrderlbl", true).FirstOrDefault() as Label;
            var actionBtn = panel.Controls.Find("actionCustomerBtn", true).FirstOrDefault() as Button;

            if (nameLbl != null) nameLbl.Text = cs.Name;
            if (contactLbl != null) contactLbl.Text = cs.Contact;
            if (emailLbl != null) emailLbl.Text = cs.Email;
            if (favoriteLbl != null) favoriteLbl.Text = $"{cs.FavoriteOrder}";
            if (visitsLbl != null) visitsLbl.Text = $"{cs.VisitsCount}";
            if (lastOrderLbl != null) lastOrderLbl.Text = $"{(cs.LastOrderDate.HasValue ? cs.LastOrderDate.Value.ToString("MMM dd, yyyy") : "-")}";

            if (actionBtn != null)
            {
                actionBtn.Click -= ActionBtn_Click;
                actionBtn.Click += ActionBtn_Click;
                actionBtn.Tag = cs;
            }
        }

        // Event handler for action buttons
        private void ActionBtn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is CustomerModel cs)
            {
                CustomerForm form = new CustomerForm();
                form.SetCustomerData(cs.Name, cs.Email);
                form.Show();
            }
        }

        // Clone pre-designed panel
        private Panel CloneCustomerPanel(Panel template)
        {
            Panel newPanel = new Panel
            {
                Size = template.Size,
                BorderStyle = template.BorderStyle,
                BackColor = Color.FromArgb(16,22,33),
                Margin = template.Margin,
                Padding = template.Padding
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
                        AutoSize = lbl.AutoSize,
                        TextAlign = lbl.TextAlign,
                        
                    };
                }
                else if (ctrl is Button btn)
                {
                    newCtrl = new Button
                    {
                        Name = btn.Name,
                        Text = btn.Text,
                        Size = btn.Size,
                        Location = btn.Location,
                        Font = btn.Font,
                       
                        Image = btn.Image,           
                        ImageAlign = btn.ImageAlign,
                        TextImageRelation = btn.TextImageRelation
                    };
                }
                else
                {
                    newCtrl = new Control
                    {
                        Name = ctrl.Name,
                        Size = ctrl.Size,
                        Location = ctrl.Location,
                        Font = ctrl.Font,
                        BackColor = ctrl.BackColor
                    };
                }

                newPanel.Controls.Add(newCtrl);
            }

            return newPanel;
        }
        // Search customers
        private void cssearchBtn_Click(object sender, EventArgs e)
        {
            flpCustomer.Controls.Clear();
            string keyword = csSearchTextbox.Text.Trim();

            var results = customerService.SearchCustomers(keyword);

            foreach (var cs in results)
            {
                Panel panel = CloneCustomerPanel(csPanel);
                panel.Tag = cs;
                PopulatePanel(panel, cs);

                flpCustomer.Controls.Add(panel);
            }
        }

    
    }
}