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
    public partial class tenant : Form
    {
        public tenant()
        {
            InitializeComponent();
            LoadTenantData();
        }

        private void LoadTenantData()
        {
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM tenants";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Bind data to DataGridView
                        tenantgrid.DataSource = dt;

                        // Resize columns to fit content
                        tenantgrid.AutoGenerateColumns = true;
                        tenantgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        tenantgrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tenants data: " + ex.Message);
            }
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

        private void tenant_Load(object sender, EventArgs e)
        {

        }
    }
}
