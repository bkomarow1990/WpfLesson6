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
using System.Runtime.InteropServices;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLesson6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel ;
        public MainWindow()
        {
            viewModel = new ViewModel();
            InitializeComponent();
            this.DataContext = viewModel;
            //ColorsListBox.ItemsSource = viewModel.ColorsCollection;
        }

        private void ColorsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //viewModel.MyColor_ = (MyColor)ColorsListBox.SelectedItem;
            //viewModel.MyColor_.OnPropertyChanged();
        }
    }
}
