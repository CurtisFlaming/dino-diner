using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {

        private bool Sweet = false;

        private bool Lemon = false;

        private uint sweetFactor = 1;

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
                        this.Price = .99;
                        this.Calories = 8 * sweetFactor;
                        break;
                    case (Size.Medium):
                        this.Price = 1.49;
                        this.Calories = 16 * sweetFactor;
                        break;
                    case (Size.Large):
                        this.Price = 1.99;
                        this.Calories = 32 * sweetFactor;
                        break;
                }
            }
        }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }

        public Tyrannotea()
        {
            this.Size = Size.Small;
        }

        public void AddLemon()
        {
            Lemon = true;
        }

        public void AddSweetener()
        {
            Sweet = true;
            sweetFactor = 2;
        }

        public void RemoveSweetener()
        {
            Sweet = false;
            sweetFactor = 1;
        }

    }
}
