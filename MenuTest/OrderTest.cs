using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void SubtotalCostCannotBeNeg()
        {
            Order order = new Order(0);
            MockDrink mockdrink = new MockDrink(-5);
            order.Items.Add(mockdrink);
            Assert.True(order.SubtotalCost >= 0);
        }

        [Fact]
        public void CorrectSubtotalCost()
        {
            Order order = new Order(0);
            MockEntree mockEntree = new MockEntree(5);
            MockSide mockSide = new MockSide(5);
            MockDrink mockDrink = new MockDrink(5);
            order.Items.Add(mockEntree);
            order.Items.Add(mockSide);
            order.Items.Add(mockDrink);
            Assert.Equal<Double>(15, order.SubtotalCost);
        }

        [Fact]
        public void SalesTaxCalculatedCorrectly()
        {
            Order order = new Order(.1);
            MockEntree mockEntree = new MockEntree(100);
            order.Items.Add(mockEntree);
            Assert.Equal<double>(10, order.SalesTaxCost);
        }

        [Fact]
        public void TotalCostCalculatedCorrectly()
        {
            Order order = new Order(.1);
            MockEntree mockEntree = new MockEntree(100);
            order.Items.Add(mockEntree);
            Assert.Equal<double>(110, order.TotalCost);
        }
    }

    public class MockDrink : IOrderItem
    {
        public double Price { get; } 
        public string Description => throw new NotImplementedException();
        public string[] Special => throw new NotImplementedException();
        public MockDrink(double price)
        {
            Price = price;
        }
    }

    public class MockSide : IOrderItem
    {
        public double Price { get; }
        public string Description => throw new NotImplementedException();
        public string[] Special => throw new NotImplementedException();
        public MockSide(double price)
        {
            Price = price;
        }
    }

    public class MockEntree : IOrderItem
    {
        public double Price { get; }
        public string Description => throw new NotImplementedException();
        public string[] Special => throw new NotImplementedException();
        public MockEntree(double price)
        {
            Price = price;
        }
    }

}
