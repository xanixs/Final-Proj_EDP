using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace EDP
{
    public partial class Managers : Form
    {
        public Managers()
        {
            InitializeComponent();
            LoadManagersData();

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            SearchManagers(); // Call the search function
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

        private void leasegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadManagersData()
        {
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ManagerID, name, email, phone, password FROM managers";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        // Mask the password column
                        foreach (DataRow row in dt.Rows)
                        {
                            row["password"] = new string('*', row["password"].ToString().Length);
                            managersgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                        }

                        managersgrid.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Insert form = new Insert();
            form.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (managersgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a manager to update.");
                return;
            }

            // Get selected row
            DataGridViewRow selectedRow = managersgrid.SelectedRows[0];

            // Extract data from selected row
            int managerId = Convert.ToInt32(selectedRow.Cells["ManagerID"].Value);
            string name = selectedRow.Cells["name"].Value.ToString();
            string email = selectedRow.Cells["email"].Value.ToString();
            string phone = selectedRow.Cells["phone"].Value.ToString();
            string password = selectedRow.Cells["password"].Value.ToString(); // Consider masking this for security

            // Pass data to UpdateManagerForm
            Form11 updateForm = new Form11(managerId, name, email, phone, password);
            updateForm.ShowDialog();

            // Reload data after update
            LoadManagersData();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (managersgrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a manager to delete.");
                return;
            }

            // Get selected manager's ID
            int managerId = Convert.ToInt32(managersgrid.SelectedRows[0].Cells["ManagerID"].Value);

            // Ask for confirmation before deleting
            DialogResult result = MessageBox.Show($"Are you sure you want to delete Manager ID {managerId}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Database connection
                string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM managers WHERE ManagerID = @ManagerID";

                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@ManagerID", managerId);
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Manager deleted successfully.");
                                LoadManagersData(); // Refresh the table
                            }
                            else
                            {
                                MessageBox.Show("Deletion failed. Manager might not exist.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void genrep_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                worksheet.Name = "Filtered Managers Report";

                // Headers
                for (int i = 0; i < managersgrid.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1] = managersgrid.Columns[i].HeaderText;
                }

                // Data - Export only visible rows
                int rowIndex = 2;
                foreach (DataGridViewRow row in managersgrid.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int colIndex = 0; colIndex < managersgrid.Columns.Count; colIndex++)
                        {
                            worksheet.Cells[rowIndex, colIndex + 1] = row.Cells[colIndex].Value?.ToString() ?? "";
                        }
                        rowIndex++;
                    }
                }

                string filePath = @"C:\Users\Public\FilteredManagersReport.xlsx";
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();

                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);

                MessageBox.Show($"Filtered report generated successfully at {filePath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SearchManagers();
            this.button1.Click += new System.EventHandler(this.button1_Click);
        }

        private void SearchManagers()
        {
            string searchText = search.Text.Trim();
            string connectionString = "server=localhost;user id=root;password=nicole;database=apartmentmanagement";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT ManagerID, name, email, phone, password FROM managers WHERE name LIKE @searchText";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Mask password column for security
                        foreach (DataRow row in dt.Rows)
                        {
                            row["password"] = new string('*', row["password"].ToString().Length);
                        }

                        managersgrid.DataSource = dt; // Update the grid with filtered data
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}