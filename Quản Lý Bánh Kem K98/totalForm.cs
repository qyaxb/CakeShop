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

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    public partial class totalForm : Form
    {
        string connectionString = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True";
        public totalForm()
        {
            InitializeComponent();
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
            btnReset.Click += btnReset_Click;
            LoadOrder(); // Load orders when the form is initialized
        }

        private void LoadOrder()
        {
            string query = @"SELECT OrderID, OrderDate, TotalAmount FROM [Orders] WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            dataGridView1.Columns["OrderID"].Visible = false; // Hide the OrderID column if not needed
        }
        private void btnCaculate_Click(object sender, EventArgs e)
        {
            string query = @"
    SELECT 
        SUM(QuantityStrawberry + QuantityChocolate + QuantityVanilla) AS TotalItemsSold, 
        SUM(TotalAmount) AS TotalRevenue
    FROM [Orders]
    WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int totalItems = reader["TotalItemsSold"] != DBNull.Value ? Convert.ToInt32(reader["TotalItemsSold"]) : 0;
                                decimal totalRevenue = reader["TotalRevenue"] != DBNull.Value ? Convert.ToDecimal(reader["TotalRevenue"]) : 0m;

                                MessageBox.Show($"Total Items Sold: {totalItems}\nTotal Revenue: ${totalRevenue:N2}", "Daily Summary");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating totals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                UpdateDataBase(e.RowIndex);
            }
        }
        private void UpdateDataBase(int rowIndex)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                if (row.Cells["OrderID"].Value == DBNull.Value)
                {
                    MessageBox.Show("OrderID cannot be null.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int orderId = Convert.ToInt32(row.Cells["OrderID"].Value);
                int quantity = row.Cells["Quantity"].Value == DBNull.Value ? 0 : Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal totalAmount = row.Cells["TotalAmount"].Value == DBNull.Value ? 0m : Convert.ToDecimal(row.Cells["TotalAmount"].Value);

                string query = @"
                    UPDATE [Order]
                    SET Quantity = @Quantity, TotalAmount = @TotalAmount
                    WHERE OrderID = @OrderID";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Quantity", quantity);
                        cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        cmd.Parameters.AddWithValue("@OrderID", orderId);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
