namespace Cafetea.StaffControls.UCOrderProgress
{
    partial class UCOrderProgress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            flowPanelOrder = new FlowLayoutPanel();
            orderTemplate = new Guna.UI2.WinForms.Guna2Panel();
            completeOrderBtn = new Guna.UI2.WinForms.Guna2Button();
            totalOrderlbl = new Label();
            orderNumberLbl = new Label();
            label15 = new Label();
            ordercustomernameLbl = new Label();
            listordernameLbl = new Label();
            label8 = new Label();
            label10 = new Label();
            statusOrderLbl = new Label();
            flowPanelOrder.SuspendLayout();
            orderTemplate.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(43, 23);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Order Progress";
            // 
            // flowPanelOrder
            // 
            flowPanelOrder.AutoScroll = true;
            flowPanelOrder.Controls.Add(orderTemplate);
            flowPanelOrder.FlowDirection = FlowDirection.TopDown;
            flowPanelOrder.Location = new Point(43, 106);
            flowPanelOrder.Name = "flowPanelOrder";
            flowPanelOrder.Padding = new Padding(0, 1, 0, 1);
            flowPanelOrder.Size = new Size(849, 432);
            flowPanelOrder.TabIndex = 1;
            flowPanelOrder.WrapContents = false;
            // 
            // orderTemplate
            // 
            orderTemplate.Controls.Add(completeOrderBtn);
            orderTemplate.Controls.Add(totalOrderlbl);
            orderTemplate.Controls.Add(orderNumberLbl);
            orderTemplate.Controls.Add(label15);
            orderTemplate.Controls.Add(ordercustomernameLbl);
            orderTemplate.Controls.Add(listordernameLbl);
            orderTemplate.Controls.Add(label8);
            orderTemplate.Controls.Add(label10);
            orderTemplate.Controls.Add(statusOrderLbl);
            orderTemplate.CustomizableEdges = customizableEdges3;
            orderTemplate.Location = new Point(3, 4);
            orderTemplate.Name = "orderTemplate";
            orderTemplate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            orderTemplate.Size = new Size(846, 100);
            orderTemplate.TabIndex = 0;
            // 
            // completeOrderBtn
            // 
            completeOrderBtn.CustomizableEdges = customizableEdges1;
            completeOrderBtn.DisabledState.BorderColor = Color.DarkGray;
            completeOrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            completeOrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            completeOrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            completeOrderBtn.Font = new Font("Segoe UI", 9F);
            completeOrderBtn.ForeColor = Color.White;
            completeOrderBtn.Location = new Point(686, 41);
            completeOrderBtn.Name = "completeOrderBtn";
            completeOrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            completeOrderBtn.Size = new Size(125, 28);
            completeOrderBtn.TabIndex = 15;
            completeOrderBtn.Text = "Complete";
            // 
            // totalOrderlbl
            // 
            totalOrderlbl.AutoSize = true;
            totalOrderlbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalOrderlbl.ForeColor = Color.WhiteSmoke;
            totalOrderlbl.Location = new Point(548, 56);
            totalOrderlbl.Name = "totalOrderlbl";
            totalOrderlbl.Size = new Size(72, 25);
            totalOrderlbl.TabIndex = 14;
            totalOrderlbl.Text = "$12.59";
            // 
            // orderNumberLbl
            // 
            orderNumberLbl.AutoSize = true;
            orderNumberLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderNumberLbl.ForeColor = Color.WhiteSmoke;
            orderNumberLbl.Location = new Point(79, 28);
            orderNumberLbl.Name = "orderNumberLbl";
            orderNumberLbl.Size = new Size(77, 21);
            orderNumberLbl.TabIndex = 0;
            orderNumberLbl.Text = "ORD-001";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(562, 28);
            label15.Name = "label15";
            label15.Size = new Size(36, 17);
            label15.TabIndex = 13;
            label15.Text = "Total";
            // 
            // ordercustomernameLbl
            // 
            ordercustomernameLbl.AutoSize = true;
            ordercustomernameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ordercustomernameLbl.ForeColor = Color.WhiteSmoke;
            ordercustomernameLbl.Location = new Point(79, 52);
            ordercustomernameLbl.Name = "ordercustomernameLbl";
            ordercustomernameLbl.Size = new Size(63, 17);
            ordercustomernameLbl.TabIndex = 1;
            ordercustomernameLbl.Text = "John Doe";
            // 
            // listordernameLbl
            // 
            listordernameLbl.AutoEllipsis = true;
            listordernameLbl.AutoSize = true;
            listordernameLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listordernameLbl.ForeColor = Color.WhiteSmoke;
            listordernameLbl.Location = new Point(117, 71);
            listordernameLbl.Name = "listordernameLbl";
            listordernameLbl.Size = new Size(70, 17);
            listordernameLbl.TabIndex = 3;
            listordernameLbl.Text = "Cappucino";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(79, 71);
            label8.Name = "label8";
            label8.Size = new Size(42, 17);
            label8.TabIndex = 2;
            label8.Text = "Items:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(400, 28);
            label10.Name = "label10";
            label10.Size = new Size(43, 17);
            label10.TabIndex = 4;
            label10.Text = "Status";
            // 
            // statusOrderLbl
            // 
            statusOrderLbl.AutoSize = true;
            statusOrderLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusOrderLbl.ForeColor = Color.WhiteSmoke;
            statusOrderLbl.Location = new Point(374, 56);
            statusOrderLbl.Name = "statusOrderLbl";
            statusOrderLbl.Size = new Size(90, 21);
            statusOrderLbl.TabIndex = 5;
            statusOrderLbl.Text = "InProgress";
            // 
            // UCOrderProgress
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            Controls.Add(flowPanelOrder);
            Controls.Add(label1);
            Name = "UCOrderProgress";
            Size = new Size(869, 495);
            flowPanelOrder.ResumeLayout(false);
            orderTemplate.ResumeLayout(false);
            orderTemplate.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowPanelOrder;
        private Guna.UI2.WinForms.Guna2Panel orderTemplate;
        private Label totalOrderlbl;
        private Label label15;
        private Label statusOrderLbl;
        private Label label10;
        private Label listordernameLbl;
        private Label label8;
        private Label ordercustomernameLbl;
        private Label orderNumberLbl;
        private Guna.UI2.WinForms.Guna2Button completeOrderBtn;
    }
}
