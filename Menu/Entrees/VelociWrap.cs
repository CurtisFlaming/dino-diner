
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent VelociWrap menu item
    /// </summary>
    public class VelociWrap
    {
        //Implement a class to represent the Veloci-Wrap entree.
        //Its price is **$6.86**, it contains **356 calories**, and 
        //its ingredients are: a** flour tortilla, chicken breast, romaine lettuce, Ceasar dressing**, and** parmesan cheese**.  
        //It should implement methods to hold the** dressing, lettuce**

        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool dressing = true;
        private bool lettuce = true;
        private bool cheese = true;
        /// <summary>
        /// Price, Calorie and Ingredients properties for objects of this class
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast"};
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Methods do withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
