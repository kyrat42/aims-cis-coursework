using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Pizza_Delivery_App_2
{
    public partial class frmMain : Form
    {
        public double[] sizePrices = new double[3];
        public string[] cartDescriptions = new string[20];
        public double[] cartPrices = new double[20];

        public int cartIndex = 0;
        public double orderTotalPrice = 0.0;

        public frmMain()
        {
            sizePrices[0] = 8.99;
            sizePrices[1] = 12.99;
            sizePrices[2] = 15.99;

            InitializeComponent();
        }

        public void updateOrder(string description, double price)
        {
            cartDescriptions[cartIndex] = description;
            cartPrices[cartIndex] = price;
            cartIndex++;

            // add to order summary
            lstBoxCartDescriptions.Items.Add(description);
            lstBoxCartPrices.Items.Add(String.Format("{0:c}", price));
            orderTotalPrice += price;
            lblTotal.Text = String.Format("Total: {0:c}", orderTotalPrice);
        }

        public void resetPizza()
        {
            cmbBoxSize.SelectedIndex = -1;
            cmbBoxCrust.SelectedIndex = -1;
            cmbBoxSauce.SelectedIndex = -1;
            lstBoxToppings.SelectedItems.Clear();
            nmcUpDwnQtyPizza.Value = 1;
        }

        public void resetDrinks()
        {
            nmcUpDwnCoke.Value = 0;
            nmcUpDwnMtnDew.Value = 0;
            nmcUpDwnDrPepper.Value = 0;
            nmcUpDwnWater.Value = 0;
        }

        public void resetOther()
        {
            nmcUpDwnWings.Value = 0;
            nmcUpDwnFries.Value = 0;
            nmcUpDwnBread.Value = 0;
            nmcUpDwnCookie.Value = 0;
        }

        private void btnToCartPizza_Click(object sender, EventArgs e)
        {
            double price = 0;
            string description;
            int qty;

            // make sure cart isn't full
            if (cartIndex > 20)
            {
                MessageBox.Show("Your cart is full.");
            }

            // make sure all required values selected
            else if (cmbBoxSize.SelectedText == null || cmbBoxCrust.SelectedText == null || cmbBoxSauce.SelectedText == null)
            {
                MessageBox.Show("Please fill out all required values.");
            }

            else
            {
                qty = (int)nmcUpDwnQtyPizza.Value;

                for (int i = 0; i < qty; i++)
                {
                    // base price is based on size
                    price += sizePrices[cmbBoxSize.SelectedIndex];

                    // add the price of each topping
                    foreach (string topping in lstBoxToppings.SelectedItems)
                    {
                        price += 0.5;
                    }
                }

                description = qty.ToString() + " custom pizza(s)";

                updateOrder(description, price);
                resetPizza();
            }
        }

        private void btnToCartDrinks_Click(object sender, EventArgs e)
        {
            double price = 0;
            string description;
            int qty = 0;

            // get the total number of drinks
            qty += (int)nmcUpDwnCoke.Value;
            qty += (int)nmcUpDwnMtnDew.Value;
            qty += (int)nmcUpDwnDrPepper.Value;
            qty += (int)nmcUpDwnWater.Value;

            description = qty.ToString() + " cold drink(s)";
            price = qty * 1.5;

            updateOrder(description, price);
            resetDrinks();
        }

        private void btnToCartOther_Click(object sender, EventArgs e)
        {
            double price = 0;
            string description;
            int qty = 0;

            // get the total number of items
            qty += (int)nmcUpDwnWings.Value;
            qty += (int)nmcUpDwnFries.Value;
            qty += (int)nmcUpDwnBread.Value;
            qty += (int)nmcUpDwnCookie.Value;

            description = qty.ToString() + " sides/desserts";
            price = qty * 6.99;

            updateOrder(description, price);
            resetOther();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // validate
            if (orderTotalPrice == 0)
            {
                MessageBox.Show("You haven't added anything to your cart yet.");
            }
            else if (txtBoxName.Text == "" || txtBoxAddress.Text == "" || txtBoxPhone.Text == "" || txtBoxEmail.Text == "")
            {
                MessageBox.Show("Please fill out all required fields.");
            }

            else
            {
                MessageBox.Show(String.Format("Your total is: {0:c}\n\nDelivering to: {1}\n{2}", orderTotalPrice, txtBoxName.Text, txtBoxAddress.Text));
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetPizza();
            resetDrinks();
            resetOther();

            for (int i = 0; i < 20; i++)
            {
                cartDescriptions[i] = null;
                cartPrices[i] = 0;
            }

            cartIndex = 0;
            orderTotalPrice = 0.0;
            lblTotal.Text = "Total: ";

            lstBoxCartDescriptions.Items.Clear();
            lstBoxCartPrices.Items.Clear();
        }
    }
}
