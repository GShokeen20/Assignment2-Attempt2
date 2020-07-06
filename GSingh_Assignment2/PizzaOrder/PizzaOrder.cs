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
        CheckBox selectedToppings = null;
        RadioButton selectedCheeze = null;
        RadioButton selectedSauce = null;
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
        string instructions = "N/A";
        int currentPizzaIndex = 0;
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
            RadioButton box = (RadioButton)sender;
            Pizza pizza = (Pizza)box.Tag;
            //selectedPizza = (RadioButton)sender;
            //currentPizzaIndex = int.Parse(selectedPizza.Tag);
            //if (selectedPizza != null)
            //{
                box.Click += new EventHandler(btnToppings_CheckedChanged);
            //}
        }

        private void btnToppings_CheckedChanged(object sender, EventArgs e)
        {
            selectedToppings = (CheckBox)sender;
            
            int j;

            if (selectedToppings != null)
            {
                if (chk0.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[0] = true;
                }

                if (chk1.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[1] = true;
                }

                if (chk2.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[2] = true;
                }

                if (chk3.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[3] = true;
                }

                if (chk4.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[4] = true;
                }

                if (chk5.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[5] = true;
                }

                if (chk6.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[6] = true;
                }

                if (chk7.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[7] = true;
                }

                if (chk8.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[8] = true;
                }

                if (chk9.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[9] = true;
                }

                if (chk10.Checked == true)
                {
                    myPizza[currentPizzaIndex].topping[10] = true;
                }
            }
        }

        private void btnCheeze_Click(object sender, EventArgs e)
        {
            selectedCheeze = (RadioButton)sender;

            if (rdbCheeseNone.Checked == true)
            {
                myPizza[currentPizzaIndex].btnCheeze = "None";
            }
            else if (rdbCheeseLight.Checked == true)
            {
                myPizza[currentPizzaIndex].btnCheeze = "Light";
            }
            else if (rdbCheeseNormal.Checked == true)
            {
                myPizza[currentPizzaIndex].btnCheeze = "Normal";
            }
            else if (rdbCheeseHeavy.Checked == true)
            {
                myPizza[currentPizzaIndex].btnCheeze = "Heavy";
            }
            else
            {
                myPizza[currentPizzaIndex].btnCheeze = "None";
            }
        }

        private void btnSauce_Click(object sender, EventArgs e)
        {
            selectedSauce = (RadioButton)sender;
            if (rdbSauceNone.Checked == true)
            {
                myPizza[currentPizzaIndex].btnSauce = "None";
            }
            else if (rdbSauceLight.Checked == true)
            {
                myPizza[currentPizzaIndex].btnSauce = "Light";
            }
            else if (rdbSauceNormal.Checked == true)
            {
                myPizza[currentPizzaIndex].btnSauce = "Normal";
            }
            else if (rdbSauceHeavy.Checked == true)
            {
                myPizza[currentPizzaIndex].btnSauce = "Heavy";
            }
            else
            {
                myPizza[currentPizzaIndex].btnSauce = "None";
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
            for (int i = 0; i < 11; i++)
            {
                toppings += pizza.topping[i] + Environment.NewLine;
            }
            pnlTotalOrder.Text = pizza.GetInfo(toppings);
        }
    }
}
