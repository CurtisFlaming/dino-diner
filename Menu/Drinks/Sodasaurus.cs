/* Author: Curtis Flaming
 * Class: Sodasourus
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class to represent tea
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// flavor of tea
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }
        /// <summary>
        /// size of tea
        /// </summary>
        private Size size;
        public override Size Size {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        this.Price = 1.50;
                        this.Calories = 112;
                        NotifyChanges();
                        break;
                    case (Size.Medium):
                        this.Price = 2.00;
                        this.Calories = 156;
                        NotifyChanges();
                        break;
                    case (Size.Large):
                        this.Price = 2.50;
                        this.Calories = 208;
                        NotifyChanges();
                        break;
                }
            }
        }
        /// <summary>
        /// tea ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            }
        }
        /// <summary>
        /// constructor sets default size to small
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Size + " " + Flavor + " Sodasaurus";
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
                return special.ToArray();
            }
        }
    }
}
