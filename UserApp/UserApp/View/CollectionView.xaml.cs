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
using UserApp.ViewModel;
using System.Text.RegularExpressions;

namespace UserApp.View
{
    public partial class CollectionView : UserControl
    {
        CollectionViewModel viewModel = new CollectionViewModel();
        public CollectionView()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void btnAddNewUser_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Users.Add(new Model.User() { Name = txtUserName.Text, Age = Int32.Parse(txtAge.Text) , Datas = txtUserName.Text + ", "+txtAge.Text});
            txtUserName.Text = string.Empty;
            txtAge.Text = string.Empty;
        }


        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

