/* Author: Curtis Flaming
 * Class: Triceritots
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent Triceritots
    /// </summary>
    public class Triceritots : Side
    {
        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil"};
                return ingredients;
            }
        }
        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }
        /// <summary>
        /// size of side order
        /// </summary>
        private Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 352;
                        break;
                }
                NotifyChanges();
            }
        }

        public Triceritots()
        {
            this.Size = Size.Small;
        }

    }
}
