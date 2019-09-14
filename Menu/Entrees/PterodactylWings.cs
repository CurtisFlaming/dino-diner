using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent Pterodactyl Wings menu item
    /// </summary>
    public class PterodactylWings
    {
        /// <summary>
        /// Price, Calorie and Ingredients properties for objects of this class
        /// </summary>
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
