using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace NorthwindCustomerApp.DataAccessLayer
{
    public class CustomerDataAccess
    {
        private string connectionString;

        public CustomerDataAccess(string connString)
        {
            connectionString = connString;
        }

        public int GetCustomerCount()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Customers", conn);
                return (int)cmd.ExecuteScalar();
            }
        }

        public List<string> GetCustomerNames()
        {
            List<string> names = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT CompanyName FROM Customers", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    names.Add(reader["CompanyName"].ToString());
                }
            }

            return names;
        }

        public List<string> GetCustomerLastNames()
        {
            List<string> lastNames = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT ContactName FROM Customers", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string fullName = reader["ContactName"].ToString();
                    string[] parts = fullName.Split(' ');

                    lastNames.Add(parts.Length > 1 ? parts[1] : fullName);
                }
            }

            return lastNames;
        }
    }
}