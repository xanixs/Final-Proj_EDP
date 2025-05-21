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
using MySql.Data.MySqlClient;


namespace EDP
{
    public partial class LOGINPAGE : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=nicole;database=apartmentmanagement");
        public LOGINPAGE()
        {
            InitializeComponent();
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string email = email_textbox.Text;
            string password = password_textbox.Text;

            if (AuthenticateUser(email, password))
            {
                MessageBox.Show("Login successful!");
  
                apartment form = new apartment();
                form.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid email or password.");
            }

        }
        private bool AuthenticateUser(string email, string password)
        {
            try
            {
                conn.Open();
                string query = "SELECT password FROM managers WHERE email=@email";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);

                string storedPasswordHash = cmd.ExecuteScalar()?.ToString(); // Get the stored hashed password
                conn.Close();

                if (storedPasswordHash != null && storedPasswordHash == HashPassword(password))
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
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

        private void fpass_LinkClicked()
        {

        }

        private void fpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 forgotForm = new Form2();
            forgotForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form14 form14 = new Form14(); // Create an instance of Form14
            form14.Show();
        }
    }
 }
