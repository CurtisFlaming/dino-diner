/* Author: Curtis Flaming
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public SideSelection()
        {
            InitializeComponent();
        }

        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(new Fryceritops());
                this.Side = side;
            }
        }

        private void SelectSize(DinoDiner.Menu.Size size)
        {
            this.Side.Size = size;
        }

        protected void OnSelectLarge()
        {
            SelectSize(DinoDiner.Menu.Size.Large);
        }
        protected void OnSelectMedium()
        {
            SelectSize(DinoDiner.Menu.Size.Medium);
        }
        protected void OnSelectSmall()
        {
            SelectSize(DinoDiner.Menu.Size.Small);
        }

        public void AddFryceritopsClick(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }


        
        
    }
}
