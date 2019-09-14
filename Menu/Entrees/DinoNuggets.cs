using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {

        //Implement a class to represent the Dino Nuggest entree.Its price is **$4.25**, 
        // it contains**59 calories** per nugget, and its ingredients are: **6** **chicken nuggets**.  
        //It should implement methods for adding a nugget at an additional **$0.25**.

        
        private int extraNuggz = 0;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
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
        
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * 6;
        }

        public void AddNugget()
        {
            this.Price += .25;
            this.Calories += 59;
            extraNuggz ++;
        }
    }
}
