/* Author: Curtis Flaming
 * Class: VelociWrap
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent VelociWrap menu item
    /// </summary>
    public class VelociWrap : Entree
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
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// item special attributes
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!lettuce) special.Add("Hold Romaine Lettuce");
                if (!dressing) special.Add("Hold Ceasar Dressing");
                if (!cheese) special.Add("Hold Parmesan Cheese");
                return special.ToArray();
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
        /// Methods to withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
            NotifyChanges();
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyChanges();
        }
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyChanges();
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
