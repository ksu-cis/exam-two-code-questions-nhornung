using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data; // included to use cobbler

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        public CustomizeCobblerControl()
        {
            InitializeComponent();
        }

        //I know this is wrong my mind blanked

        private void BlueberryButtonClicked(object sender, RoutedEventArgs e)
        {
            Cobbler c = (Cobbler)DataContext;
            c.Fruit = FruitFilling.Blueberry;

            FlavorList.Text = "Blueberry"; // :(
        }

        private void CherryButtonClicked(object sender, RoutedEventArgs e)
        {
            Cobbler c = (Cobbler)DataContext;
            c.Fruit = FruitFilling.Cherry;
        
            FlavorList.Text = "Cherry"; // :(
        }

        private void PeachButtonClicked(object sender, RoutedEventArgs e)
        {
            Cobbler c = (Cobbler)DataContext;
            c.Fruit = FruitFilling.Peach;
        
            FlavorList.Text = "Peach"; // :(
        }
    }
}
