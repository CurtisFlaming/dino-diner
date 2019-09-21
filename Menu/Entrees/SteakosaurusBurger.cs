using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent Seakosaurus Burger menu item
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        
        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Methods do withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
