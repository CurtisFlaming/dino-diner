using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    

    public class Sodasaurus : Drink
    {
        private SodasaurusFlavor flavor;
        public SodasaurusFlavor Flavor {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
            }
        }

        public override Size Size {
            get
            {

            }
            set
            {

            }
        }

    }
}
