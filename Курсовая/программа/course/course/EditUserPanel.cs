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
    public partial class EditUserPanel : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        private int userId;

        public EditUserPanel(int id, string login, string roleName)
        {
            InitializeComponent();
            this.Text = "Редактирование пользователя";

            this.userId = id;

            labelUsername.Text = login;
            textBoxUserLogin.Text = login;
            checkBoxIsAdmin.Checked = (roleName == "Администратор");

            // Пароль оставляем пустым для проверки
            textBoxUserPassword.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int newRoleId = checkBoxIsAdmin.Checked ? 2 : 1;
            string newLogin = textBoxUserLogin.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                bool isPasswordChanged = !string.IsNullOrWhiteSpace(textBoxUserPassword.Text);
                string updateQuery;

                if (isPasswordChanged)
                    updateQuery = "UPDATE users SET login = @login, password = @password, fk_role = @role WHERE Id = @id";
                else
                    updateQuery = "UPDATE users SET login = @login, fk_role = @role WHERE Id = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@login", newLogin);
                    command.Parameters.AddWithValue("@role", newRoleId);
                    command.Parameters.AddWithValue("@id", userId);

                    if (isPasswordChanged)
                    {
                        string hashedNewPassword = BCrypt.Net.BCrypt.HashPassword(textBoxUserPassword.Text.Trim());
                        command.Parameters.AddWithValue("@password", hashedNewPassword);
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            string userLogin = textBoxUserLogin.Text.Trim();
            DialogResult confirmResult = MessageBox.Show(
                $"Вы уверены, что хотите НАВСЕГДА удалить пользователя '{userLogin}'?",
                "Предупреждение об удалении",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM users WHERE Id = @id";

                using (SqlConnection connection = new SqlConnection(connString))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@id", this.userId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Пользователь успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Не удалось найти пользователя в базе данных. Возможно, он уже был удален.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Ошибка базы данных при удалении: {ex.Message}", "Критическая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void EditUserPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
