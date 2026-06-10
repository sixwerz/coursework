using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace course
{
    public partial class AdminPanel : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        string queryUsers = @"SELECT 
                u.Id, 
                u.login AS [Логин], 
                r.name AS [Роль]
            FROM users u
            INNER JOIN roles r ON u.fk_role = r.Id";

        string queryProducts = @"
            SELECT 
                p.Id, 
                CAST(p.name AS NVARCHAR(MAX)) AS [Название], 
                CAST(p.description AS NVARCHAR(MAX)) AS [Описание], 
                ISNULL(AVG(CAST(r.rate AS FLOAT)), 0) AS [Средняя оценка]
            FROM products p
            LEFT JOIN rates r ON p.Id = r.fk_product
            GROUP BY p.Id, 
                     CAST(p.name AS NVARCHAR(MAX)), 
                     CAST(p.description AS NVARCHAR(MAX))";

        DataTable dataTableProducts = new DataTable();
        DataTable dataTableUsers = new DataTable();
        public AdminPanel()
        {
            InitializeComponent();

            this.Text = "Оставление отзывов Администратор";
            this.FormClosed += (s, args) => Application.Exit();

            // Чтобы все нормально отображалось
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            UpdateProducts();
            UpdateUsers();

            if (!string.IsNullOrEmpty(Session.Username))
            {
                labelUsername.Text = Session.Username;
                labelUsername2.Text = Session.Username;
            }
            else
            {
                labelUsername.Text = "Добро пожаловать, Гость!";
                labelUsername2.Text = "Добро пожаловать, Гость!";
            }
        }

        public void UpdateUsers()
        {
            dataTableUsers.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryUsers, connection))
                {
                    adapter.Fill(dataTableUsers);
                }
            }
            dataGridViewUsers.DataSource = dataTableUsers;
        }

        public void UpdateProducts()
        {
            dataTableProducts.Clear();
            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(queryProducts, connection))
                {
                    adapter.Fill(dataTableProducts);
                }
            }
            dataGridViewProducts.DataSource = dataTableProducts;
        }

        private void tabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabPage.SelectedIndex)
            {
                case 0: // Продукты
                    UpdateProducts();
                    break;

                case 1: // Пользователи
                    UpdateUsers();
                    break;
            }
        }

        int selectedUserId = -1;

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];

                // задаем строки для дальнейшего редактирования
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string login = row.Cells["Логин"].Value.ToString();
                string roleName = row.Cells["Роль"].Value.ToString();
                EditUserPanel editForm = new EditUserPanel(id, login, roleName);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProducts.Rows[e.RowIndex];

                // Вытаскиваем все данные из выбранной строки таблицы
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                string name = row.Cells["Название"].Value.ToString();
                string description = row.Cells["Описание"].Value.ToString();

                // Создаем форму редактирования и передаем туда эти данные
                EditProductPanel editForm = new EditProductPanel(id, name, description);

                // Открываем её как модальное окно (ShowDialog). 
                // Код ниже замрёт и будет ждать, пока пользователь не закроет форму редактирования.
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    UpdateUsers();
                }
            }
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();

                loginForm.Show();
                this.Hide();
            }
        }

        private void linkLabelLogout2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Login loginForm = new Login();

                loginForm.Show();
                this.Hide();
            }
        }

        private void materialButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialTextBoxProductName.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Название продукта'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxProductName.Focus();
                return;
            }

            string checkProductQuery = "SELECT COUNT(*) FROM products WHERE name = @name";
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlCommand checkCommand = new SqlCommand(checkProductQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@name", materialTextBoxProductName.Text.Trim());

                    int productCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (productCount > 0)
                    {
                        MessageBox.Show("Продукт с таким названием уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string insertQuery = "INSERT INTO products (name, description) VALUES (@name, @description)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@name", materialTextBoxProductName.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@description", materialTextBoxProductDesc.Text);

                    int rowsAffected = insertCommand.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Продукт успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateProducts();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void materialButtonAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(materialTextBoxUserLogin.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Логин'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxUserLogin.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(materialTextBoxUserPassword.Text))
            {
                MessageBox.Show("Пожалуйста, заполните поле 'Пароль'!", "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                materialTextBoxUserPassword.Focus();
                return;
            }

            string checkUserQuery = "SELECT COUNT(*) FROM users WHERE login = @login";

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // 2. Проверяем, существует ли логин
                using (SqlCommand checkCommand = new SqlCommand(checkUserQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@login", materialTextBoxUserLogin.Text.Trim());
                    int userCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("Пользователь с таким логином уже зарегистрирован!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // 3. Хэшируем пароль и определяем роль
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(materialTextBoxUserPassword.Text.Trim());

                int roleId = 1; // По умолчанию обычный пользователь
                if (checkBoxIsAdmin.Checked)
                {
                    roleId = 2; // Если галочка стоит — администратор
                }

                // 4. Сохраняем в базу (Соединение ТУТ ОТКРЫТО, строчка Close удалена)
                string insertQuery = "INSERT INTO users (login, password, fk_role) VALUES (@login, @password, @fkRole)";

                using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@login", materialTextBoxUserLogin.Text.Trim());
                    insertCommand.Parameters.AddWithValue("@password", hashedPassword);
                    insertCommand.Parameters.AddWithValue("@fkRole", roleId);

                    int rowsAffected = insertCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация успешно завершена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Очищаем поля после успешного добавления
                        materialTextBoxUserLogin.Clear();
                        materialTextBoxUserPassword.Clear();
                        checkBoxIsAdmin.Checked = false;

                        UpdateUsers(); // Обновляем таблицу на экране
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } // Здесь блок using автоматически и безопасно закроет подключение к БД
        }

        private void materialTextBoxSearchUsers_TextChanged(object sender, EventArgs e)
        {
            string searchText = materialTextBoxSearchUsers.Text.Trim();
            DataView dv = dataTableUsers.DefaultView; // представление нашей таблицы для фильтрации

            if (string.IsNullOrEmpty(searchText))
            {
                // Если поисковая строка пустая — убираем фильтр и показываем всё
                dv.RowFilter = string.Empty;
            }
            else
            {
                dv.RowFilter = $"[Логин] LIKE '%{searchText}%'";
            }

            dataGridViewUsers.DataSource = dv; // Обновляем данные в dataGridView
        }

        private void materialTextBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = materialTextBoxSearchProduct.Text.Trim();
            DataView dv = dataTableProducts.DefaultView; // представление нашей таблицы для фильтрации

            if (string.IsNullOrEmpty(searchText))
            {
                // Если поисковая строка пустая — убираем фильтр и показываем всё
                dv.RowFilter = string.Empty;
            }
            else
            {
                dv.RowFilter = $"[Название] LIKE '%{searchText}%'";
            }

            dataGridViewProducts.DataSource = dv; // Обновляем данные в dataGridView
        }

        private void textBoxProductName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSearchUsers_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUserLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
