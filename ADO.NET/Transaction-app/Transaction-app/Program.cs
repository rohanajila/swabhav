using System;
using System.Data.SqlClient;
using System.Configuration;

namespace TransactionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlTransaction transaction = null;
            SqlCommand sqlCommand = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ActiveConnection"].ConnectionString);
            try
            {
                conn.Open();
                FetchCustomer(sqlCommand, conn);
                FetchMerchant(sqlCommand, conn);
                Console.WriteLine("Enter the customer ID:");
                int customerId=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Merchant ID:");
                int merchantId = int.Parse(Console.ReadLine());
                Console.Write("Enter money to pay  merchant: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                transaction = conn.BeginTransaction();
                sqlCommand = new SqlCommand($"update customer1 set balance = balance - {amt} where id = {customerId}", conn, transaction);
                sqlCommand.ExecuteNonQuery();

                sqlCommand = new SqlCommand($"update merchant set balance = balance + {amt} where id = {merchantId}", conn, transaction);
                sqlCommand.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Transaction successfull!\n");
                FetchCustomer(sqlCommand, conn);
                FetchMerchant(sqlCommand, conn);

            }
            catch (Exception e)
            {
                transaction.Rollback();
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
            Console.Read();
        }
        private static void FetchCustomer(SqlCommand sqlCommand, SqlConnection conn)
        {
            string cmd = "select * from customer1";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("ID   Name   Balance");
           
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0].ToString() + "   " + dataReader[1].ToString() + "   " + dataReader[2]);
            }
            Console.WriteLine();
            dataReader.Close();
        }
        private static void FetchMerchant(SqlCommand sqlCommand, SqlConnection conn)
        {
            string cmd = "select * from merchant";
            sqlCommand = new SqlCommand(cmd, conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("ID   Name   Balance");
           
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader[0].ToString() + "   " + dataReader[1].ToString() + "   " + dataReader[2]);
            }
            Console.WriteLine();
            dataReader.Close();
        }
    }
}