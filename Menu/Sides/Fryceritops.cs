using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    public class Fryceritops : Side
    {


        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potatoe", "Salt", "Vegetable" };

                return ingredients;
            }
        }


        private Size size;
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                Size = value;
                switch (size)
                {
                    case Size.Large:
                        Price = 1.95;
                        Calories = 490;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Small:
                        Price = .99;
                        Calories = 222;
                        break;

                }
            }
        } 

        public Fryceritops()
        {
            this.Price = 0.99;
            this.Calories = 222;
            //this.Ingredients = new List<string>() { "Potatoe", "Salt", "Vegetable" };
        }


    }
}
