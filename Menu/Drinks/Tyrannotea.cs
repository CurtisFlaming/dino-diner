using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// class to represent tea drink
    /// </summary>
    public class Tyrannotea : Drink
    {
        /// <summary>
        /// tea has sugar or not
        /// </summary>
        private bool Sweet = false;
        /// <summary>
        /// tea has lemon or not
        /// </summary>
        private bool Lemon = false;
        /// <summary>
        /// used to calculate calories if tea has sugar or now
        /// </summary>
        private uint sweetFactor = 1;
        /// <summary>
        /// tea size
        /// </summary>
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
        /// <summary>
        /// tea ingredients
        /// </summary>
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
        /// <summary>
        /// constructor sets default size to small
        /// </summary>
        public Tyrannotea()
        {
            this.Size = Size.Small;
        }
        /// <summary>
        /// method to add lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
        /// <summary>
        /// method to add sweetener
        /// </summary>
        public void AddSweetener()
        {
            Sweet = true;
            sweetFactor = 2;
        }
        /// <summary>
        /// method to remove sweetener
        /// </summary>
        public void RemoveSweetener()
        {
            Sweet = false;
            sweetFactor = 1;
        }

    }
}
