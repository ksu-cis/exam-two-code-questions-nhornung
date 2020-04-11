using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Handler for changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private FruitFilling fruit; // default is first value in enum - peach
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get { return fruit; }
            set
            {
                fruit = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fruit"));
               // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions")); // maybe?
            }
        }

        private bool withIceCream = true;
        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream 
        {
            get { return withIceCream; }
            set
            {
                withIceCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("WithIceCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {
                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                if(WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
            }
        }

        public override string ToString()
        {
            string cf = "";

            switch (Fruit)
            {
                case FruitFilling.Cherry:
                    cf += "Cherry";
                    break;
                case FruitFilling.Blueberry:
                    cf += "Blueberry";
                    break;
                case FruitFilling.Peach:
                    cf += "Peach";
                    break;
            }
            return cf + " Cobbler";
        }
    }
}
