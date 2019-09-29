using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {

        public bool RoomForCream = false;
        
        public bool Decaf = false;

        public JurrasicJava()
        {
            this.Ice = false;
            this.Size = Size.Small;
        }

        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Water", "Coffee" };
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
                size = value;
                switch (size)
                {
                    case (Size.Small):
                        this.Price = .59;
                        this.Calories = 2;
                        break;
                    case (Size.Medium):
                        this.Price = .99;
                        this.Calories = 4;
                        break;
                    case (Size.Large):
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;
                }
            }
        }

        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }

        public void AddIce()
        {
            Ice = true;
        }
    }
}
