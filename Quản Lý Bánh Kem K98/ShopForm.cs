using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quản_Lý_Quán_Bánh_Kem_K98
{
    public partial class ShopForm : Form
    {
        private string currentUser; // Lưu trữ tên đăng nhập của người dùng hiện tại
        private const decimal PriceStrawberry = 14.00m;
        private const decimal PriceChocolate = 30.00m;
        private const decimal PriceVanilla = 16.00m;

        string connectionString = @"Data Source=LAPTOP-22RF98LR;Initial Catalog=QLyBanhKemK98;Integrated Security=True";
        public ShopForm()
        {
            InitializeComponent();
            comboBoxPayment.Items.AddRange(new string[] { "Credit Card", "PayPal", "Visa Card", "Cash" });
            comboBoxDeliveryMethod.Items.AddRange(new string[] { "Shipping", "Pick Up" });
        }
        public string CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is not a digit and not a control key (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ignore the input
            }
        }
        private void txtQuantityStraw_TextChanged(object sender, EventArgs e)
        {
            UpdateCart();
            CalculateTotal();
        }

        private void txtQuantityChoco_TextChanged(object sender, EventArgs e)
        {
            UpdateCart();
            CalculateTotal();
        }

        private void txtQuantityVanilla_TextChanged(object sender, EventArgs e)
        {
            UpdateCart();
            CalculateTotal();
        }
        private void UpdateCart()
        {
            OnCart.Items.Clear();

            int quantityStraw = int.TryParse(txtQuantityStraw.Text, out int qStraw) ? qStraw : 0;
            int quantityChoco = int.TryParse(txtQuantityChoco.Text, out int qChoco) ? qChoco : 0;
            int quantityVanilla = int.TryParse(txtQuantityVanilla.Text, out int qVanilla) ? qVanilla : 0;

            if (quantityStraw > 0)
                OnCart.Items.Add($"Strawberry Cake: {quantityStraw}");

            if (quantityChoco > 0)
                OnCart.Items.Add($"Chocolate Cake: {quantityChoco}");

            if (quantityVanilla > 0)
                OnCart.Items.Add($"Vanilla Cake: {quantityVanilla}");

            // Tính tổng sau khi cập nhật giỏ hàng
            CalculateTotal();
        }
        private void comboBoxPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeliveryMethod_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDeliveryMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Chuyển đổi ListViewItem thành string
                    string orderDetails = string.Join(", ", OnCart.Items.Cast<ListViewItem>().Select(item => item.Text).ToArray());

                    string query = @"
            INSERT INTO Orders (PhoneNumber, QuantityStrawberry, QuantityChocolate, QuantityVanilla, PaymentMethod, DeliveryMethod, TotalAmount, Description)
            VALUES (@PhoneNumber, @QuantityStrawberry, @QuantityChocolate, @QuantityVanilla, @PaymentMethod, @DeliveryMethod, @TotalAmount, @OrderDetails)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);

                        command.Parameters.AddWithValue("@QuantityStrawberry", int.TryParse(txtQuantityStraw.Text, out int quantityStraw) ? quantityStraw : 0);
                        command.Parameters.AddWithValue("@QuantityChocolate", int.TryParse(txtQuantityChoco.Text, out int quantityChoco) ? quantityChoco : 0);
                        command.Parameters.AddWithValue("@QuantityVanilla", int.TryParse(txtQuantityVanilla.Text, out int quantityVanilla) ? quantityVanilla : 0);

                        command.Parameters.AddWithValue("@PaymentMethod", comboBoxPayment.SelectedItem != null ? comboBoxPayment.SelectedItem.ToString() : string.Empty);
                        command.Parameters.AddWithValue("@DeliveryMethod", comboBoxDeliveryMethod.SelectedItem != null ? comboBoxDeliveryMethod.SelectedItem.ToString() : string.Empty);

                        decimal totalAmount;
                        if (!decimal.TryParse(txtTotal.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out totalAmount))
                        {
                            MessageBox.Show("Invalid total amount.");
                            return;
                        }
                        command.Parameters.AddWithValue("@TotalAmount", totalAmount);

                        command.Parameters.AddWithValue("@OrderDetails", orderDetails);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Order placed successfully!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception to a file
                System.IO.File.WriteAllText("error_log.txt", ex.ToString());
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void CalculateTotal()
        {
            int quantityStraw = int.TryParse(txtQuantityStraw.Text, out int qStraw) ? qStraw : 0;
            int quantityChoco = int.TryParse(txtQuantityChoco.Text, out int qChoco) ? qChoco : 0;
            int quantityVanilla = int.TryParse(txtQuantityVanilla.Text, out int qVanilla) ? qVanilla : 0;

            decimal total = (quantityStraw * PriceStrawberry) +
                            (quantityChoco * PriceChocolate) +
                            (quantityVanilla * PriceVanilla);

            txtTotal.Text = total.ToString("C2");
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng tất cả các form?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    openForm.Close();
                }
                this.Close();
            }
        }
    }
}
