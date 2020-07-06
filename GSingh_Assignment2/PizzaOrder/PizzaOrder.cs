/*
 * File Name: PizzaOrder.cs
 * Assignment2 for PROG1815-20S-Sec2-Programming Concepts II
 * 
 * Revision History
 *      Garima Singh, 2020-07-05 : Created
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class PizzaOrder : Form
    {
        RadioButton selectedPizza = null;
        public PizzaOrder()
        {
            InitializeComponent();
            lblForButtons.Enabled = false;
            txtBoxCount.Enabled = true;
            txtSpecialInstructions.Enabled = false;
            pnlCheckOut.Enabled = false;
            lblForButtons.Enabled = false;
            grpSauce.Enabled = false;
            grpToppings.Enabled = false;
            grpCheese.Enabled = false;
            btnCheckOut.Enabled = false;
            lblSpecialInstructions.Enabled = false;
            btnStartNewOrder.Enabled = false;
            pnlOrder.Visible = false;
        }

        Pizza[] myPizza = new Pizza[9];
        string toppings;
        string sauce = "";
        string cheese = "";
        string currentPizzaIndex=0;
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblForButtons.Enabled = true;
            txtBoxCount.Enabled = false;
            txtSpecialInstructions.Enabled = true;
            pnlCheckOut.Enabled = true;
            lblForButtons.Enabled = true;
            grpSauce.Enabled = true;
            grpToppings.Enabled = true;
            grpCheese.Enabled = true;
            btnCheckOut.Enabled = true;
            lblSpecialInstructions.Enabled = true;
            btnStartNewOrder.Enabled = true;
            pnlOrder.Visible = false;
            if (int.TryParse(txtBoxCount.Text, out int totalNumberOfPizzas))
            {
                if (totalNumberOfPizzas >= 1 && totalNumberOfPizzas <= 9)
                {
                    int locationRow = 30;
                    int nameForRadioButton = 0;

                    for (int i = 0; i < totalNumberOfPizzas; i++)
                    {
                        RadioButton box = new RadioButton();
                        box.Name = nameForRadioButton.ToString();
                        nameForRadioButton++;

                        box.Appearance = Appearance.Button;
                        box.Width = 130;
                        box.Height = 130;
                        box.Location = new Point(locationRow, locationRow * (i + 1));

                        box.Tag = i+1;
                        Pizza pizza = new Pizza(i+1);
                        
                        lblForButtons.Controls.Add(box);
                        myPizza[i] = pizza;

                        box.Click += new EventHandler(DynamicRadioBox_Click);
                    }
                }
                    lblForButtons.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You cannot enter more than 9 pizza pies at a time!");
                    Environment.Exit(1);
                }
        }

        private void DynamicRadioBox_Click(object sender, EventArgs e)
        {
            selectedPizza = (RadioButton)sender;
            currentPizzaIndex = selectedPizza.Tag;
            selectedPizza.Click += new EventHandler(btnToppings_Click);
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            if (rdbSauceNone.Checked == true)
            {
                myPizza[currentPizzaIndex].sauce = "None";
            }
            else if (rdbSauceLight.Checked == true)
            {
                myPizza[currentPizzaIndex].sauce = "Light";
            }
            else if (rdbSauceNormal.Checked == true)
            {
                myPizza[currentPizzaIndex].sauce = "Normal";
            }
            else if (rdbSauceHeavy.Checked == true)
            {
                myPizza[currentPizzaIndex].sauce = "Heavy";
            }
            else
            {
                myPizza[currentPizzaIndex].sauce = "None";
            }


            if (rdbCheeseNone.Checked == true)
            {
                myPizza[currentPizzaIndex].cheese = "None";
            }
            else if (rdbCheeseLight.Checked == true)
            {
                myPizza[currentPizzaIndex].cheese = "Light";
            }
            else if (rdbCheeseNormal.Checked == true)
            {
                myPizza[currentPizzaIndex].cheese = "Normal";
            }
            else if (rdbCheeseHeavy.Checked == true)
            {
                myPizza[currentPizzaIndex].cheese = "Heavy";
            }
            else
            {
                myPizza[currentPizzaIndex].cheese = "None";
            }

            int j;

            if (chk0.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[0] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[0] = false;
            }

            if (chk1.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[1] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[1] = false;
            }

            if (chk2.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[2] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[2] = false;
            }

            if (chk3.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[3] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[3] = false;
            }

            if (chk4.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[4] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[4] = false;
            }

            if (chk5.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[5] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[5] = false;
            }

            if (chk6.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[6] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[6] = false;
            }

            if (chk7.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[7] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[7] = false;
            }

            if (chk8.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[8] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[8] = false;
            }

            if (chk9.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[9] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[9] = false;
            }

            if (chk10.Checked == true)
            {
                myPizza[currentPizzaIndex].toppings[10] = true;
            }
            else
            {
                myPizza[currentPizzaIndex].toppings[10] = false;
            }
        }

            private void btnStartNewOrder_Click(object sender, EventArgs e)
        {
            txtSpecialInstructions.Clear();
            txtBoxCount.Clear();
            txtBoxCount.Enabled = true;
            txtSpecialInstructions.Enabled = false;
            pnlCheckOut.Enabled = false;
            lblForButtons.Enabled = false;
            grpSauce.Enabled = false;
            grpToppings.Enabled = false;
            grpCheese.Enabled = false;
            btnCheckOut.Enabled = false;
            lblSpecialInstructions.Enabled = false;
            btnStartNewOrder.Enabled = false;
            pnlOrder.Visible = false;
            pnlTotalOrder.Text = "";
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            Button box = (Button)sender;
            Pizza pizza = myPizza[currentPizzaIndex];
            pnlOrder.Visible = true;
            for(int i = 0; i < 11; i++)
            {
                toppings += pizza.toppings[i] + Environment.NewLine;
            }
            pnlTotalOrder.Text = pizza.GetInfo(toppings);
        }
    }
}
