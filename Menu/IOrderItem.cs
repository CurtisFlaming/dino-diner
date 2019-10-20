using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public interface IOrderItem
    {
        /// <summary>
        /// Item price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Item description
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Item special description
        /// </summary>
        string[] Special { get; }
    }
}
