using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent Brontowurst menu item
    /// </summary>
    public class Brontowurst
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// Price, Calorie and Ingredients properties for objects of this class
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// Methods do withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
