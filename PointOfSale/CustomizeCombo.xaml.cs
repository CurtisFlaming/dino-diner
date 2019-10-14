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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// send user to SideSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SidesClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// send user to DrinkSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrinksClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
