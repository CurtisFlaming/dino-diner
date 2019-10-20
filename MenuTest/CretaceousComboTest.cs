/* Author: Curtis Flaming
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest
{
    public class CretaceousComboTest
    {

        [Fact]
        public void ComboHasCorrectPrice()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Assert.Equal<double>((double)7.39, (double)combo.Price);
        }

        [Fact]
        public void ComboHasCorrectCalories()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Assert.Equal<uint>(955, combo.Calories);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void CorrectSize(Size size)
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Assert.PropertyChanged(combo.Side, "Size", () =>
            {
                combo.Side.Size = size;
            });
            Assert.PropertyChanged(combo.Drink, "Size", () =>
            {
                combo.Drink.Size = size;
            });
        }

        [Fact]
        public void CorrectIngredients()
        {
            Brontowurst bront = new Brontowurst();
            CretaceousCombo combo = new CretaceousCombo(bront);
            Assert.Collection<string>(combo.Ingredients,
                item =>
                {
                    Assert.Equal("Brautwurst", item);
                },
                item =>
                {
                    Assert.Equal("Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Onion", item);
                },
                item =>
                {
                    Assert.Equal("Potato", item);
                },
                item =>
                {
                    Assert.Equal("Salt", item);
                },
                item =>
                {
                    Assert.Equal("Vegetable Oil", item);
                },
                item =>
                {
                    Assert.Equal("Water", item);
                },
                item =>
                {
                    Assert.Equal("Natural Flavors", item);
                },
                item =>
                {
                    Assert.Equal("Cane Sugar", item);
                }
                );
        }

        [Fact]
        public void CorrectDescription()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Assert.Equal("Steakosaurus Burger Combo", combo.Description);
        }

        [Fact]
        public void DefaultComboSpecialWithSteakburger()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            CretaceousCombo combo = new CretaceousCombo(burger);
            Assert.Collection<string>(combo.Special,
                item =>
                {
                    Assert.Equal("Small Fryceritops", item);
                },
                item =>
                {
                    Assert.Equal("Small Cola Sodasaurus", item);
                });
        }

        [Fact]
        public void ComboSpecialWithChange()
        {
            SteakosaurusBurger burger = new SteakosaurusBurger();
            burger.HoldBun();
            CretaceousCombo combo = new CretaceousCombo(burger);
            MeteorMacAndCheese mac = new MeteorMacAndCheese();
            combo.Side = mac;
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            combo.Drink = tea;
            Assert.Collection<string>(combo.Special,
                item =>
                {
                    Assert.Equal("Hold Whole Wheat Bun", item);
                },
                item =>
                {
                    Assert.Equal("Small Meteor Mac and Cheese", item);
                },
                item =>
                {
                    Assert.Equal("Small Tyrannotea", item);
                },
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }


    }
}
