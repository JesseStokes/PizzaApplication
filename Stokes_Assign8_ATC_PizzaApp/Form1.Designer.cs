namespace Stokes_Assign8_ATC_PizzaApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPizza = new System.Windows.Forms.TabPage();
            this.listBoxToppings = new System.Windows.Forms.ListBox();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.tpBeverages = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWater = new System.Windows.Forms.TextBox();
            this.tbSoda = new System.Windows.Forms.TextBox();
            this.lbWater = new System.Windows.Forms.Label();
            this.lbSoda = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tpOtherItems = new System.Windows.Forms.TabPage();
            this.cbOtherItems = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.btPlaceOrder = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpPizza.SuspendLayout();
            this.tpBeverages.SuspendLayout();
            this.tpOtherItems.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPizza);
            this.tabControl1.Controls.Add(this.tpBeverages);
            this.tabControl1.Controls.Add(this.tpOtherItems);
            this.tabControl1.Controls.Add(this.tpCustomerInfo);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1284, 726);
            this.tabControl1.TabIndex = 0;
            // 
            // tpPizza
            // 
            this.tpPizza.Controls.Add(this.listBoxToppings);
            this.tpPizza.Controls.Add(this.lbToppings);
            this.tpPizza.Controls.Add(this.lbSize);
            this.tpPizza.Controls.Add(this.cbSize);
            this.tpPizza.Location = new System.Drawing.Point(10, 48);
            this.tpPizza.Name = "tpPizza";
            this.tpPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tpPizza.Size = new System.Drawing.Size(1264, 668);
            this.tpPizza.TabIndex = 0;
            this.tpPizza.Text = "Pizza";
            this.tpPizza.UseVisualStyleBackColor = true;
            // 
            // listBoxToppings
            // 
            this.listBoxToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxToppings.FormattingEnabled = true;
            this.listBoxToppings.ItemHeight = 46;
            this.listBoxToppings.Items.AddRange(new object[] {
            "Black Olives",
            "Extra Cheese",
            "Garlic",
            "Green Olives",
            "Green Peppers",
            "Mushroom",
            "Onions",
            "Pepperoni",
            "Pineapple",
            "Sausage",
            "Spinach"});
            this.listBoxToppings.Location = new System.Drawing.Point(673, 207);
            this.listBoxToppings.Name = "listBoxToppings";
            this.listBoxToppings.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxToppings.Size = new System.Drawing.Size(526, 372);
            this.listBoxToppings.TabIndex = 3;
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbToppings.Location = new System.Drawing.Point(748, 143);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(334, 46);
            this.lbToppings.TabIndex = 2;
            this.lbToppings.Text = "Toppings - $1.50";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSize.Location = new System.Drawing.Point(246, 143);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(102, 46);
            this.lbSize.TabIndex = 1;
            this.lbSize.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "Small (10\") - $9.95",
            "Medium (12\") - $12.95",
            "Large (16\") - $15.95"});
            this.cbSize.Location = new System.Drawing.Point(57, 207);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(475, 54);
            this.cbSize.TabIndex = 0;
            this.cbSize.Text = "Select Size";
            // 
            // tpBeverages
            // 
            this.tpBeverages.Controls.Add(this.label1);
            this.tpBeverages.Controls.Add(this.tbWater);
            this.tpBeverages.Controls.Add(this.tbSoda);
            this.tpBeverages.Controls.Add(this.lbWater);
            this.tpBeverages.Controls.Add(this.lbSoda);
            this.tpBeverages.Controls.Add(this.lbQuantity);
            this.tpBeverages.Location = new System.Drawing.Point(10, 48);
            this.tpBeverages.Name = "tpBeverages";
            this.tpBeverages.Padding = new System.Windows.Forms.Padding(3);
            this.tpBeverages.Size = new System.Drawing.Size(1264, 668);
            this.tpBeverages.TabIndex = 1;
            this.tpBeverages.Text = "Beverages";
            this.tpBeverages.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(301, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(656, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soda cost is $1.75 - Water is free!";
            // 
            // tbWater
            // 
            this.tbWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWater.Location = new System.Drawing.Point(631, 272);
            this.tbWater.Name = "tbWater";
            this.tbWater.Size = new System.Drawing.Size(132, 53);
            this.tbWater.TabIndex = 4;
            this.tbWater.Text = "0";
            this.tbWater.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSoda
            // 
            this.tbSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoda.Location = new System.Drawing.Point(631, 203);
            this.tbSoda.Name = "tbSoda";
            this.tbSoda.Size = new System.Drawing.Size(132, 53);
            this.tbSoda.TabIndex = 3;
            this.tbSoda.Text = "0";
            this.tbSoda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbWater
            // 
            this.lbWater.AutoSize = true;
            this.lbWater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWater.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbWater.Location = new System.Drawing.Point(424, 275);
            this.lbWater.Name = "lbWater";
            this.lbWater.Size = new System.Drawing.Size(180, 46);
            this.lbWater.TabIndex = 2;
            this.lbWater.Text = "Water(s)";
            // 
            // lbSoda
            // 
            this.lbSoda.AutoSize = true;
            this.lbSoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbSoda.Location = new System.Drawing.Point(424, 206);
            this.lbSoda.Name = "lbSoda";
            this.lbSoda.Size = new System.Drawing.Size(167, 46);
            this.lbSoda.TabIndex = 1;
            this.lbSoda.Text = "Soda(s)";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(544, 102);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(176, 46);
            this.lbQuantity.TabIndex = 0;
            this.lbQuantity.Text = "Quantity";
            // 
            // tpOtherItems
            // 
            this.tpOtherItems.Controls.Add(this.cbOtherItems);
            this.tpOtherItems.Controls.Add(this.label2);
            this.tpOtherItems.Location = new System.Drawing.Point(10, 48);
            this.tpOtherItems.Name = "tpOtherItems";
            this.tpOtherItems.Size = new System.Drawing.Size(1264, 668);
            this.tpOtherItems.TabIndex = 2;
            this.tpOtherItems.Text = "Other Items";
            this.tpOtherItems.UseVisualStyleBackColor = true;
            // 
            // cbOtherItems
            // 
            this.cbOtherItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOtherItems.FormattingEnabled = true;
            this.cbOtherItems.Items.AddRange(new object[] {
            "Wings - $5.00",
            "Cheese Sticks - $4.00",
            "Garlic Bread - $3.00"});
            this.cbOtherItems.Location = new System.Drawing.Point(345, 233);
            this.cbOtherItems.Name = "cbOtherItems";
            this.cbOtherItems.Size = new System.Drawing.Size(580, 54);
            this.cbOtherItems.TabIndex = 1;
            this.cbOtherItems.Text = "Select One Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(446, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose Other Item";
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.tbEmail);
            this.tpCustomerInfo.Controls.Add(this.tbPhone);
            this.tpCustomerInfo.Controls.Add(this.tbAddress);
            this.tpCustomerInfo.Controls.Add(this.tbName);
            this.tpCustomerInfo.Controls.Add(this.lbEmail);
            this.tpCustomerInfo.Controls.Add(this.lbPhone);
            this.tpCustomerInfo.Controls.Add(this.lbAddress);
            this.tpCustomerInfo.Controls.Add(this.lbName);
            this.tpCustomerInfo.Location = new System.Drawing.Point(10, 48);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Size = new System.Drawing.Size(1264, 668);
            this.tpCustomerInfo.TabIndex = 3;
            this.tpCustomerInfo.Text = "Customer Info";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(448, 325);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(633, 53);
            this.tbEmail.TabIndex = 7;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhone.Location = new System.Drawing.Point(448, 251);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(633, 53);
            this.tbPhone.TabIndex = 6;
            // 
            // tbAddress
            // 
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(448, 169);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(633, 53);
            this.tbAddress.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(448, 79);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(633, 53);
            this.tbName.TabIndex = 4;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbEmail.Location = new System.Drawing.Point(277, 328);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(131, 46);
            this.lbEmail.TabIndex = 3;
            this.lbEmail.Text = "Email:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbPhone.Location = new System.Drawing.Point(261, 246);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(147, 46);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbAddress.Location = new System.Drawing.Point(77, 164);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(331, 46);
            this.lbAddress.TabIndex = 1;
            this.lbAddress.Text = "Delivery Address:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbName.Location = new System.Drawing.Point(271, 82);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(137, 46);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(79, 755);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(475, 70);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "Reset Order";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btPlaceOrder
            // 
            this.btPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPlaceOrder.Location = new System.Drawing.Point(758, 755);
            this.btPlaceOrder.Name = "btPlaceOrder";
            this.btPlaceOrder.Size = new System.Drawing.Size(475, 70);
            this.btPlaceOrder.TabIndex = 2;
            this.btPlaceOrder.Text = "Place Order";
            this.btPlaceOrder.UseVisualStyleBackColor = true;
            this.btPlaceOrder.Click += new System.EventHandler(this.btPlaceOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 866);
            this.Controls.Add(this.btPlaceOrder);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ATC Pizza";
            this.tabControl1.ResumeLayout(false);
            this.tpPizza.ResumeLayout(false);
            this.tpPizza.PerformLayout();
            this.tpBeverages.ResumeLayout(false);
            this.tpBeverages.PerformLayout();
            this.tpOtherItems.ResumeLayout(false);
            this.tpOtherItems.PerformLayout();
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPizza;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.TabPage tpBeverages;
        private System.Windows.Forms.TabPage tpOtherItems;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private System.Windows.Forms.ListBox listBoxToppings;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btPlaceOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWater;
        private System.Windows.Forms.TextBox tbSoda;
        private System.Windows.Forms.Label lbWater;
        private System.Windows.Forms.Label lbSoda;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.ComboBox cbOtherItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
    }
}

