using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    class Pizza
    {
        string btnSauce;
        string btnCheeze;
        bool[] toppings=new bool[11];
        static string[] topppingNames = {"Pepperoni","Bacon","Ham","Mushrooms","Pineapple","Tomato","Green Peppers","Onion","Spinach","Olives, Black","Olives, Green"};
        string instructions;
        private int addedIndex;
        public Pizza(int index)
        {
            btnSauce = "None";
            btnCheeze = "None";
            for(int i=0;i<11;i++){
                toppings[i]=false;
            }
            instructions = "N/A";
            addedIndex = index;
        }
        public string GetInfo(string toppings)
        {
            string toppingString = "";
            for(int i=0;i<11;i++){
                if(topping[i]){
                    toppingString+=toppingNames[i];
                }
            }
            return $"Pizza #{addedIndex}:\nToppings:   {btnSauce}\n   {toppingString}\n   {btnCheeze}\nInstructions:{instructions}";
        }
    }
}
