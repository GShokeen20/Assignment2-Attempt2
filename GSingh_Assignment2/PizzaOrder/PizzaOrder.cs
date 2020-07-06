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
        string[] toppingsList = new string[11]{"","","","","","","","","","",""};
        string toppings;
        string sauce = "";
        string cheese = "";
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
            //pizza = (Pizza)selectedPizza.Tag;
            selectedPizza.Click += new EventHandler(btnToppings_Click);
        }

        private void btnToppings_Click(object sender, EventArgs e)
        {
            if (rdbSauceNone.Checked == true)
            {
                sauce = "None";
            }
            else if (rdbSauceLight.Checked == true)
            {
                sauce = "Light";
            }
            else if (rdbSauceNormal.Checked == true)
            {
                sauce = "Normal";
            }
            else if (rdbSauceHeavy.Checked == true)
            {
                sauce = "Heavy";
            }
            else
            {
                sauce = "None";
            }


            if (rdbCheeseNone.Checked == true)
            {
                cheese = "None";
            }
            else if (rdbCheeseLight.Checked == true)
            {
                cheese = "Light";
            }
            else if (rdbCheeseNormal.Checked == true)
            {
                cheese = "Normal";
            }
            else if (rdbCheeseHeavy.Checked == true)
            {
                cheese = "Heavy";
            }
            else
            {
                cheese = "None";
            }

            int j;

            if (chk0.Checked == true)
            {
                toppingsList[0] = "Pepperoni";
            }
            else
            {
                toppingsList[0] = "";
            }

            if (chk1.Checked == true)
            {
                toppingsList[1] = "Bacon";
            }
            else
            {
                toppingsList[1] = "";
            }

            if (chk2.Checked == true)
            {
                toppingsList[2] = "Ham";
            }
            else
            {
                toppingsList[2] = "";
            }

            if (chk3.Checked == true)
            {
                toppingsList[3] = "Mushrooms";
            }
            else
            {
                toppingsList[3] = "";
            }

            if (chk4.Checked == true)
            {
                toppingsList[4] = "Pineapple";
            }
            else
            {
                toppingsList[4] = "";
            }

            if (chk5.Checked == true)
            {
                toppingsList[5] = "Tomato";
            }
            else
            {
                toppingsList[5] = "";
            }

            if (chk6.Checked == true)
            {
                toppingsList[6] = "Green Peppers";
            }
            else
            {
                toppingsList[6] = "";
            }

            if (chk7.Checked == true)
            {
                toppingsList[7] = "Onion";
            }
            else
            {
                toppingsList[7] = "";
            }

            if (chk8.Checked == true)
            {
                toppingsList[8] = "Spinach";
            }
            else
            {
                toppingsList[8] = "";
            }

            if (chk9.Checked == true)
            {
                toppingsList[9] = "Olives, Black";
            }
            else
            {
                toppingsList[9] = "";
            }

            if (chk10.Checked == true)
            {
                toppingsList[10] = "Olives, Green";
            }
            else
            {
                toppingsList[10] = "";
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
            Pizza pizza = (Pizza)box.Tag;
            pnlOrder.Visible = true;
            for(int i = 0; i < 11; i++)
            {
                toppings += toppingsList[i] + Environment.NewLine;
            }
            pnlTotalOrder.Text = pizza.GetInfo(toppings);
        }
    }
}