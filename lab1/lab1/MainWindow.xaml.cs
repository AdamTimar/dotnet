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

namespace lab1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Person person;
        private List<Person> persons;
        public MainWindow()
        {
            person = new Person();
            persons = new List<Person>;
            InitializeComponent();
            runMeButton.IsEnabled = false;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;
            MessageBox.Show($"Hello {person.FirstName} {person.LastName}");
            person = new Person();
        }

        private  void FirstNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0)
                runMeButton.IsEnabled = true;
            else
                runMeButton.IsEnabled = false;

        }

        private void LastNameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (firstNameTextBox.Text.Length > 0 && lastNameTextBox.Text.Length > 0)
                runMeButton.IsEnabled = true;
            else
                runMeButton.IsEnabled = false;
        }
    }
}
