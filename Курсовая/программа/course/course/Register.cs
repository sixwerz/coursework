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
    public partial class Register : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        string checkUserQuery = "SELECT COUNT(*) FROM users WHERE login = @login";

        public Register()
        {
            InitializeComponent();
            //this.FormClosed += (s, args) => Application.Exit();
            this.Text = "Регистрация";
        }

        private void loginButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();

            loginForm.Show();

            this.Hide();
        }

        private void materialRegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialTextBoxLogin.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Логин'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(materialTextBoxPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Пароль'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxPassword.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(materialTextBoxRepeatPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Повторите пароль'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxPassword.Focus();
                return;
            }

            if (materialTextBoxRepeatPassword.Text == materialTextBoxPassword.Text)
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {

                    connection.Open();
                    using (SqlCommand checkCommand = new SqlCommand(checkUserQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@login", materialTextBoxLogin.Text.Trim());
                        int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                        if (userCount > 0)
                        {
                            MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(materialTextBoxPassword.Text.Trim());

                    string insertQuery = "INSERT INTO users (login, password) VALUES (@login, @password)";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@login", materialTextBoxLogin.Text.Trim());
                        insertCommand.Parameters.AddWithValue("@password", hashedPassword);

                        int rowsAffected = insertCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Регистрация успешно завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Закрываем форму регистрации или перенаправляем на форму авторизации
                            this.Close();
                            Login login = new Login();
                            login.Show();
                        }
                        else
                        {
                            MessageBox.Show("Не удалось сохранить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRepeatPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

    }
}
