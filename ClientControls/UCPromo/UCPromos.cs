using Cafetea.ClientControls.UCPromo;
using Cafetea.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Cafetea.AdminControls
{
    public partial class UCPromos : UserControl
    {
        public UCPromos()
        {
            InitializeComponent();
            framePromo.Visible = false;
            LoadPromos();
        }

        private void ucAddPromoBtn_Click(object sender, EventArgs e)
        {
            AddPromo promoForm = new AddPromo();

            // Open modally and wait for result
            if (promoForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh after adding
                LoadPromos();
            }
        }



        private void LoadPromos()
        {
            flowlayoutPanelPromo.Controls.Clear();
            framePromo.Visible = false; // template stays hidden

            var promos = PromoService.GetAllPromos();

            // Count active and deleted promos
            int activeCount = 0;
            int deletedCount = 0;

            foreach (var promo in promos)
            {
                if (promo.IsActive)
                    activeCount++;
                else
                    deletedCount++;

                // Only show active promos in the panel
                if (!promo.IsActive) continue;

                // Clone the template panel
                Panel promoCard = ClonePanel(framePromo);

                // Set the promo card color
                promoCard.BackColor = Color.FromArgb(16, 22, 33);

                // store promo id for buttons
                promoCard.Tag = promo.Id;

                // update labels inside cloned panel
                foreach (Control ctrl in promoCard.Controls)
                {
                    if (ctrl.Name == "promocodeLbl") ctrl.Text = promo.Code;
                    if (ctrl.Name == "promoDescriptionLbl") ctrl.Text = promo.Description;
                    if (ctrl.Name == "discountpercentageLbl") ctrl.Text = promo.DiscountPercent + "%";

                    // Optional: change label text color to make it visible on dark background
                    ctrl.ForeColor = Color.White;
                }

                flowlayoutPanelPromo.Controls.Add(promoCard);
            }

            // Update summary labels
            activePromo.Text = $"Active Promos: {activeCount}";
            deletedPromo.Text = $"Expired Promos: {deletedCount}";
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
                        Name = lbl.Name,          // important to identify later
                        Text = lbl.Text,
                        Location = lbl.Location,
                        Size = lbl.Size,
                        Font = lbl.Font,
                        ForeColor = lbl.ForeColor
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
                        BackColor = Color.FromArgb(16, 22, 33)
                    };

                    // Optional: attach a click event dynamically
                    newCtrl.Click += (s, e) =>
                    {
                        if (s == null) return; // sender is null safety
                        if (newPanel.Tag is not int promoId) return; // Tag null or not int

                        DeletePromoHandler(s, e, promoId);
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

        private void DeletePromoHandler(object sender, EventArgs e, int promoId)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete this promo?",
                                          "Delete Promo", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                PromoService.DeletePromo(promoId);
                LoadPromos(); // refresh list
            }
        }


        private void flowlayoutPanelPromo_Paint(object sender, PaintEventArgs e)
        {
            flowlayoutPanelPromo.AutoScroll = true;
            flowlayoutPanelPromo.FlowDirection = FlowDirection.TopDown;
            flowlayoutPanelPromo.WrapContents = false;
        }

      
    }
}
