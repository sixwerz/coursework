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
using YourProjectName;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course
{
    public partial class Login : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        string query = "SELECT Id, password, fk_role FROM users WHERE login = @login";

        public Login()
        {
            InitializeComponent();
            this.Text = "Авторизация";
            this.FormClosed += (s, args) => Application.Exit();

            //materialButtonLogin.HighEmphasis = false;

        }

        private void registerButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();

            registerForm.Show();

            this.Hide();
        }

        private void materialButtonLogin_Click(object sender, EventArgs e)
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

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", materialTextBoxLogin.Text.Trim());

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // проверяем пользователя с таким логином
                            if (reader.Read())
                            {
                                string hashedPasswordFromDb = reader["password"].ToString();
                                int roleId = Convert.ToInt32(reader["fk_role"]);

                                bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(materialTextBoxPassword.Text, hashedPasswordFromDb);

                                if (isPasswordCorrect)
                                {
                                    Session.UserId = Convert.ToInt32(reader["Id"]);
                                    Session.Username = materialTextBoxLogin.Text.Trim();
                                    MessageBox.Show("Авторизация успешна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if (roleId == 2)
                                    {
                                        // Панель администратора
                                        AdminPanel adminForm = new AdminPanel();
                                        adminForm.Show();
                                    }
                                    else if (roleId == 1)
                                    {
                                        // Панель пользователя
                                        UserPanel userForm = new UserPanel();
                                        userForm.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Роль пользователя не распознана.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка БД: " + ex.Message);
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
