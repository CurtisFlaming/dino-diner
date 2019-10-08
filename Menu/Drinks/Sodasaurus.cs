﻿/* Author: Curtis Flaming
 * Class: Sodasaurus
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class to represent soda
    /// </summary>
    public class Sodasaurus : Drink
    {
        /// <summary>
        /// flavor of soda
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }
        /// <summary>
        /// size of soda
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
                        break;
                    case (Size.Medium):
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case (Size.Large):
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;
                }
            }
        }
        /// <summary>
        /// soda ingredients
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
            string name = "";
            string[] tempArray = SplitCamelCase(this.GetType().Name);
            foreach (string s in tempArray)
            {
                name += s + " ";
            }
            name = name.Substring(0, name.Length - 1);
            return ($"{Size} {Flavor} {name}");
        }
    }
}
