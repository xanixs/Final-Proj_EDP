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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM payments";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind data to DataGridView
                        paygrid.DataSource = dt;

                        // Resize columns to fit content
                        paygrid.AutoGenerateColumns = true;
                        paygrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        paygrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void leasegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void apabutton_Click(object sender, EventArgs e)
        {
            apartment form = new apartment();
            form.Show();
            this.Hide();
        }

        private void leasebutton_Click(object sender, EventArgs e)
        {
            lease form = new lease();
            form.Show();
            this.Hide();
        }

        private void reqbutton_Click(object sender, EventArgs e)
        {
            rquest form = new rquest();
            form.Show();
            this.Hide();
        }

        private void manbutton_Click(object sender, EventArgs e)
        {
            Managers form = new Managers();
            form.Show();
            this.Hide();
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();
            this.Hide();
        }

        private void tenbutton_Click(object sender, EventArgs e)
        {
            tenant form = new tenant();
            form.Show();
            this.Hide();
        }

        private void provbutton_Click(object sender, EventArgs e)
        {
            Provider form = new Provider();
            form.Show();
            this.Hide();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
