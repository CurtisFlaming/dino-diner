/* Author: Curtis Flaming
 * Class: MeteorMacAndCheese
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Meteor mac and cheese side order
    /// </summary>
    public class MeteorMacAndCheese : Side
    {
        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
                return ingredients;
            }
        }

        /// <summary>
        /// Size of entree
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
                        Calories = 520;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 420;
                        break;
                }
                NotifyChanges();
            }
        }

        public override string[] Special
        {
            get
            {
                return new string[0];
            }
        }

        public MeteorMacAndCheese()
        {
            this.Size = Size.Small;
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Size} Meteor Mac and Cheese";
        }

    }
}
