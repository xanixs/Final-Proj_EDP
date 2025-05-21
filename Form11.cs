using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP
{
    public partial class Form11 : Form
    {
        private int managerId;
        public Form11(int managerId, string name, string email, string phone, string password)
        {
            InitializeComponent();
            this.managerId = managerId;
            nametext.Text = name;
            emailtext.Text = email;
            phonetext.Text = phone;
            passtext.Text = ""; // Clear password field for security
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void upd_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=nicole;database=apartmentmanagement;";
            string hashedPassword = HashPassword(passtext.Text.Trim());

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"UPDATE managers SET 
                        name = @name, 
                        email = @email, 
                        phone = @phone, 
                        password = @password
                        WHERE ManagerID = @ManagerID";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@name", nametext.Text.Trim());
                    command.Parameters.AddWithValue("@email", emailtext.Text.Trim());
                    command.Parameters.AddWithValue("@phone", phonetext.Text.Trim());
                    command.Parameters.AddWithValue("@password", hashedPassword);
                    command.Parameters.AddWithValue("@ManagerID", managerId);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                        MessageBox.Show("Manager updated successfully.");
                    else
                        MessageBox.Show("Update failed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            this.Close();  // Close the update form
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }


        private void passtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
