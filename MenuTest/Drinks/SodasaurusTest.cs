using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {

        [Fact]
        public void ShouldBeAbleToSetFlavors()
        {
            Sodasaurus soda = new Sodasaurus();

            foreach(SodasaurusFlavor flav in Enum.GetValues(typeof(SodasaurusFlavor))){
                soda.Flavor = flav;
                Assert.Equal<SodasaurusFlavor>(flav, soda.Flavor);
            }
            
        }


        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small,soda.Size);
        }


        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
            Assert.Equal<uint>(208, soda.Calories);
        }

        [Fact]
        public void HoldIceWorks()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        [Fact]
        public void CorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredz = new List<string>() { "Water", "Natural Flavors", "Cane Sugar" };
            Assert.Equal<List<string>>(ingredz,soda.Ingredients);
        }

        [Fact]
        public void CorrectDescription()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal($"{soda.Size} {soda.Flavor} Sodasaurus",soda.Description);
        }

        [Fact]
        public void DefaultEmptySpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldIceToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void HoldIceNotifySpecialChanged()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special", () =>
            {
                soda.HoldIce();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyPriceChange(Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price", () =>
            {
                soda.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyCaloriesChange(Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Calories", () =>
            {
                soda.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifySizeChange(Size size)
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Size", () =>
            {
                soda.Size = size;
            });
        }

    }
}
