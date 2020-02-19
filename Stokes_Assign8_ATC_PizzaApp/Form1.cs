using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stokes_Assign8_ATC_PizzaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbSize.Text = "";
            listBoxToppings.ClearSelected();
            tbSoda.Text = "0";
            tbWater.Text = "0";
            cbOtherItems.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";

        }

        private void btPlaceOrder_Click(object sender, EventArgs e)
        {
            string size = "";
            string toppings = "";
            int toppingCount = 0;
            bool noExceptions = true;
            int water = 0;
            int soda = 0;
            string name = tbName.Text;
            string address = tbAddress.Text;
            string phone = tbPhone.Text;
            string email = tbEmail.Text;
            double drinksTotal = 0;
            double pizzaCost = 0;
            string specItem = "";
            double specItemCost = 0;
            double totalCost = 0;

            if(cbSize.SelectedIndex == 0)
            {
                size += cbSize.Text;
                pizzaCost += 9.95;
            }
            if(cbSize.SelectedIndex == 1)
            {
                size += cbSize.Text;
                pizzaCost += 12.95;
            }
            if(cbSize.SelectedIndex == 2)
            {
                size += cbSize.Text;
                pizzaCost += 15.95;
            }
            if(cbOtherItems.SelectedIndex == 0)
            {
                specItem += cbOtherItems.Text;
                specItemCost += 5.00;
            }
            if(cbOtherItems.SelectedIndex == 1)
            {
                specItem += cbOtherItems.Text;
                specItemCost += 4.00;
            }
            if(cbOtherItems.SelectedIndex == 2)
            {
                specItem += cbOtherItems.Text;
                specItemCost += 3.00;
            }

            foreach(string value in listBoxToppings.SelectedItems)
            {
                toppings += "\t" + value + "\n";
                toppingCount += 1;
            }
            pizzaCost += toppingCount * 1.50;

            try
            {
                water = int.Parse(tbWater.Text);
                soda = int.Parse(tbSoda.Text);

                if (soda < 0 || water < 0)
                {
                    noExceptions = false;
                    throw new NegativeException("App does not allow negative numbers!");
                }
                drinksTotal = (soda * 1.50);
                if(tbName.Text == "" || tbAddress.Text == "" || tbPhone.Text == "" || tbEmail.Text == "")
                {
                    noExceptions = false;
                    throw new CustomerException("Customer Info must be completed!");
                }
            }
            catch(FormatException ex)
            {
                noExceptions = false;
                MessageBox.Show(ex.Message, "Format Exception!");
            }
            catch(CustomerException ex)
            {
                noExceptions = false;
                MessageBox.Show(ex.Message, "Customer Info Error");
            }
            finally
            {
                totalCost += pizzaCost + drinksTotal + specItemCost;
                if (noExceptions)
                {

                    MessageBox.Show(size + "\n" + "Toppings ($1.50 each):\n" + toppings + "\n" +
                        "Pizza Total: $" + pizzaCost + "\n\n" +
                        "Drink Selection:\n" + soda + " soda(s)\n" + water + " water(s)\n" +
                    "Drinks total: $" + drinksTotal.ToString("F2") + "\n\n" + "Specialty Items:\n" +
                    specItem + "\n\n" + "Amount Due: $" + totalCost + "\n\n" +
                    "Deliver to: " + name + ", " + address, "ATC Pizza Order");
                }
            }
            
        }


    }
}
