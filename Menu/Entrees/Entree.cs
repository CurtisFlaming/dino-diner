/* Author: Curtis Flaming
 * Class: Entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem
    {
        /// <summary>
        /// Entree price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Entree Calories
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Entree ingredients
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }
        /// <summary>
        /// splits camel case string
        /// </summary>
        /// <param name="source"></param>
        /// <returns>string array</returns>
        public string[] SplitCamelCase(string source)
        {
            return Regex.Split(source, @"(?<!^)(?=[A-Z])");
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
            return ($"{name}");
        }
    }
}
