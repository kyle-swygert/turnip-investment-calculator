using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TurnipCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // only want to write to the textbox in the program, not available to the user. 
            resultsTextBox.IsReadOnly = true;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // parse the text that is in the textfields too see that the strings represent integers. 

            // if all the strings represent integers, then calculate the stats for the program. 


            try
            {
                // parse the strings as integers.
                var purchase = Int32.Parse(purchaseTextBox.Text);
                var selling = Int32.Parse(sellingTextBox.Text);
                var units = Int32.Parse(turnipsBoughtTextBox.Text);

                var calcResults = new Turnip(purchase, selling, units);


                resultsTextBox.Text = calcResults.generateCalculationResults();

            }
            catch
            {
                // the strings were not entered as integers, display an error message in the results textBox. 
                resultsTextBox.Text = "ERROR: \r\nNot all Strings that were entered were integers, please try again with whole numbers in all boxes.";
               
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // purchase price
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            // selling price
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            // number turnips bought
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            // this is the results textbox for the application.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // when the button is clicked, go to the gitHub website for the project. 
            System.Diagnostics.Process.Start("https://github.com/kyle-swygert/turnip-investment-calculator");
        }
    }
}
