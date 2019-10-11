﻿/* Author: Curtis Flaming
 * Class: JurassicJava
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class to represent coffee drink
    /// </summary>
    public class JurassicJava : Drink
    {
        /// <summary>
        /// coffee has room for cream or now
        /// </summary>
        public bool RoomForCream = false;
        /// <summary>
        /// coffee is decaf or not
        /// </summary>
        public bool Decaf = false;
        /// <summary>
        /// constructor sets default size to small and ice to false
        /// </summary>
        public JurassicJava()
        {
            this.Ice = false;
            this.Size = Size.Small;
        }
        /// <summary>
        /// coffee ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
            }
        }
        /// <summary>
        /// coffee size
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
                    case (Size.Small):
                        this.Price = .59;
                        this.Calories = 2;
                        break;
                    case (Size.Medium):
                        this.Price = .99;
                        this.Calories = 4;
                        break;
                    case (Size.Large):
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
            }
        }
        /// <summary>
        /// method sets cream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// method sets ice true
        /// </summary>
        public void AddIce()
        {
            Ice = true;
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
            if (Decaf)
            {
                return ($"{Size} Decaf {name}");
            }
            return ($"{Size} {name}");
        }
    }
}