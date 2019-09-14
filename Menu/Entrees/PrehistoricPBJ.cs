using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represnt Prehistoric pbj menu item
    /// </summary>
    public class PrehistoricPBJ
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// Price, Calorie and Ingredients properties for objects of this class
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
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
    }
}
