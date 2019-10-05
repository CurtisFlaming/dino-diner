/* Author: Curtis Flaming
 * Class: Side
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace DinoDiner.Menu
{

  /// <summary>
  /// class to represent side
  /// </summary>
    public abstract class Side :IMenuItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; protected set; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// split camel case string
        /// </summary>
        /// <param name="source">string</param>
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
            foreach(string s in tempArray)
            {
                name += s + " ";
            }
            name = name.Substring(0, name.Length-1);
            return ($"{Size} {name}");
        }
    }
}
