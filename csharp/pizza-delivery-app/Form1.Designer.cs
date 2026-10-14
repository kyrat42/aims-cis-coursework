namespace Pizza_Delivery_App_2
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tabControl1 = new TabControl();
            tabPgePizza = new TabPage();
            nmcUpDwnQtyPizza = new NumericUpDown();
            lblInputToppings = new Label();
            lstBoxToppings = new ListBox();
            lblInputQtyPizza = new Label();
            cmbBoxSauce = new ComboBox();
            lblInputSauce = new Label();
            cmbBoxCrust = new ComboBox();
            lblInputCrust = new Label();
            cmbBoxSize = new ComboBox();
            lblInputSize = new Label();
            btnToCartPizza = new Button();
            tabPgeDrinks = new TabPage();
            btnToCartDrinks = new Button();
            label3 = new Label();
            label2 = new Label();
            nmcUpDwnWater = new NumericUpDown();
            lblInputWater = new Label();
            nmcUpDwnDrPepper = new NumericUpDown();
            lblInputDrPepper = new Label();
            nmcUpDwnMtnDew = new NumericUpDown();
            lblInputMtnDew = new Label();
            nmcUpDwnCoke = new NumericUpDown();
            lblInputCoke = new Label();
            tabPgeOther = new TabPage();
            btnToCartOther = new Button();
            label4 = new Label();
            label5 = new Label();
            nmcUpDwnCookie = new NumericUpDown();
            lblInputCookie = new Label();
            nmcUpDwnBread = new NumericUpDown();
            lblInputBread = new Label();
            nmcUpDwnFries = new NumericUpDown();
            lblInputFries = new Label();
            nmcUpDwnWings = new NumericUpDown();
            lblInputWings = new Label();
            tabPgeCustomer = new TabPage();
            txtBoxEmail = new TextBox();
            lblInputEmail = new Label();
            txtBoxPhone = new TextBox();
            lblInputPhone = new Label();
            txtBoxAddress = new TextBox();
            lblInputAddress = new Label();
            txtBoxName = new TextBox();
            lblInputName = new Label();
            lblTotal = new Label();
            lblOrderLists = new Label();
            lstBoxCartPrices = new ListBox();
            lstBoxCartDescriptions = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPgePizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnQtyPizza).BeginInit();
            tabPgeDrinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnDrPepper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnMtnDew).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnCoke).BeginInit();
            tabPgeOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnCookie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnBread).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnFries).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnWings).BeginInit();
            tabPgeCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPgePizza);
            tabControl1.Controls.Add(tabPgeDrinks);
            tabControl1.Controls.Add(tabPgeOther);
            tabControl1.Controls.Add(tabPgeCustomer);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 383);
            tabControl1.TabIndex = 0;
            // 
            // tabPgePizza
            // 
            tabPgePizza.BackgroundImage = (Image)resources.GetObject("tabPgePizza.BackgroundImage");
            tabPgePizza.Controls.Add(nmcUpDwnQtyPizza);
            tabPgePizza.Controls.Add(lblInputToppings);
            tabPgePizza.Controls.Add(lstBoxToppings);
            tabPgePizza.Controls.Add(lblInputQtyPizza);
            tabPgePizza.Controls.Add(cmbBoxSauce);
            tabPgePizza.Controls.Add(lblInputSauce);
            tabPgePizza.Controls.Add(cmbBoxCrust);
            tabPgePizza.Controls.Add(lblInputCrust);
            tabPgePizza.Controls.Add(cmbBoxSize);
            tabPgePizza.Controls.Add(lblInputSize);
            tabPgePizza.Controls.Add(btnToCartPizza);
            tabPgePizza.Location = new Point(4, 29);
            tabPgePizza.Name = "tabPgePizza";
            tabPgePizza.Padding = new Padding(3);
            tabPgePizza.Size = new Size(768, 350);
            tabPgePizza.TabIndex = 0;
            tabPgePizza.Text = "Pizza";
            tabPgePizza.UseVisualStyleBackColor = true;
            // 
            // nmcUpDwnQtyPizza
            // 
            nmcUpDwnQtyPizza.Location = new Point(584, 315);
            nmcUpDwnQtyPizza.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmcUpDwnQtyPizza.Name = "nmcUpDwnQtyPizza";
            nmcUpDwnQtyPizza.Size = new Size(78, 27);
            nmcUpDwnQtyPizza.TabIndex = 14;
            nmcUpDwnQtyPizza.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblInputToppings
            // 
            lblInputToppings.AutoSize = true;
            lblInputToppings.BackColor = Color.White;
            lblInputToppings.Location = new Point(344, 17);
            lblInputToppings.Name = "lblInputToppings";
            lblInputToppings.Size = new Size(154, 20);
            lblInputToppings.TabIndex = 13;
            lblInputToppings.Text = "Toppings ($0.50 each)";
            // 
            // lstBoxToppings
            // 
            lstBoxToppings.FormattingEnabled = true;
            lstBoxToppings.Items.AddRange(new object[] { "Black Olives", "Green Olives", "Pepperoni", "Pineapple", "Sausage", "Bacon", "Anchovies", "Ground Beef", "Pickles", "Extra Cheese", "Extra Sauce", "Mushrooms", "Green Peppers", "Onions" });
            lstBoxToppings.Location = new Point(344, 40);
            lstBoxToppings.Name = "lstBoxToppings";
            lstBoxToppings.SelectionMode = SelectionMode.MultiExtended;
            lstBoxToppings.Size = new Size(150, 284);
            lstBoxToppings.TabIndex = 12;
            // 
            // lblInputQtyPizza
            // 
            lblInputQtyPizza.AutoSize = true;
            lblInputQtyPizza.BackColor = Color.White;
            lblInputQtyPizza.Location = new Point(543, 318);
            lblInputQtyPizza.Name = "lblInputQtyPizza";
            lblInputQtyPizza.Size = new Size(35, 20);
            lblInputQtyPizza.TabIndex = 11;
            lblInputQtyPizza.Text = "Qty:";
            // 
            // cmbBoxSauce
            // 
            cmbBoxSauce.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSauce.FormattingEnabled = true;
            cmbBoxSauce.Items.AddRange(new object[] { "Red", "White" });
            cmbBoxSauce.Location = new Point(6, 257);
            cmbBoxSauce.Name = "cmbBoxSauce";
            cmbBoxSauce.Size = new Size(241, 28);
            cmbBoxSauce.TabIndex = 9;
            // 
            // lblInputSauce
            // 
            lblInputSauce.AutoSize = true;
            lblInputSauce.BackColor = Color.White;
            lblInputSauce.Location = new Point(39, 234);
            lblInputSauce.Name = "lblInputSauce";
            lblInputSauce.Size = new Size(58, 20);
            lblInputSauce.TabIndex = 8;
            lblInputSauce.Text = "Sauce *";
            // 
            // cmbBoxCrust
            // 
            cmbBoxCrust.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxCrust.FormattingEnabled = true;
            cmbBoxCrust.Items.AddRange(new object[] { "Thin", "Regular", "Cheese-Stuffed" });
            cmbBoxCrust.Location = new Point(6, 143);
            cmbBoxCrust.Name = "cmbBoxCrust";
            cmbBoxCrust.Size = new Size(241, 28);
            cmbBoxCrust.TabIndex = 7;
            // 
            // lblInputCrust
            // 
            lblInputCrust.AutoSize = true;
            lblInputCrust.BackColor = Color.White;
            lblInputCrust.Location = new Point(39, 120);
            lblInputCrust.Name = "lblInputCrust";
            lblInputCrust.Size = new Size(52, 20);
            lblInputCrust.TabIndex = 6;
            lblInputCrust.Text = "Crust *";
            // 
            // cmbBoxSize
            // 
            cmbBoxSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxSize.FormattingEnabled = true;
            cmbBoxSize.Items.AddRange(new object[] { "Personal (6\") - $8.99", "Regular (12\") - $12.99", "Party (18\") - $15.99" });
            cmbBoxSize.Location = new Point(6, 40);
            cmbBoxSize.Name = "cmbBoxSize";
            cmbBoxSize.Size = new Size(241, 28);
            cmbBoxSize.TabIndex = 5;
            // 
            // lblInputSize
            // 
            lblInputSize.AutoSize = true;
            lblInputSize.BackColor = Color.White;
            lblInputSize.Location = new Point(39, 17);
            lblInputSize.Name = "lblInputSize";
            lblInputSize.Size = new Size(46, 20);
            lblInputSize.TabIndex = 4;
            lblInputSize.Text = "Size *";
            // 
            // btnToCartPizza
            // 
            btnToCartPizza.Location = new Point(668, 315);
            btnToCartPizza.Name = "btnToCartPizza";
            btnToCartPizza.Size = new Size(94, 29);
            btnToCartPizza.TabIndex = 3;
            btnToCartPizza.Text = "Add to Cart";
            btnToCartPizza.UseVisualStyleBackColor = true;
            btnToCartPizza.Click += btnToCartPizza_Click;
            // 
            // tabPgeDrinks
            // 
            tabPgeDrinks.BackgroundImage = (Image)resources.GetObject("tabPgeDrinks.BackgroundImage");
            tabPgeDrinks.Controls.Add(btnToCartDrinks);
            tabPgeDrinks.Controls.Add(label3);
            tabPgeDrinks.Controls.Add(label2);
            tabPgeDrinks.Controls.Add(nmcUpDwnWater);
            tabPgeDrinks.Controls.Add(lblInputWater);
            tabPgeDrinks.Controls.Add(nmcUpDwnDrPepper);
            tabPgeDrinks.Controls.Add(lblInputDrPepper);
            tabPgeDrinks.Controls.Add(nmcUpDwnMtnDew);
            tabPgeDrinks.Controls.Add(lblInputMtnDew);
            tabPgeDrinks.Controls.Add(nmcUpDwnCoke);
            tabPgeDrinks.Controls.Add(lblInputCoke);
            tabPgeDrinks.Location = new Point(4, 29);
            tabPgeDrinks.Name = "tabPgeDrinks";
            tabPgeDrinks.Padding = new Padding(3);
            tabPgeDrinks.Size = new Size(768, 350);
            tabPgeDrinks.TabIndex = 1;
            tabPgeDrinks.Text = "Drinks";
            tabPgeDrinks.UseVisualStyleBackColor = true;
            // 
            // btnToCartDrinks
            // 
            btnToCartDrinks.Location = new Point(668, 315);
            btnToCartDrinks.Name = "btnToCartDrinks";
            btnToCartDrinks.Size = new Size(94, 29);
            btnToCartDrinks.TabIndex = 10;
            btnToCartDrinks.Text = "Add to Cart";
            btnToCartDrinks.UseVisualStyleBackColor = true;
            btnToCartDrinks.Click += btnToCartDrinks_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 18F);
            label3.Location = new Point(447, 163);
            label3.Name = "label3";
            label3.Size = new Size(192, 48);
            label3.TabIndex = 9;
            label3.Text = "$1.50 each";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 18F);
            label2.Location = new Point(419, 93);
            label2.Name = "label2";
            label2.Size = new Size(278, 48);
            label2.TabIndex = 8;
            label2.Text = "Ice Cold Drinks!";
            // 
            // nmcUpDwnWater
            // 
            nmcUpDwnWater.Location = new Point(133, 244);
            nmcUpDwnWater.Name = "nmcUpDwnWater";
            nmcUpDwnWater.Size = new Size(82, 27);
            nmcUpDwnWater.TabIndex = 7;
            // 
            // lblInputWater
            // 
            lblInputWater.AutoSize = true;
            lblInputWater.BackColor = Color.White;
            lblInputWater.Location = new Point(6, 246);
            lblInputWater.Name = "lblInputWater";
            lblInputWater.Size = new Size(51, 20);
            lblInputWater.TabIndex = 6;
            lblInputWater.Text = "Water:";
            // 
            // nmcUpDwnDrPepper
            // 
            nmcUpDwnDrPepper.Location = new Point(133, 163);
            nmcUpDwnDrPepper.Name = "nmcUpDwnDrPepper";
            nmcUpDwnDrPepper.Size = new Size(82, 27);
            nmcUpDwnDrPepper.TabIndex = 5;
            // 
            // lblInputDrPepper
            // 
            lblInputDrPepper.AutoSize = true;
            lblInputDrPepper.BackColor = Color.White;
            lblInputDrPepper.Location = new Point(6, 165);
            lblInputDrPepper.Name = "lblInputDrPepper";
            lblInputDrPepper.Size = new Size(81, 20);
            lblInputDrPepper.TabIndex = 4;
            lblInputDrPepper.Text = "Dr. Pepper:";
            // 
            // nmcUpDwnMtnDew
            // 
            nmcUpDwnMtnDew.Location = new Point(133, 91);
            nmcUpDwnMtnDew.Name = "nmcUpDwnMtnDew";
            nmcUpDwnMtnDew.Size = new Size(82, 27);
            nmcUpDwnMtnDew.TabIndex = 3;
            // 
            // lblInputMtnDew
            // 
            lblInputMtnDew.AutoSize = true;
            lblInputMtnDew.BackColor = Color.White;
            lblInputMtnDew.Location = new Point(6, 93);
            lblInputMtnDew.Name = "lblInputMtnDew";
            lblInputMtnDew.Size = new Size(109, 20);
            lblInputMtnDew.TabIndex = 2;
            lblInputMtnDew.Text = "Mountain Dew:";
            // 
            // nmcUpDwnCoke
            // 
            nmcUpDwnCoke.Location = new Point(133, 12);
            nmcUpDwnCoke.Name = "nmcUpDwnCoke";
            nmcUpDwnCoke.Size = new Size(82, 27);
            nmcUpDwnCoke.TabIndex = 1;
            // 
            // lblInputCoke
            // 
            lblInputCoke.AutoSize = true;
            lblInputCoke.BackColor = Color.White;
            lblInputCoke.Location = new Point(6, 14);
            lblInputCoke.Name = "lblInputCoke";
            lblInputCoke.Size = new Size(81, 20);
            lblInputCoke.TabIndex = 0;
            lblInputCoke.Text = "Coca-Cola:";
            // 
            // tabPgeOther
            // 
            tabPgeOther.BackgroundImage = (Image)resources.GetObject("tabPgeOther.BackgroundImage");
            tabPgeOther.Controls.Add(btnToCartOther);
            tabPgeOther.Controls.Add(label4);
            tabPgeOther.Controls.Add(label5);
            tabPgeOther.Controls.Add(nmcUpDwnCookie);
            tabPgeOther.Controls.Add(lblInputCookie);
            tabPgeOther.Controls.Add(nmcUpDwnBread);
            tabPgeOther.Controls.Add(lblInputBread);
            tabPgeOther.Controls.Add(nmcUpDwnFries);
            tabPgeOther.Controls.Add(lblInputFries);
            tabPgeOther.Controls.Add(nmcUpDwnWings);
            tabPgeOther.Controls.Add(lblInputWings);
            tabPgeOther.Location = new Point(4, 29);
            tabPgeOther.Name = "tabPgeOther";
            tabPgeOther.Size = new Size(768, 350);
            tabPgeOther.TabIndex = 2;
            tabPgeOther.Text = "Other Items";
            tabPgeOther.UseVisualStyleBackColor = true;
            // 
            // btnToCartOther
            // 
            btnToCartOther.Location = new Point(668, 312);
            btnToCartOther.Name = "btnToCartOther";
            btnToCartOther.Size = new Size(94, 29);
            btnToCartOther.TabIndex = 21;
            btnToCartOther.Text = "Add to Cart";
            btnToCartOther.UseVisualStyleBackColor = true;
            btnToCartOther.Click += btnToCartOther_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 18F);
            label4.Location = new Point(372, 160);
            label4.Name = "label4";
            label4.Size = new Size(192, 48);
            label4.TabIndex = 20;
            label4.Text = "$6.99 each";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 18F);
            label5.Location = new Point(229, 88);
            label5.Name = "label5";
            label5.Size = new Size(536, 48);
            label5.TabIndex = 19;
            label5.Text = "Scrumptious Sides and Desserts!";
            // 
            // nmcUpDwnCookie
            // 
            nmcUpDwnCookie.Location = new Point(133, 241);
            nmcUpDwnCookie.Name = "nmcUpDwnCookie";
            nmcUpDwnCookie.Size = new Size(82, 27);
            nmcUpDwnCookie.TabIndex = 18;
            // 
            // lblInputCookie
            // 
            lblInputCookie.AutoSize = true;
            lblInputCookie.BackColor = Color.White;
            lblInputCookie.Location = new Point(6, 243);
            lblInputCookie.Name = "lblInputCookie";
            lblInputCookie.Size = new Size(96, 20);
            lblInputCookie.TabIndex = 17;
            lblInputCookie.Text = "Cookie Pizza:";
            // 
            // nmcUpDwnBread
            // 
            nmcUpDwnBread.Location = new Point(133, 160);
            nmcUpDwnBread.Name = "nmcUpDwnBread";
            nmcUpDwnBread.Size = new Size(82, 27);
            nmcUpDwnBread.TabIndex = 16;
            // 
            // lblInputBread
            // 
            lblInputBread.AutoSize = true;
            lblInputBread.BackColor = Color.White;
            lblInputBread.Location = new Point(6, 162);
            lblInputBread.Name = "lblInputBread";
            lblInputBread.Size = new Size(92, 20);
            lblInputBread.TabIndex = 15;
            lblInputBread.Text = "Bread Sticks:";
            // 
            // nmcUpDwnFries
            // 
            nmcUpDwnFries.Location = new Point(133, 88);
            nmcUpDwnFries.Name = "nmcUpDwnFries";
            nmcUpDwnFries.Size = new Size(82, 27);
            nmcUpDwnFries.TabIndex = 14;
            // 
            // lblInputFries
            // 
            lblInputFries.AutoSize = true;
            lblInputFries.BackColor = Color.White;
            lblInputFries.Location = new Point(6, 90);
            lblInputFries.Name = "lblInputFries";
            lblInputFries.Size = new Size(89, 20);
            lblInputFries.TabIndex = 13;
            lblInputFries.Text = "French Fries:";
            // 
            // nmcUpDwnWings
            // 
            nmcUpDwnWings.Location = new Point(133, 9);
            nmcUpDwnWings.Name = "nmcUpDwnWings";
            nmcUpDwnWings.Size = new Size(82, 27);
            nmcUpDwnWings.TabIndex = 12;
            // 
            // lblInputWings
            // 
            lblInputWings.AutoSize = true;
            lblInputWings.BackColor = Color.White;
            lblInputWings.Location = new Point(6, 11);
            lblInputWings.Name = "lblInputWings";
            lblInputWings.Size = new Size(75, 20);
            lblInputWings.TabIndex = 11;
            lblInputWings.Text = "Wings (6):";
            // 
            // tabPgeCustomer
            // 
            tabPgeCustomer.BackgroundImage = (Image)resources.GetObject("tabPgeCustomer.BackgroundImage");
            tabPgeCustomer.Controls.Add(txtBoxEmail);
            tabPgeCustomer.Controls.Add(lblInputEmail);
            tabPgeCustomer.Controls.Add(txtBoxPhone);
            tabPgeCustomer.Controls.Add(lblInputPhone);
            tabPgeCustomer.Controls.Add(txtBoxAddress);
            tabPgeCustomer.Controls.Add(lblInputAddress);
            tabPgeCustomer.Controls.Add(txtBoxName);
            tabPgeCustomer.Controls.Add(lblInputName);
            tabPgeCustomer.Controls.Add(lblTotal);
            tabPgeCustomer.Controls.Add(lblOrderLists);
            tabPgeCustomer.Controls.Add(lstBoxCartPrices);
            tabPgeCustomer.Controls.Add(lstBoxCartDescriptions);
            tabPgeCustomer.Controls.Add(btnOrder);
            tabPgeCustomer.Controls.Add(btnReset);
            tabPgeCustomer.Location = new Point(4, 29);
            tabPgeCustomer.Name = "tabPgeCustomer";
            tabPgeCustomer.Size = new Size(768, 350);
            tabPgeCustomer.TabIndex = 3;
            tabPgeCustomer.Text = "Customer Information";
            tabPgeCustomer.UseVisualStyleBackColor = true;
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(412, 220);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(332, 27);
            txtBoxEmail.TabIndex = 15;
            // 
            // lblInputEmail
            // 
            lblInputEmail.AutoSize = true;
            lblInputEmail.BackColor = Color.White;
            lblInputEmail.Location = new Point(412, 197);
            lblInputEmail.Name = "lblInputEmail";
            lblInputEmail.Size = new Size(56, 20);
            lblInputEmail.TabIndex = 14;
            lblInputEmail.Text = "Email *";
            // 
            // txtBoxPhone
            // 
            txtBoxPhone.Location = new Point(412, 159);
            txtBoxPhone.Name = "txtBoxPhone";
            txtBoxPhone.Size = new Size(332, 27);
            txtBoxPhone.TabIndex = 13;
            // 
            // lblInputPhone
            // 
            lblInputPhone.AutoSize = true;
            lblInputPhone.BackColor = Color.White;
            lblInputPhone.Location = new Point(412, 136);
            lblInputPhone.Name = "lblInputPhone";
            lblInputPhone.Size = new Size(60, 20);
            lblInputPhone.TabIndex = 12;
            lblInputPhone.Text = "Phone *";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Location = new Point(412, 95);
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(332, 27);
            txtBoxAddress.TabIndex = 11;
            // 
            // lblInputAddress
            // 
            lblInputAddress.AutoSize = true;
            lblInputAddress.BackColor = Color.White;
            lblInputAddress.Location = new Point(412, 72);
            lblInputAddress.Name = "lblInputAddress";
            lblInputAddress.Size = new Size(72, 20);
            lblInputAddress.TabIndex = 10;
            lblInputAddress.Text = "Address *";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(412, 32);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(332, 27);
            txtBoxName.TabIndex = 9;
            // 
            // lblInputName
            // 
            lblInputName.AutoSize = true;
            lblInputName.BackColor = Color.White;
            lblInputName.Location = new Point(412, 9);
            lblInputName.Name = "lblInputName";
            lblInputName.Size = new Size(59, 20);
            lblInputName.TabIndex = 8;
            lblInputName.Text = "Name *";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.White;
            lblTotal.Location = new Point(246, 279);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 20);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "Total:";
            // 
            // lblOrderLists
            // 
            lblOrderLists.AutoSize = true;
            lblOrderLists.BackColor = Color.White;
            lblOrderLists.Location = new Point(3, 9);
            lblOrderLists.Name = "lblOrderLists";
            lblOrderLists.Size = new Size(113, 20);
            lblOrderLists.TabIndex = 5;
            lblOrderLists.Text = "Order Summary";
            // 
            // lstBoxCartPrices
            // 
            lstBoxCartPrices.FormattingEnabled = true;
            lstBoxCartPrices.Location = new Point(246, 32);
            lstBoxCartPrices.Name = "lstBoxCartPrices";
            lstBoxCartPrices.Size = new Size(150, 244);
            lstBoxCartPrices.TabIndex = 4;
            // 
            // lstBoxCartDescriptions
            // 
            lstBoxCartDescriptions.FormattingEnabled = true;
            lstBoxCartDescriptions.Location = new Point(3, 32);
            lstBoxCartDescriptions.Name = "lstBoxCartDescriptions";
            lstBoxCartDescriptions.Size = new Size(237, 244);
            lstBoxCartDescriptions.TabIndex = 3;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(671, 318);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(94, 29);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Place Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(3, 318);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 1;
            btnReset.Text = "Start Over";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 0, 0);
            label1.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(260, 398);
            label1.Name = "label1";
            label1.Size = new Size(281, 50);
            label1.TabIndex = 3;
            label1.Text = "SuperFast Pizza";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "frmMain";
            Text = "SuperFast Pizza";
            tabControl1.ResumeLayout(false);
            tabPgePizza.ResumeLayout(false);
            tabPgePizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnQtyPizza).EndInit();
            tabPgeDrinks.ResumeLayout(false);
            tabPgeDrinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnDrPepper).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnMtnDew).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnCoke).EndInit();
            tabPgeOther.ResumeLayout(false);
            tabPgeOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnCookie).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnBread).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnFries).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmcUpDwnWings).EndInit();
            tabPgeCustomer.ResumeLayout(false);
            tabPgeCustomer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPgePizza;
        private TabPage tabPgeDrinks;
        private TabPage tabPgeOther;
        private TabPage tabPgeCustomer;
        private ComboBox cmbBoxSize;
        private Label lblInputSize;
        private Button btnToCartPizza;
        private Button btnReset;
        private Button btnOrder;
        private Label lblInputCrust;
        private Label label1;
        private ListBox lstBoxToppings;
        private Label lblInputQtyPizza;
        private ComboBox cmbBoxSauce;
        private Label lblInputSauce;
        private ComboBox cmbBoxCrust;
        private Label lblInputToppings;
        private NumericUpDown nmcUpDwnQtyPizza;
        private Label lblInputCoke;
        private Label label3;
        private Label label2;
        private NumericUpDown nmcUpDwnWater;
        private Label lblInputWater;
        private NumericUpDown nmcUpDwnDrPepper;
        private Label lblInputDrPepper;
        private NumericUpDown nmcUpDwnMtnDew;
        private Label lblInputMtnDew;
        private NumericUpDown nmcUpDwnCoke;
        private Button btnToCartDrinks;
        private Button btnToCartOther;
        private Label label4;
        private Label label5;
        private NumericUpDown nmcUpDwnCookie;
        private Label lblInputCookie;
        private NumericUpDown nmcUpDwnBread;
        private Label lblInputBread;
        private NumericUpDown nmcUpDwnFries;
        private Label lblInputFries;
        private NumericUpDown nmcUpDwnWings;
        private Label lblInputWings;
        private ListBox lstBoxCartDescriptions;
        private ListBox lstBoxCartPrices;
        private Label lblTotal;
        private Label lblOrderLists;
        private TextBox txtBoxEmail;
        private Label lblInputEmail;
        private TextBox txtBoxPhone;
        private Label lblInputPhone;
        private TextBox txtBoxAddress;
        private Label lblInputAddress;
        private TextBox txtBoxName;
        private Label lblInputName;
    }
}
