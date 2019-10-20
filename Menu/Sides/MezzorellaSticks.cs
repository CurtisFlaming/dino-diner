/* Author: Curtis Flaming
 * Class: MezzorellaSticks
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class to represent Mezzorella Sticks
    /// </summary>
    public class MezzorellaSticks : Side
    {
        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Breading", "Cheese Product", "Vegetable Oil"};
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
        /// Size of side order
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
                        Calories = 720;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 540;
                        break;
                }
                NotifyChanges();
            }
        }

        public MezzorellaSticks()
        {
            this.Size = Size.Small;
        }

    }
}
