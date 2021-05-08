//Author: Abhishek Sawant, 8683623
using System.Windows;

namespace BindingPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VM vm = new VM();

        public MainWindow()
        {
            DataContext = vm;
            InitializeComponent();
        }

        private void Check_Button(object sender, RoutedEventArgs e)
        {
            vm.CheckButton();
        }

        private void Clear_Button(object sender, RoutedEventArgs e)
        {
            vm.ClearButton();
        }
    }
}
