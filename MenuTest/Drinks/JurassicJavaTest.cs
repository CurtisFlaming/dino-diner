using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void ShouldHaveIceWhenAdded()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.True(java.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultCream()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.RoomForCream);
        }

        [Fact]
        public void RoomForCreamWorks()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.True(java.RoomForCream);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<double>(.59, java.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal<Size>(Size.Small, java.Size);
        }


        [Fact]
        public void ShouldHaveDefaultNoIce()
        {
            JurassicJava java = new JurassicJava();
            Assert.False(java.Ice);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForSmall()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Small;
            Assert.Equal<double>(.59, java.Price);
            Assert.Equal<uint>(2, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForMedium()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Medium;
            Assert.Equal<double>(.99, java.Price);
            Assert.Equal<uint>(4, java.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAndCaloriesForLarge()
        {
            JurassicJava java = new JurassicJava();
            java.Size = Size.Large;
            Assert.Equal<double>(1.49, java.Price);
            Assert.Equal<uint>(8, java.Calories);
        }

        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava java = new JurassicJava();
            List<string> ingredz = new List<string>() { "Water", "Coffee" };
            Assert.Equal<List<string>>(ingredz, java.Ingredients);
        }

        [Fact]
        public void CorrectDescription()
        {
            JurassicJava java = new JurassicJava();
            Assert.Equal(java.Size + " Jurassic Java", java.Description);
            java.Decaf = true;
            Assert.Equal(java.Size + " Decaf Jurassic Java", java.Description);
        }

        //[Fact]
        //public void CorrectDiscriptionAfterChange()
        //{
        //    JurassicJava java = new JurassicJava();

        //}

        [Fact]
        public void DefaultEmptySpecial()
        {
            JurassicJava java = new JurassicJava();
            Assert.Empty(java.Special);
        }

        [Fact]
        public void AddIceToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        [Fact]
        public void LeaveRoomForCreamToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                });
        }

        [Fact]
        public void RoomForCreamAndAddIceToSpecial()
        {
            JurassicJava java = new JurassicJava();
            java.LeaveRoomForCream();
            java.AddIce();
            Assert.Collection<string>(java.Special,
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        [Fact]
        public void AddIceAndRoomForCreamNotifySpecialChanged()
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.AddIce();
            });
            Assert.PropertyChanged(java, "Special", () =>
            {
                java.LeaveRoomForCream();
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyPriceChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Price", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifyCaloriesChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Calories", () =>
            {
                java.Size = size;
            });
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void NotifySizeChange(Size size)
        {
            JurassicJava java = new JurassicJava();
            Assert.PropertyChanged(java, "Size", () =>
            {
                java.Size = size;
            });
        }
    }
}
