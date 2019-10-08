using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TytannoteaTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(.99, tea.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Small;
            Assert.Equal<double>(.99, tea.Price);
            Assert.Equal<uint>(8, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
            Assert.Equal<uint>(16, tea.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
            Assert.Equal<uint>(32, tea.Calories);
        }

        [Fact]
        public void HoldIceWorks()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        [Fact]
        public void HoldLemonWorks()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Ice);
        }

        [Fact]
        public void CorrectIngredients()
        {
            Tyrannotea tea = new Tyrannotea();
            List<string> ingredz = new List<string>() { "Water", "Tea" };
            Assert.Equal<List<string>>(ingredz, tea.Ingredients);
        }

        [Fact]
        public void SweetHasCorrectPriceAndCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddSweetener();
            tea.Size = Size.Small;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(32, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(64, tea.Calories);
        }

        [Fact]
        public void RemoveSweetHasCorrectPriceAndCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.RemoveSweetener();
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }
    }
}

