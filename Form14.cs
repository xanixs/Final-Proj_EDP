using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT recovery_password FROM managers WHERE email = @email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", textBox2.Text);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show($"Recovery password found: {result.ToString()}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGINPAGE loginForm = new LOGINPAGE(); // Redirect back to login
            loginForm.Show();

        }

        private string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement"; // Move this outside method

        private void Change_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Generate a new password (consider hashing for security)
                    string newPassword = "NewSecurePassword123";

                    string query = "UPDATE managers SET password = @password WHERE email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", newPassword);
                        cmd.Parameters.AddWithValue("@email", textBox1.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password successfully recovered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open Form2 after successful password recovery
                            Form2 form2 = new Form2();
                            form2.Show();

                            this.Hide(); // Hide the current form
                        }
                        else
                        {
                            MessageBox.Show("Email not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
