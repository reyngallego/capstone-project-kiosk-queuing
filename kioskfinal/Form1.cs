using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace kioskfinal
{

    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are empty
            if (string.IsNullOrWhiteSpace(nametxt.Text) || string.IsNullOrWhiteSpace(departmentcbx.Text) || string.IsNullOrWhiteSpace(purposetxt.Text))
            {
                MessageBox.Show("Please fill in all fields before queuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method, don't proceed with the database insert
            }

            Button button = (Button)sender;
            string buttonText = button.Text;
            string queueCode = ""; // Declare queueCode here

            // Determine which TextBox is active and append the clicked button's text
            if (nametxt.Focused)
            {
                nametxt.Text += buttonText;
            }
            else if (departmentcbx.Focused)
            {
                departmentcbx.Text += buttonText;
            }
            else if (purposetxt.Focused)
            {
                purposetxt.Text += buttonText;
            }

            // Get today's date
            DateTime todayDate = DateTime.Today;

            // Insert data into the database
            string connectionString = "Data Source=reyn\\SQLEXPRESS;Initial Catalog=loginform;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Count the number of records in the database
                    string countQuery = "SELECT COUNT(*) FROM stu_data";
                    using (SqlCommand countCommand = new SqlCommand(countQuery, connection))
                    {
                        int currentQueueNumber = Convert.ToInt32(countCommand.ExecuteScalar()) + 1;

                        // Format the queue code
                        queueCode = "A-" + currentQueueNumber.ToString("000");

                        string insertQuery = "INSERT INTO stu_data (Name, Department, Purpose, QueueNumber, QueueDate, QueueCode) VALUES (@Name, @Department, @Purpose, @QueueNumber, @QueueDate, @QueueCode)";
                        using (SqlCommand command = new SqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Name", nametxt.Text);
                            command.Parameters.AddWithValue("@Department", departmentcbx.Text);
                            command.Parameters.AddWithValue("@Purpose", purposetxt.Text);
                            command.Parameters.AddWithValue("@QueueNumber", currentQueueNumber);
                            command.Parameters.AddWithValue("@QueueDate", todayDate);
                            command.Parameters.AddWithValue("@QueueCode", queueCode);

                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Display a success message
                MessageBox.Show("Successfully queued with code: " + queueCode, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally, you can clear the input fields after successful insertion.
                nametxt.Clear();
                departmentcbx.SelectedIndex = -1;
                purposetxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Handle the error as needed.
            }

        }

    }

}