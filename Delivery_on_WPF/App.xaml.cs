using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace Delivery_on_WPF
{
    public abstract class Delivery
    {
        public string Product_name { get; set; }
        public int Amount { get; set; }
        public float Income { get; set; }
        public float Consumption { get; set; }
        public float Net_profit()
        {
            return Income - Income * 0.18f - Consumption;
        }
    }
    public class Food : Delivery
    {
        public string Food_type { get; set; }
        public string isCertified { get; set; }
        public Food(string s)
        {
            List<string> temp = s.Split(' ', ',').ToList();
            try
            {
                Product_name = temp[0]; //1
                Amount = Int32.Parse(temp[1]); //2
                Income = float.Parse(temp[2]); //3
                Consumption = float.Parse(temp[3]); //4
                isCertified = temp[4]; //5
                Food_type = temp[5]; //6
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }
        public Food() { }
        public static void CreateTable(string table_name)
        {
            SqlConnection connect = null;
            try
            {
                string con = "data source =.;database = Delivery;integrated security=SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("create table {0} (Product varchar(50), Amount int, Income float, Consumtion float, Net_Profit float, Certficate varchar(50), Food_type varchar(50))", table_name);
                SqlCommand command = new SqlCommand(cm, connect); //7 parameters
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public  void AddData(string table_name)
        {
            SqlConnection connect = null;
            try
            {
                //Product , Amount , Income , Consumtion , Net_Profit , Certficate , Food_type
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("INSERT INTO {0} (Product,  Amount, Income, Consumtion, Net_Profit, Certficate, Food_type)values('{1}','{2}','{3}','{4}','{5}','{6}','{7}')", table_name, Product_name, Amount, Income, Consumption, Net_profit(), isCertified, Food_type);
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("We got problems!");
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public static void DeleteData(string prod_name_to_delete, string table_name)
        {
            SqlConnection connect = null;
            try
            {
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("delete from {0} where Product = '{1}' ", table_name, prod_name_to_delete);
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Here is problem");
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
    }
    public class Equipment : Delivery
    {
        public Equipment () { }
        public string Producer { get; set; }
        public Equipment(string s)
        {
            List<string> temp = s.Split(' ', ',').ToList();
            try
            {
                Product_name = temp[0]; //1
                Amount = Int32.Parse(temp[1]); //2
                Income = float.Parse(temp[2]); //3
                Consumption = float.Parse(temp[3]); //4
                Producer = temp[4]; //5
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input data!");
            }
        }
        public static void CreateTable(string table_name)
        {
            SqlConnection connect = null;
            try
            {

                string con = "data source =.;database = Delivery;integrated security=SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("create table {0} (Product varchar(50), Amount int, Income float, Consumtion float, Net_Profit float, Producer varchar(50))", table_name);
                SqlCommand command = new SqlCommand(cm, connect); //6 parameters
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Can`t create table");
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public  void AddData(string table_name)
        {
            SqlConnection connect = null;
            try
            {
                //Product , Amount , Income , Consumtion , Net_Profit , Producer
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("INSERT INTO {0} (Product,  Amount, Income, Consumtion, Net_Profit, Producer)values('{1}','{2}','{3}','{4}','{5}','{6}')", table_name, Product_name, Amount, Income, Consumption, Net_profit(), Producer);
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("We got problems!");
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
        public static void DeleteData(string prod_name_to_delete, string table_name)
        {
            SqlConnection connect = null;
            try
            {
                string con = "data source =.; database = Delivery; integrated security = SSPI";
                connect = new SqlConnection(con);
                string cm = String.Format("delete from {0} where Product = '{1}' ", table_name, prod_name_to_delete);
                SqlCommand command = new SqlCommand(cm, connect);
                connect.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Here is problem");
                throw;
            }
            finally
            {
                connect.Close();
            }
        }
    }
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
