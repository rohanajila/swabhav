using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace SQLInjection_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ActiveConnection"].ConnectionString;
            RetrieveData(connectionString);
            Console.Read();
        }
        public static void RetrieveData(string connectionString)
        {
            Console.WriteLine("Enter the Employee NO. of the employee whose details you want to show:");
            string id = Console.ReadLine();
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection(connectionString);
                // writing sql query  
                SqlCommand cm = new SqlCommand("Select * from EMP where EMPNO="+id+" ", con);
                // Opening Connection  
                con.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cm.ExecuteReader();
                // Iterating Data  
                
                    while (sdr.Read())
                    {
                        
                        Console.WriteLine(sdr["EMPNO"] + "\n" + sdr["ENAME"] + "\n" + sdr["JOB"] + "\n" + sdr["MGR"] + "\n" + sdr["HIREDATE"] + "\n" + sdr["SAL"] + "\n" + sdr["COMM"] + " " + sdr["DEPTNO"]); // Displaying Record  
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
    }
}
