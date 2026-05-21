using NorthwindCustomerApp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NorthwindCustomerApp
{
    public partial class Form1 : Form
    {
        private string connectionString =
            "Server=localhost\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;";

        // Data Access Object
        private CustomerDataAccess dataAccess;

        public Form1()
        {
            InitializeComponent();

            // Initialize data access layer
            dataAccess = new CustomerDataAccess(connectionString);

            // Ensure event handlers are correctly connected (prevents designer issues)
            btnCount.Click += btnCount_Click;
            btnNames.Click += btnNames_Click;
            btnLastNames.Click += btnLastNames_Click;
        }

        // =========================
        // COUNT BUTTON
        // =========================
        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the total number of customers from the Data Access Layer
                int count = dataAccess.GetCustomerCount();

                // Display the result in the label
                lblCount.Text = "Customer Count: " + count;
            }
            catch (Exception ex)
            {
                // Show error if something goes wrong (SQL connection, query, etc.)
                MessageBox.Show("Error retrieving customer count: " + ex.Message);
            }
        }

        // =========================
        // CUSTOMER NAMES BUTTON
        // =========================
        private void btnNames_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous items in the list box
                lstCustomers.Items.Clear();

                // Get customer names from Data Access Layer
                List<string> names = dataAccess.GetCustomerNames();

                // Add each name to the list box
                foreach (string name in names)
                {
                    lstCustomers.Items.Add("Company: " + name);
                }
            }
            catch (Exception ex)
            {
                // Show error message if something fails
                MessageBox.Show("Error retrieving customer names: " + ex.Message);
            }
        }

        // =========================
        // LAST NAMES BUTTON
        // =========================
        private void btnLastNames_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear previous items in the list box
                lstCustomers.Items.Clear();

                // Get last names from Data Access Layer
                List<string> lastNames = dataAccess.GetCustomerLastNames();

                // Add each last name to the list box
                foreach (string name in lastNames)
                {
                    lstCustomers.Items.Add("Last Name: " + name);
                }
            }
            catch (Exception ex)
            {
                // Show error message if something fails
                MessageBox.Show("Error retrieving last names: " + ex.Message);
            }
        }
    }
}