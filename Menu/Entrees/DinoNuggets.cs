/* Author: Curtis Flaming
 * Class: DinoNuggets
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent Dino Nuggets menu item
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        public int extraNuggz = 0;

        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < 6 + extraNuggz; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }
        /// <summary>
        /// Method to add nuggets to order
        /// </summary>
        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            extraNuggz ++;
            NotifyChanges();
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
        /// <summary>
        /// special attributes
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (extraNuggz > 0) special.Add($"{extraNuggz} Extra Nuggets");
                return special.ToArray();
            }
        }
    }
}
