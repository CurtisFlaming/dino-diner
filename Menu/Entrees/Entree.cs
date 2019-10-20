/* Author: Curtis Flaming
 * Class: Entree
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// item description
        /// </summary>
        public string Description => ToString();
        /// <summary>
        /// special attributes
        /// </summary>
        public virtual string[] Special { get; }
        /// <summary>
        /// property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// property changed handler
        /// </summary>
        /// <param name="property"></param>
        protected void NotifyOfPropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
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

        public void NotifyChanges()
        {
            NotifyOfPropertyChanged("Special");
        }
    }
}
