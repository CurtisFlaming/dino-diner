/* Author: Curtis Flaming
 * Class: TRexKingBurger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to represent TRex King Burger menu item
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Bools to represent if ingredients are included or not in objects of this class
        /// </summary>
        private bool bun = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        
        /// <summary>
        /// List to store ingredients of this object
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Whole Wheat Bun");
                if (!pickle)special.Add("Hold Pickle");
                if (!ketchup)special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                if (!onion) special.Add("Hold Onion");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor for this class. 
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Methods do withold certain ingredients from Ingredients property
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyChanges();
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyChanges();
        }
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyChanges();
        }
        public void HoldOnion()
        {
            this.onion = false;
            NotifyChanges();
        }
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyChanges();
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyChanges();
        }
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyChanges();
        }
        public void HoldMayo()
        {
            this.mayo = false;
            NotifyChanges();
        }
        /// <summary>
        /// to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
