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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// clear flavor displays to they don't keep adding up
        /// </summary>
        private void ClearSpecialStack()
        {
            SpecialStack.Children.RemoveRange(1, SpecialStack.Children.Count - 1);
        }
        /// <summary>
        /// create generic button
        /// </summary>
        /// <returns></returns>
        private Button AddSpecialStackButton()
        {
            Button button = new Button();
            button.Height = 100;
            button.Width = 100;
            return button;
        }
        /// <summary>
        /// handles sodasaurus click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusClick(object sender, RoutedEventArgs e)
        {
            ClearSpecialStack();
            Button flavbutton = AddSpecialStackButton();
            flavbutton.Content = "Flavor";
            Button icebutton = AddSpecialStackButton();
            icebutton.Content = "Hold Ice";
            SpecialStack.Children.Add(flavbutton);
            SpecialStack.Children.Add(icebutton);
            flavbutton.Click += ChooseFlavor;
        }
        /// <summary>
        /// send user to SodaFlavorSelection page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void ChooseFlavor(Object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SodaFlavorSelection());
        }
        /// <summary>
        /// handles tyranno tea click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoTeaClick(object sender, RoutedEventArgs e)
        {
            ClearSpecialStack();
            Button icebutton = AddSpecialStackButton();
            icebutton.Content = "Hold Ice";
            Button lemonbutton = AddSpecialStackButton();
            lemonbutton.Content = "Add Lemon";
            SpecialStack.Children.Add(icebutton);
            SpecialStack.Children.Add(lemonbutton);
        }
        /// <summary>
        /// handles jurassic java click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaClick(object sender, RoutedEventArgs e)
        {
            ClearSpecialStack();
            Button icebutton = AddSpecialStackButton();
            icebutton.Content = "Add Ice";
            Button sweetbutton = AddSpecialStackButton();
            sweetbutton.Content = "Add Sweetener";
            Button lemonbutton = AddSpecialStackButton();
            lemonbutton.Content = "Add Lemon";
            Button creambutton = AddSpecialStackButton();
            creambutton.Content = "Room For Cream";
            SpecialStack.Children.Add(icebutton);
            SpecialStack.Children.Add(sweetbutton);
            SpecialStack.Children.Add(lemonbutton);
            SpecialStack.Children.Add(creambutton);

        }
        /// <summary>
        /// handles water click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            ClearSpecialStack();
            Button icebutton = AddSpecialStackButton();
            icebutton.Content = "Hold Ice";
            SpecialStack.Children.Add(icebutton);
        }

    }
}
