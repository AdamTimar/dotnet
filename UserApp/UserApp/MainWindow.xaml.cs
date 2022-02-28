﻿using System;
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

namespace UserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel viewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = viewModel;
        }
        private void btnChangeName_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ChangeName(txtNewName.Text);
        }

        private void CollectionView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }

}
