﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {

        public bool Lemon = false;
        public override Size Size { get; set; }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        public Water()
        {
            this.Price = .10;
            this.Calories = 0;
        }

        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
