/* Author: Curtis Flaming
 * Class: Water
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class to represent water drink
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// has lemon or now
        /// </summary>
        public bool Lemon = false;
        /// <summary>
        /// water size
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
                NotifyOfPropertyChanged("Size");
            }
        }

        /// <summary>
        /// water ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
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
                if (!Ice) special.Add("Hold Ice");
                if (Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
        /// <summary>
        /// constructor sets default price and calories
        /// </summary>
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
        }
        /// <summary>
        /// method add lemons
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
        }
    }
}
