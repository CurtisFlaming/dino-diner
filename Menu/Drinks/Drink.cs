using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// Class to represent drink base class
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// drink has ice
        /// </summary>
        public bool Ice = true;
        /// <summary>
        /// drink price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// drink calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// drink size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// drink ingredients
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// method to remove ice
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
        }
    }
}
