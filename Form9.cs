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
    public partial class Provider : Form
    {
        public Provider()
        {
            InitializeComponent();
            LoadProviderData();
        }

        private void LoadProviderData()
        {
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM serviceproviders";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind data to DataGridView
                        providergrid.DataSource = dt;

                        // Resize columns to fit content
                        providergrid.AutoGenerateColumns = true;
                        providergrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        providergrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading serviceproviders data: " + ex.Message);
            }
        }

        private void leasegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            apartment form = new apartment();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lease form = new lease();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rquest form = new rquest();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Managers form = new Managers();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payment form = new Payment();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tenant form = new tenant();
            form.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Provider form = new Provider();
            form.Show();
            this.Hide();
        }

        private void Provider_Load(object sender, EventArgs e)
        {

        }
    }
}
