using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;

namespace Delivery_on_WPF
{
    /// <summary>
    /// Interaction logic for Food_Window.xaml
    /// </summary>
    public partial class Food_Window : Window
    {
        class MyTable
        {
            public MyTable(int Id, string Vocalist, string Album, int Year)
            {
                this.Id = Id;
                this.Vocalist = Vocalist;
                this.Album = Album;
                this.Year = Year;
            }
            public int Id { get; set; }
            public string Vocalist { get; set; }
            public string Album { get; set; }
            public int Year { get; set; }
        }
        public Food_Window()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged_4(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged_5(object sender, TextChangedEventArgs e) { }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string table_name = "Food_delivery";
            if (Add_Data_CheckBox.IsChecked == true)
            {
                   Food food = new Food(Prod_name.Text + " " + Amount.Text + " " + Income.Text + " " + Consumption.Text + " " + IsCertified.Text + " " + Food_type.Text);
                   food.AddData(table_name);
            }
            if (Delete_Data_CheckBox.IsChecked == true)
            {
                Food.DeleteData(Prod_name_to_delete.Text, table_name);
                
            }
            if (Create_table_CheckBox.IsChecked == true)
            {
                try
                {
                    Food.CreateTable(table_name);
                }
                catch (Exception)
                {
                    MessageBox.Show("Table is already created!");
                }
            }
            this.Close();
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e) { }
        private void CheckBox_Checked_1(object sender, RoutedEventArgs e) { }
        private void TextBox_TextChanged_6(object sender, TextChangedEventArgs e) { }
        private void CheckBox_Checked_2(object sender, RoutedEventArgs e) { }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void Show_data_DataGrid_Loaded(object sender, RoutedEventArgs e) { }

        private void Show_data_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
           SqlConnection connect = null;
            try
            {
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = "SELECT * FROM Food_delivery";
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Food food = new Food
                    {
                        Product_name = Convert.ToString(sdr["Product"]),
                        Amount = Convert.ToInt32(sdr["Amount"]),
                        Income = float.Parse(Convert.ToString(sdr["Income"])),
                        Consumption = float.Parse(Convert.ToString(sdr["Consumtion"])),
                        isCertified = Convert.ToString(sdr["Certficate"]),
                        Food_type = Convert.ToString(sdr["Food_type"])
                    };
                    Show_data_DataGrid.Items.Add(food);
                };
            }
            catch (Exception a)
            {
                MessageBox.Show($"Here is problem {a}");
            }
            finally
            {
                connect.Close(); 
            }
        }
        private void Show_data_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Show_data_DataGrid.Items.Clear();
        }
        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
