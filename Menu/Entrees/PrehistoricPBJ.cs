/* Author: Curtis Flaming
 * Class: PrehistoricPBJ
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represnt Prehistoric pbj menu item
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Methods do withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        public void HoldJelly()
        {
            this.jelly = false;
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
               return "Prehistoric PB&J";
        }
    }
}
