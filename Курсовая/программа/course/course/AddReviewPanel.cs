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
using MaterialSkin.Controls;
using static System.Collections.Specialized.BitVector32;

namespace course
{
    public partial class AddReviewPanel : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        private int selectedProductId;
        public AddReviewPanel(int productId, string productName)
        {
            InitializeComponent();

            this.Text = "Добавить отзыв";
            this.selectedProductId = productId;
            labelTitle.Text = $"Отзыв для: {productName}";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO rates (comment, rate, fk_user, fk_product) VALUES (@comment, @rate, @fkUser, @fkProduct)";
            if (comboBoxRaiting.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите роль из выпадающего списка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else {
                int ratingValue = Convert.ToInt32(comboBoxRaiting.SelectedItem.ToString());

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@comment", textBoxComment.Text.Trim());

                        command.Parameters.AddWithValue("@rate", ratingValue);

                        command.Parameters.AddWithValue("@fkUser", Session.UserId);
                        command.Parameters.AddWithValue("@fkProduct", selectedProductId); // Переменная из конструктора

                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Отзыв сохранен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void AddReviewPanel_Load(object sender, EventArgs e)
        {

        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxRaiting_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
