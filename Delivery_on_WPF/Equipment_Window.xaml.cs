using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
namespace Delivery_on_WPF
{
    public partial class Equipment_Window : Window
    {
        public Equipment_Window()
        {
            InitializeComponent();
        }
        private void Add_Data_CheckBox_Checked(object sender, RoutedEventArgs e) { }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string table_name = "Equipment_delivery";
            if (Add_Data_CheckBox.IsChecked == true)
            {
                Equipment equipment = new Equipment(prod_name.Text + " " + amount.Text + " " + income.Text + " " + consumption.Text + " " + producer.Text);
                equipment.AddData(table_name);
            }
            if (Delete_Data_CheckBox.IsChecked == true)
            {
                Equipment.DeleteData(prod_name_to_delete_TextBox.Text, table_name);
            }
            if (Create_table_CheckBox.IsChecked == true)
            {
                Equipment.CreateTable(table_name);
            }
            Close();
        }
        private void prod_name_TextChanged(object sender, TextChangedEventArgs e) { }
        private void amount_TextChanged(object sender, TextChangedEventArgs e) { }
        private void income_TextChanged(object sender, TextChangedEventArgs e) { }
        private void consumption_TextChanged(object sender, TextChangedEventArgs e) { }
        private void producer_TextChanged(object sender, TextChangedEventArgs e) { }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e) { }
        private void CheckBox_Checked(object sender, RoutedEventArgs e) { }
        private void Show_data_DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        private void Show_Data_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SqlConnection connect = null;
            try
            {
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = "SELECT * FROM Equipment_delivery";
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                SqlDataReader sdr = command.ExecuteReader();
                while (sdr.Read())
                {
                    Equipment equipment = new Equipment
                    {
                        Product_name = Convert.ToString(sdr["Product"]),
                        Amount = Convert.ToInt32(sdr["Amount"]),
                        Income = float.Parse(Convert.ToString(sdr["Income"])),
                        Consumption = float.Parse(Convert.ToString(sdr["Consumtion"])),
                        Producer = Convert.ToString(sdr["Producer"])
                    };
                    Show_data_DataGrid.Items.Add(equipment);
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

        private void Show_Data_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Show_data_DataGrid.Items.Clear();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();

        }
    }
}