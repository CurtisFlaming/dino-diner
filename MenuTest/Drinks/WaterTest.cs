using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {

        [Fact]
        public void ShouldHaveCorrectDefaultPriceAndCalories()
        {
            Water water = new Water();
            Assert.Equal<double>(.10, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            Water water = new Water();
            water.Size = Size.Small;
            Assert.Equal<double>(.1, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(.1, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(.1, water.Price);
            Assert.Equal<uint>(0, water.Calories);
        }

        [Fact]
        public void HoldIceWorks()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }

        [Fact]
        public void AddLemonWorks()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }

        [Fact]
        public void CorrectDescription()
        {
            Water water = new Water();
            Assert.Equal((water.Size + " Water"), water.Description);
        }

        [Fact]
        public void DefaultEmptySpecial()
        {
            Water water = new Water();
            Assert.Empty(water.Special);
        }

        [Fact]
        public void HoldIceToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddeLemonToSpecial()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void AddLemonAndIceToSpecial()
        {
            Water water = new Water();
            water.HoldIce();
            water.AddLemon();
            Assert.Collection<string>(water.Special,
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
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.AddLemon();
            });
        }

        [Fact]
        public void AddIceNotifySpecialChanged()
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Special", () =>
            {
                water.HoldIce();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifySizeChange(Size size)
        {
            Water water = new Water();
            Assert.PropertyChanged(water, "Size", () =>
            {
                water.Size = size;
            });
        }
    }
}
