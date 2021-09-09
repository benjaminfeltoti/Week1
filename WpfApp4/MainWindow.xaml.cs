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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> peopleList = new List<Person>()
            {
                new Person(){ FirstName = "Smith", LastName = "Joe" },
                new Person(){ FirstName = "Smith", LastName = "Susan" },
                new Person(){ FirstName = "Smith", LastName = "John" },
            };


        public MainWindow()
        {
            InitializeComponent();

            peopleCombobox.ItemsSource = peopleList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0)
            {
                peopleList.Add(new Person() { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text });

                MessageBox.Show(lastNameTextBox.Text + " " + firstNameTextBox.Text + " was added to the combobox!");

                LinearGradientBrush brush = new LinearGradientBrush();
                brush.GradientStops.Add(new GradientStop(Colors.White, 0.0));
                firstNameTextBox.Background = brush;
                lastNameTextBox.Background = brush;
            }
            else
            {
                MessageBox.Show("Please fill the texts correctly!");

                LinearGradientBrush brush = new LinearGradientBrush();
                brush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));

                LinearGradientBrush whiteBrush = new LinearGradientBrush();
                whiteBrush.GradientStops.Add(new GradientStop(Colors.White, 0.0));

                if (firstNameTextBox.Text.Length == 0)
                {
                    firstNameTextBox.Background = brush;
                }
                else
                {
                    firstNameTextBox.Background = whiteBrush;
                }

                if (lastNameTextBox.Text.Length == 0)
                {
                    lastNameTextBox.Background = brush;
                }
                else
                {
                    lastNameTextBox.Background = whiteBrush;
                }
            }

            
        }
    }
}
