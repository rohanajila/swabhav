using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Student_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ActiveConnection"].ConnectionString;
            string data;
            //RetrieveData(connectionString);
            data = "insert into students(id, name, marks)values('4', 'Ronald', '80')";
            //InsertData(connectionString, data);
            DeleteData(connectionString);
            //ModifyData(connectionString);
            RetrieveData(connectionString);
            Console.Read();
        }
        public static void RetrieveData(string connectionString)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from students", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                while (sdr.Read())
                {
                    Console.WriteLine(sdr["id"] + "\n" + sdr["name"] + "\n" + sdr["marks"]); // Displaying Record  
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        public static void InsertData(string connectionString,string data)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand(data, con);  
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        public static void DeleteData(string connectionString)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand("delete from students where id = '4'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                Console.WriteLine("No. of rows affected:"+cm.ExecuteNonQuery());
                //Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
        public static void ModifyData(string connectionString)
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand("update students set name='ash' where id = '2'", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Updated Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
