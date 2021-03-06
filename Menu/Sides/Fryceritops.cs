﻿/* Author: Curtis Flaming
 * Class: Fryceritops
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent Fryceritops side order
    /// </summary>
    public class Fryceritops : Side
    {

        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
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
        /// Size of side. Sets price and calories
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
                        Calories = 480;
                        NotifyChanges();
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        NotifyChanges();
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        NotifyChanges();
                        break;
                }
                
            }
        } 
        
        public Fryceritops()
        {
            this.Size = Size.Small;
        }


    }
}
