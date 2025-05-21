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
namespace EDP
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }



        private void enter_Click(object sender, EventArgs e)
        {
            string email = email1.Text.Trim();
            string phone = number.Text.Trim();

            if (ValidateUser(email, phone))
            {
                MessageBox.Show("Verification successful! Proceeding to password reset.");

                // Create an instance of Form13 and pass the email
                Form13 changeForm = new Form13(email);
                changeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or phone number. Please try again.");
            }
        }

        private bool ValidateUser(string email, string phone)
    {
        try
        {
            using (MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;password=nicole;database=apartmentmanagement"))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM managers WHERE email=@email AND phone=@phone";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
            return false;
        }
    }

    private void back_Click(object sender, EventArgs e)
        {

        }
    }
}
