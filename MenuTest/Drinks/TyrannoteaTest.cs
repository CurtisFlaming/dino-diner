using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

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

        [Fact]
        public void CorrectDescription()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal((tea.Size + " Tyrannotea"), tea.Description);
            tea.Sweet = true;
            Assert.Equal((tea.Size + " Sweet Tyrannotea"), tea.Description);
        }

        [Fact]
        public void DefaultEmptySpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Empty(tea.Special);
        }

        [Fact]
        public void HoldIceToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddeLemonToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddLemonAndIceToSpecial()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            tea.AddLemon();
            Assert.Collection<string>(tea.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddLemonNotifySpecialChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.AddLemon();
            });
        }

        [Fact]
        public void AddIceNotifySpecialChanged()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Special", () =>
            {
                tea.HoldIce();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyPriceChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Price", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyCaloriesChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Calories", () =>
            {
                tea.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifySizeChange(Size size)
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.PropertyChanged(tea, "Size", () =>
            {
                tea.Size = size;
            });
        }
    }
}

