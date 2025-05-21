using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace EDP
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void nametext_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void phonetext_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            string hashedPassword = HashPassword(passtext.Text.Trim()); // Hash the password before inserting

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO managers (name, email, phone, password) VALUES (@name, @email, @phone, @password)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", nametext.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", emailtext.Text.Trim());
                        cmd.Parameters.AddWithValue("@phone", phonetext.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", hashedPassword); // Store hashed password

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Manager added successfully!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add manager.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

    }
}
