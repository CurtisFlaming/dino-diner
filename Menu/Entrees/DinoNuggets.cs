using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Class to represent Dino Nuggets menu item
    /// </summary>
    public class DinoNuggets : Entree
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private int extraNuggz = 0;

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
        }
    }
}
