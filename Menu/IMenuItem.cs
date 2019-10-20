/* Author: Curtis Flaming
 * Class: IMenuItem
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// interface for menu items
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// item price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// item calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// item ingredients
        /// </summary>
        List<string> Ingredients { get; }
        /// <summary>
        /// item to string
        /// </summary>
        /// <returns></returns>
        string ToString();
    }
}
