namespace PizzaOrder
{
    partial class PizzaOrder
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
            this.lblNumberOfPizzas = new System.Windows.Forms.Label();
            this.txtBoxCount = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpSauce = new System.Windows.Forms.GroupBox();
            this.rdbSauceHeavy = new System.Windows.Forms.RadioButton();
            this.rdbSauceNormal = new System.Windows.Forms.RadioButton();
            this.rdbSauceLight = new System.Windows.Forms.RadioButton();
            this.rdbSauceNone = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.grpCheese = new System.Windows.Forms.GroupBox();
            this.rdbCheeseHeavy = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNormal = new System.Windows.Forms.RadioButton();
            this.rdbCheeseLight = new System.Windows.Forms.RadioButton();
            this.rdbCheeseNone = new System.Windows.Forms.RadioButton();
            this.lblSpecialInstructions = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlTotalOrder = new System.Windows.Forms.Panel();
            this.btnStartNewOrder = new System.Windows.Forms.Button();
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.pnlCheckOut = new System.Windows.Forms.Panel();
            this.pnlStartOrder = new System.Windows.Forms.Panel();
            this.lblForButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSpecialInstructions = new System.Windows.Forms.TextBox();
            this.grpSauce.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCheese.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfPizzas
            // 
            this.lblNumberOfPizzas.AutoSize = true;
            this.lblNumberOfPizzas.Location = new System.Drawing.Point(27, 31);
            this.lblNumberOfPizzas.Name = "lblNumberOfPizzas";
            this.lblNumberOfPizzas.Size = new System.Drawing.Size(125, 17);
            this.lblNumberOfPizzas.TabIndex = 1;
            this.lblNumberOfPizzas.Text = "How many pizzas?";
            // 
            // txtBoxCount
            // 
            this.txtBoxCount.Location = new System.Drawing.Point(158, 31);
            this.txtBoxCount.Name = "txtBoxCount";
            this.txtBoxCount.Size = new System.Drawing.Size(34, 22);
            this.txtBoxCount.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(76, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Order";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpSauce
            // 
            this.grpSauce.Controls.Add(this.rdbSauceHeavy);
            this.grpSauce.Controls.Add(this.rdbSauceNormal);
            this.grpSauce.Controls.Add(this.rdbSauceLight);
            this.grpSauce.Controls.Add(this.rdbSauceNone);
            this.grpSauce.Location = new System.Drawing.Point(250, 31);
            this.grpSauce.Name = "grpSauce";
            this.grpSauce.Size = new System.Drawing.Size(361, 86);
            this.grpSauce.TabIndex = 6;
            this.grpSauce.TabStop = false;
            this.grpSauce.Text = "Sauce";
            // 
            // rdbSauceHeavy
            // 
            this.rdbSauceHeavy.AutoSize = true;
            this.rdbSauceHeavy.Location = new System.Drawing.Point(280, 33);
            this.rdbSauceHeavy.Name = "rdbSauceHeavy";
            this.rdbSauceHeavy.Size = new System.Drawing.Size(69, 21);
            this.rdbSauceHeavy.TabIndex = 3;
            this.rdbSauceHeavy.TabStop = true;
            this.rdbSauceHeavy.Text = "Heavy";
            this.rdbSauceHeavy.UseVisualStyleBackColor = true;
            // 
            // rdbSauceNormal
            // 
            this.rdbSauceNormal.AutoSize = true;
            this.rdbSauceNormal.Location = new System.Drawing.Point(183, 34);
            this.rdbSauceNormal.Name = "rdbSauceNormal";
            this.rdbSauceNormal.Size = new System.Drawing.Size(74, 21);
            this.rdbSauceNormal.TabIndex = 2;
            this.rdbSauceNormal.TabStop = true;
            this.rdbSauceNormal.Text = "Normal";
            this.rdbSauceNormal.UseVisualStyleBackColor = true;
            // 
            // rdbSauceLight
            // 
            this.rdbSauceLight.AutoSize = true;
            this.rdbSauceLight.Location = new System.Drawing.Point(95, 33);
            this.rdbSauceLight.Name = "rdbSauceLight";
            this.rdbSauceLight.Size = new System.Drawing.Size(60, 21);
            this.rdbSauceLight.TabIndex = 1;
            this.rdbSauceLight.TabStop = true;
            this.rdbSauceLight.Text = "Light";
            this.rdbSauceLight.UseVisualStyleBackColor = true;
            // 
            // rdbSauceNone
            // 
            this.rdbSauceNone.AutoSize = true;
            this.rdbSauceNone.Location = new System.Drawing.Point(16, 34);
            this.rdbSauceNone.Name = "rdbSauceNone";
            this.rdbSauceNone.Size = new System.Drawing.Size(63, 21);
            this.rdbSauceNone.TabIndex = 0;
            this.rdbSauceNone.TabStop = true;
            this.rdbSauceNone.Text = "None";
            this.rdbSauceNone.UseVisualStyleBackColor = true;
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chk10);
            this.grpToppings.Controls.Add(this.chk9);
            this.grpToppings.Controls.Add(this.chk8);
            this.grpToppings.Controls.Add(this.chk7);
            this.grpToppings.Controls.Add(this.chk6);
            this.grpToppings.Controls.Add(this.chk5);
            this.grpToppings.Controls.Add(this.chk4);
            this.grpToppings.Controls.Add(this.chk3);
            this.grpToppings.Controls.Add(this.chk2);
            this.grpToppings.Controls.Add(this.chk1);
            this.grpToppings.Controls.Add(this.chk0);
            this.grpToppings.Location = new System.Drawing.Point(250, 124);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(361, 157);
            this.grpToppings.TabIndex = 7;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(141, 112);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(117, 21);
            this.chk10.TabIndex = 8;
            this.chk10.Text = "Olives, Green";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(16, 112);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(111, 21);
            this.chk9.TabIndex = 8;
            this.chk9.Text = "Olives, Black";
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(242, 85);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(81, 21);
            this.chk8.TabIndex = 8;
            this.chk8.Text = "Spinach";
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(141, 85);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(68, 21);
            this.chk7.TabIndex = 11;
            this.chk7.Text = "Onion";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(16, 85);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(127, 21);
            this.chk6.TabIndex = 10;
            this.chk6.Text = "Green Peppers";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(242, 58);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(78, 21);
            this.chk5.TabIndex = 9;
            this.chk5.Text = "Tomato";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(141, 58);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(93, 21);
            this.chk4.TabIndex = 8;
            this.chk4.Text = "Pineapple";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(16, 58);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(103, 21);
            this.chk3.TabIndex = 3;
            this.chk3.Text = "Mushrooms";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(242, 31);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(59, 21);
            this.chk2.TabIndex = 2;
            this.chk2.Text = "Ham";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(141, 31);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(70, 21);
            this.chk1.TabIndex = 1;
            this.chk1.Text = "Bacon";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(16, 31);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(95, 21);
            this.chk0.TabIndex = 0;
            this.chk0.Text = "Pepperoni";
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // grpCheese
            // 
            this.grpCheese.Controls.Add(this.rdbCheeseHeavy);
            this.grpCheese.Controls.Add(this.rdbCheeseNormal);
            this.grpCheese.Controls.Add(this.rdbCheeseLight);
            this.grpCheese.Controls.Add(this.rdbCheeseNone);
            this.grpCheese.Location = new System.Drawing.Point(250, 297);
            this.grpCheese.Name = "grpCheese";
            this.grpCheese.Size = new System.Drawing.Size(361, 86);
            this.grpCheese.TabIndex = 7;
            this.grpCheese.TabStop = false;
            this.grpCheese.Text = "Cheese";
            // 
            // rdbCheeseHeavy
            // 
            this.rdbCheeseHeavy.AutoSize = true;
            this.rdbCheeseHeavy.Location = new System.Drawing.Point(280, 33);
            this.rdbCheeseHeavy.Name = "rdbCheeseHeavy";
            this.rdbCheeseHeavy.Size = new System.Drawing.Size(69, 21);
            this.rdbCheeseHeavy.TabIndex = 3;
            this.rdbCheeseHeavy.TabStop = true;
            this.rdbCheeseHeavy.Text = "Heavy";
            this.rdbCheeseHeavy.UseVisualStyleBackColor = true;
            // 
            // rdbCheeseNormal
            // 
            this.rdbCheeseNormal.AutoSize = true;
            this.rdbCheeseNormal.Location = new System.Drawing.Point(183, 34);
            this.rdbCheeseNormal.Name = "rdbCheeseNormal";
            this.rdbCheeseNormal.Size = new System.Drawing.Size(74, 21);
            this.rdbCheeseNormal.TabIndex = 2;
            this.rdbCheeseNormal.TabStop = true;
            this.rdbCheeseNormal.Text = "Normal";
            this.rdbCheeseNormal.UseVisualStyleBackColor = true;
            // 
            // rdbCheeseLight
            // 
            this.rdbCheeseLight.AutoSize = true;
            this.rdbCheeseLight.Location = new System.Drawing.Point(95, 33);
            this.rdbCheeseLight.Name = "rdbCheeseLight";
            this.rdbCheeseLight.Size = new System.Drawing.Size(60, 21);
            this.rdbCheeseLight.TabIndex = 1;
            this.rdbCheeseLight.TabStop = true;
            this.rdbCheeseLight.Text = "Light";
            this.rdbCheeseLight.UseVisualStyleBackColor = true;
            // 
            // rdbCheeseNone
            // 
            this.rdbCheeseNone.AutoSize = true;
            this.rdbCheeseNone.Location = new System.Drawing.Point(16, 34);
            this.rdbCheeseNone.Name = "rdbCheeseNone";
            this.rdbCheeseNone.Size = new System.Drawing.Size(63, 21);
            this.rdbCheeseNone.TabIndex = 0;
            this.rdbCheeseNone.TabStop = true;
            this.rdbCheeseNone.Text = "None";
            this.rdbCheeseNone.UseVisualStyleBackColor = true;
            // 
            // lblSpecialInstructions
            // 
            this.lblSpecialInstructions.AutoSize = true;
            this.lblSpecialInstructions.Location = new System.Drawing.Point(263, 392);
            this.lblSpecialInstructions.Name = "lblSpecialInstructions";
            this.lblSpecialInstructions.Size = new System.Drawing.Size(130, 17);
            this.lblSpecialInstructions.TabIndex = 9;
            this.lblSpecialInstructions.Text = "Special Instructions";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Red;
            this.btnCheckOut.Location = new System.Drawing.Point(250, 532);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(361, 40);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.pnlTotalOrder);
            this.pnlOrder.Controls.Add(this.btnStartNewOrder);
            this.pnlOrder.Controls.Add(this.lblOrderSummary);
            this.pnlOrder.Location = new System.Drawing.Point(636, 9);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(368, 578);
            this.pnlOrder.TabIndex = 11;
            // 
            // pnlTotalOrder
            // 
            this.pnlTotalOrder.Location = new System.Drawing.Point(23, 78);
            this.pnlTotalOrder.Name = "pnlTotalOrder";
            this.pnlTotalOrder.Size = new System.Drawing.Size(322, 425);
            this.pnlTotalOrder.TabIndex = 15;
            // 
            // btnStartNewOrder
            // 
            this.btnStartNewOrder.BackColor = System.Drawing.Color.LawnGreen;
            this.btnStartNewOrder.Location = new System.Drawing.Point(23, 523);
            this.btnStartNewOrder.Name = "btnStartNewOrder";
            this.btnStartNewOrder.Size = new System.Drawing.Size(322, 40);
            this.btnStartNewOrder.TabIndex = 14;
            this.btnStartNewOrder.Text = "Start New Order";
            this.btnStartNewOrder.UseVisualStyleBackColor = false;
            this.btnStartNewOrder.Click += new System.EventHandler(this.btnStartNewOrder_Click);
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.Location = new System.Drawing.Point(18, 33);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(164, 25);
            this.lblOrderSummary.TabIndex = 0;
            this.lblOrderSummary.Text = "Order Summary";
            // 
            // pnlCheckOut
            // 
            this.pnlCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckOut.Location = new System.Drawing.Point(228, 9);
            this.pnlCheckOut.Name = "pnlCheckOut";
            this.pnlCheckOut.Size = new System.Drawing.Size(402, 578);
            this.pnlCheckOut.TabIndex = 12;
            // 
            // pnlStartOrder
            // 
            this.pnlStartOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStartOrder.Location = new System.Drawing.Point(13, 9);
            this.pnlStartOrder.Name = "pnlStartOrder";
            this.pnlStartOrder.Size = new System.Drawing.Size(209, 88);
            this.pnlStartOrder.TabIndex = 13;
            // 
            // lblForButtons
            // 
            this.lblForButtons.AutoScroll = true;
            this.lblForButtons.AutoScrollMinSize = new System.Drawing.Size(10, 480);
            this.lblForButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblForButtons.Location = new System.Drawing.Point(13, 103);
            this.lblForButtons.Name = "lblForButtons";
            this.lblForButtons.Size = new System.Drawing.Size(209, 484);
            this.lblForButtons.TabIndex = 14;
            // 
            // txtSpecialInstructions
            // 
            this.txtSpecialInstructions.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSpecialInstructions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecialInstructions.Location = new System.Drawing.Point(250, 412);
            this.txtSpecialInstructions.Multiline = true;
            this.txtSpecialInstructions.Name = "txtSpecialInstructions";
            this.txtSpecialInstructions.Size = new System.Drawing.Size(361, 100);
            this.txtSpecialInstructions.TabIndex = 8;
            // 
            // PizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 599);
            this.Controls.Add(this.lblForButtons);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.lblSpecialInstructions);
            this.Controls.Add(this.txtSpecialInstructions);
            this.Controls.Add(this.grpCheese);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSauce);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtBoxCount);
            this.Controls.Add(this.lblNumberOfPizzas);
            this.Controls.Add(this.pnlCheckOut);
            this.Controls.Add(this.pnlStartOrder);
            this.Name = "PizzaOrder";
            this.Text = "Pizza Order";
            this.grpSauce.ResumeLayout(false);
            this.grpSauce.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCheese.ResumeLayout(false);
            this.grpCheese.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNumberOfPizzas;
        private System.Windows.Forms.TextBox txtBoxCount;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpSauce;
        private System.Windows.Forms.RadioButton rdbSauceNone;
        private System.Windows.Forms.RadioButton rdbSauceNormal;
        private System.Windows.Forms.RadioButton rdbSauceLight;
        private System.Windows.Forms.RadioButton rdbSauceHeavy;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.GroupBox grpCheese;
        private System.Windows.Forms.RadioButton rdbCheeseHeavy;
        private System.Windows.Forms.RadioButton rdbCheeseNormal;
        private System.Windows.Forms.RadioButton rdbCheeseLight;
        private System.Windows.Forms.RadioButton rdbCheeseNone;
        private System.Windows.Forms.Label lblSpecialInstructions;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlCheckOut;
        private System.Windows.Forms.Panel pnlStartOrder;
        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Button btnStartNewOrder;
        private System.Windows.Forms.FlowLayoutPanel lblForButtons;
        private System.Windows.Forms.TextBox txtSpecialInstructions;
        private System.Windows.Forms.Panel pnlTotalOrder;
    }
}

