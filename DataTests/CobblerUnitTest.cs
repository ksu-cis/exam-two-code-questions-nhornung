using System;
using System.ComponentModel;
using ExamTwoCodeQuestions.Data;
using Xunit;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerUnitTests
    {
        /// <summary>
        /// Checks if cobbler class implements INotifyPropertyChanged Interface
        /// </summary>
        [Fact]
        public void CobblerShouldImplementINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }
        
        /// <summary>
        /// Checks if changing the fruit filling invokes property changed event cherry
        /// </summary>
        [Fact]
        public void ChangingFruitFillingToCherryShouldInvokeINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () =>
            {
                cobbler.Fruit = FruitFilling.Cherry;
            });
        }

        /// <summary>
        /// (I don't know if I need this one too) but checks if the fruit filling invokes property changed event to blueberry
        /// </summary>
        [Fact]
        public void ChangingFruitFillingToBlueberryShouldInvokeINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () =>
            {
                cobbler.Fruit = FruitFilling.Blueberry;
            });
        }

        /// <summary>
        /// Checks if changing the ice cream preference invokes the property changed event
        /// </summary>
        [Fact]
        public void ChangingIceCreamShouldInvokeINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () =>
            {
                cobbler.WithIceCream = false;
            });
        }

        /********************************************************************************/

        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ShouldBeAbleToSetFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            cobbler.Fruit = fruit;
            Assert.Equal(fruit, cobbler.Fruit);
        }

        [Fact]
        public void ShouldBeServedWithIceCreamByDefault()
        {
            var cobbler = new Cobbler();
            Assert.True(cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetWithIceCream(bool serveWithIceCream)
        {
            var cobbler = new Cobbler();
            cobbler.WithIceCream = serveWithIceCream;
            Assert.Equal(serveWithIceCream, cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true, 5.32)]
        [InlineData(false, 4.25)]
        public void PriceShouldReflectIceCream(bool serveWithIceCream, double price)
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = serveWithIceCream
            };
            Assert.Equal(price, cobbler.Price);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var cobbler = new Cobbler();
            Assert.Empty(cobbler.SpecialInstructions);
        }

        [Fact]
        public void SpecialIstructionsShouldSpecifyHoldIceCream()
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = false
            };
            Assert.Collection<string>(cobbler.SpecialInstructions, instruction =>
            {
                Assert.Equal("Hold Ice Cream", instruction);
            });
        }

        [Fact]
        public void ShouldImplementIOrderItemInterface()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<IOrderItem>(cobbler);
        }
    }
}
