/* Author: Curtis Flaming
 * Class: Drink
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent drink base class
    /// </summary>
    public abstract class Drink : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// item  description
        /// </summary>
        public string Description => ToString();
        /// <summary>
        /// item special attributes
        /// </summary>
        public virtual string[] Special { get; }
        /// <summary>
        /// property chaged event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// property changed handler
        /// </summary>
        /// <param name="property">property that is changed</param>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        /// <summary>
        /// method to remove ice
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
        }
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
            return ($"{Size} {name}");
        }
        /// <summary>
        /// for property change event
        /// </summary>
        public void NotifyChanges()
        {
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Size");
            NotifyOfPropertyChanged("Calories");
        }
    }
}
