using Cafetea.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafetea.ClientControls.UCPromo
{
    public partial class AddPromo : Form
    {
        public AddPromo()
        {
            InitializeComponent();
            // Prevent user typing
            discountCB.DropDownStyle = ComboBoxStyle.DropDownList;

            // Populate with 10% to 60% (step 10)
            for (int i = 10; i <= 60; i += 10)
            {
                discountCB.Items.Add(i.ToString());
            }

            // Optional: select first item by default
            if (discountCB.Items.Count > 0)
                discountCB.SelectedIndex = 0;

        }

        private void codeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addPromoBtn_Click(object sender, EventArgs e)
        {
            string code = codeTb.Text.Trim();
            string description = descriptionTb.Text.Trim();

            // Get discount from ComboBox safely
            if (discountCB.SelectedItem == null)
            {
                MessageBox.Show("Please select a discount.");
                return;
            }

            decimal discount = decimal.Parse(discountCB.SelectedItem.ToString()!);

            // Extra safety check (optional)
            if (discount < 10 || discount > 60)
            {
                MessageBox.Show("Discount must be between 10% and 60%.");
                return;
            }

            bool success = PromoService.AddPromo(code, description, discount);

            if (success)
            {
                MessageBox.Show("Promo added successfully!");

                // Set public DialogResult so parent can refresh
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Promo code already exists.");
            }
        }
    }
}
