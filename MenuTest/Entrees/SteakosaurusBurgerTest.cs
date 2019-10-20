using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void CorrectDescription()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", burger.Description);
        }

        [Fact]
        public void DefaultEmptySpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.Empty(burger.Special);
        }

        [Fact]
        public void HoldBunToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldBun();
            Assert.Collection<string>(burger.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                });
        }
        [Fact]
        public void HoldKetchupToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldKetchup();
            Assert.Collection<string>(burger.Special,
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                });
        }
        [Fact]
        public void HoldMustardToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldMustard();
            Assert.Collection<string>(burger.Special,
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                });
        }
        [Fact]
        public void HoldPickleToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldPickle();
            Assert.Collection<string>(burger.Special,
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldEachToSpecial()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldBun();
            burger.HoldKetchup();
            burger.HoldMustard();
            burger.HoldPickle();
            Assert.Collection<string>(burger.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ketchup", item);
                },
                item =>
                {
                    Assert.Equal("Hold Mustard", item);
                },
                item =>
                {
                    Assert.Equal("Hold Pickle", item);
                });
        }

        [Fact]
        public void HoldEachNotifySpecialChanged()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldBun();
            });
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldKetchup();
            });
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldMustard();
            });
            Assert.PropertyChanged(burger, "Special", () =>
            {
                burger.HoldPickle();
            });
        }
    }

}
