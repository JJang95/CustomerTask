using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections;

namespace CustomerTask
{
    public partial class FormMain : Form
    {
        SqlConnection connection;
        string connectionString;
        public FormMain()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CustomerTask.Properties.Settings.ProjectConnectionString"].ConnectionString;

            PopulateCustomers();
            //listCustomer_SelectedIndexChanged(object sender, EventArgs e)
            listCustomer.SelectedIndexChanged += new EventHandler(listCustomer_SelectedIndexChanged);
            //buttonAddCustomer_Click(object sender, EventArgs e)
            buttonAddCustomer.Click += new EventHandler(buttonAddCustomer_Click);
            //buttonDeleteCustomer_Click(object sender, EventArgs e)
            buttonDeleteCustomer.Click += new EventHandler(buttonDeleteCustomer_Click);

        }

        //retrieves all customer data from database and populates a list box control with the customer name and their respective IDs

        private void PopulateCustomers()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", connection))
            {
                DataTable customerTable = new DataTable();
                adapter.Fill(customerTable);

                listCustomer.DisplayMember = "Name";
                listCustomer.ValueMember = "Id";
                listCustomer.DataSource = customerTable;
            }
        }

        //retrieves the tasks associated with the selected customer from the database and populates a list of tasks.

        private void PopulateTask()
        {
            string query = "SELECT a.Name FROM Task a " +
                           "INNER JOIN CustomerTask b ON a.Id = b.TaskId " +
                           "WHERE b.CustomerId = @CustomerId";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@CustomerId", listCustomer.SelectedValue);

                DataTable taskTable = new DataTable();
                adapter.Fill(taskTable);

                listTask.DisplayMember = "Name";
                listTask.ValueMember = "Id";
                listTask.DataSource = taskTable;
            }
        }

        private void listCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTask();
        }

        //populates the list of tasks for the selected customer and adds a new customer to the database and updates the list of customers.

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Customer VALUES (@CustomerName,'test', 0000000000)";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerName", textCustomerName.Text);

                command.ExecuteScalar();
            }

            PopulateCustomers(); // Call PopulateCustomers to update the list
        }

        //deletes the customer from the list and updates the database and repopulates the customer list to display the updated data.
        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Customer WHERE Name = @CustomerName";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@CustomerName", textCustomerNameTwo.Text);

                command.ExecuteScalar();
            }

            PopulateCustomers(); // Call PopulateCustomers to update the list
        }
    }
}
