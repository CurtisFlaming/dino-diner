/* Author: Curtis Flaming
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    public class Order
    {
        public Order() { }
       /// <summary>
       /// constructor used to set taxrate for tests
       /// </summary>
       /// <param name="taxrate"></param>
        public Order(double taxrate)
        {
            this.SalesTaxRate = taxrate;
        }

        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        public double SubtotalCost
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in Items)
                {
                    sum += item.Price;
                }
                if (sum > 0) return sum;
                return 0;
            }
        }
        public double SalesTaxRate { get; protected set; }

        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }
        
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
