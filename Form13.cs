using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EDP
{
   
    public partial class Form13 : Form

    {
        private string userEmail;
        public Form13(string userEmail)
        {
            InitializeComponent();
            this.userEmail = userEmail;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            string newPassword = textBox1.Text.Trim();
            string confirmPassword = textBox2.Text.Trim();

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            string hashedPassword = HashPassword(newPassword);

            if (UpdatePassword(hashedPassword))
            {
                MessageBox.Show("Password updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error updating password. Please try again.");
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }

        private bool UpdatePassword(string hashedPassword)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=nicole;database=apartmentmanagement"))
                {
                    conn.Open();
                    string query = "UPDATE managers SET password=@password WHERE email=@email";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@email", userEmail); // Use stored email!

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
