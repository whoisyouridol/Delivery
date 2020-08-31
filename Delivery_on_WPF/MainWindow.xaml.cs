using System.Windows;
namespace Delivery_on_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void Button_Click(object sender, RoutedEventArgs e)
        //{ 
        //    MessageBox.Show("Hello world!");
        //}
        private void Test_button (object sender, RoutedEventArgs e)
        {
            if (Food_Case.IsChecked == true)
            {
                var food = new Food_Window();
                Close();
                food.ShowDialog();
            }
            if (Equipment_case.IsChecked == true)
            {
                var equipment = new Equipment_Window();
                Close();
                equipment.ShowDialog();
            }
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e) { }
        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) { }
    }
}
