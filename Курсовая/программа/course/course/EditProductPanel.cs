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

namespace course
{
    public partial class EditProductPanel : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        private int productId;
        public EditProductPanel(int id, string name, string description)
        {
            InitializeComponent();
            this.Text = "Редактирование товара";

            this.productId = id;

            labelProduct.Text = name;
            textBoxName.Text = name;
            textBoxDescription.Text = description;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string newName = textBoxName.Text.Trim();
            string newDescription = textBoxDescription.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Название товара не может быть пустым!", "Предупреждение");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                string updateQuery = "UPDATE products SET name = @name, description = @description WHERE Id = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@name", newName);
                    command.Parameters.AddWithValue("@description", newDescription);
                    command.Parameters.AddWithValue("@id", productId);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Товар успешно обновлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Строка в базе данных не найдена. Возможно, товар был удален.", "Ошибка");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка SQL: {ex.Message}", "Критическая ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string productName = textBoxName.Text.Trim();

            DialogResult confirmResult = MessageBox.Show(
                $"Вы уверены, что хотите удалить товар '{productName}'?\nВсе связанные оценки и отзывы также будут удалены!",
                "Предупреждение об удалении",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM products WHERE Id = @id";

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", this.productId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Товар успешно удален из каталога!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось найти товар в базе данных. Возможно, он уже был удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка базы данных при удалении товара: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EditProductPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
