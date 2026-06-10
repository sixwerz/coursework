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
using MaterialSkin;
using MaterialSkin.Controls;

namespace course
{
    public partial class UserPanel : MaterialForm
    {
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\products.mdf;Integrated Security=True";
        string query = @"
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

        DataTable dataTable = new DataTable();
        DataTable dataTableRates = new DataTable();
        public UserPanel()
        {
            InitializeComponent();

            this.Text = "Оставление отзывов";
            this.FormClosed += (s, args) => Application.Exit();

            // Чтобы все нормально отображалось
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            updateProducts();

            if (!string.IsNullOrEmpty(Session.Username))
            {
                labelUsername.Text = Session.Username;
                labelUsername2.Text = Session.Username;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                int productId = Convert.ToInt32(row.Cells["Id"].Value);
                string productName = row.Cells["Название"].Value.ToString();

                AddReviewPanel reviewForm = new AddReviewPanel(productId, productName);
                reviewForm.ShowDialog();
            }
        }

        private void updateProducts() {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView.DataSource = dataTable;
                    if (dataGridView.Columns["Id"] != null)
                    {
                        dataGridView.Columns["Id"].Visible = false;
                    }
                }
                connection.Close();
            }
        }

        private void updateUsers() {
            string queryRates = @"
                        SELECT 
                            p.name AS [Название продукта],
                            r.comment AS [Комментарий], 
                            r.rate AS [Оценка], 
                            u.login AS [Пользователь]
                        FROM rates r
                        INNER JOIN users u ON r.fk_user = u.Id
                        INNER JOIN products p ON r.fk_product = p.Id";

            dataTableRates.Clear();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                using (SqlDataAdapter adapterRate = new SqlDataAdapter(queryRates, connection))
                {
                    adapterRate.Fill(dataTableRates);
                    dataGridViewRates.DataSource = dataTableRates;
                }
            }
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: // Продукты
                    updateProducts();
                    break;

                case 1: // Отзывы
                    updateUsers();
                    break;

                default:
                    break;
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

        private void materialTextBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string searchText = materialTextBoxSearchProduct.Text.Trim();

            // Достаем DataView напрямую из DataGridView (куда мы её положили при загрузке)
            if (dataGridView.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;

                if (string.IsNullOrEmpty(searchText))
                {
                    dv.RowFilter = string.Empty;
                }
                else
                {
                    // Используем экранирование и фильтр
                    dv.RowFilter = $"[Название] LIKE '%{searchText}%'";
                }
            }
            else if (dataGridView.DataSource is DataView dvDirect)
            {
                // На случай, если вы привязали к DataSource сразу DataView
                if (string.IsNullOrEmpty(searchText))
                {
                    dvDirect.RowFilter = string.Empty;
                }
                else
                {
                    dvDirect.RowFilter = $"[Название] LIKE '%{searchText}%'";
                }
            }
        }

        private void materialTextBoxSearchRatesProducts_TextChanged(object sender, EventArgs e)
        {
            string searchText = materialTextBoxSearchRatesProducts.Text.Trim();
            DataView dv = dataTableRates.DefaultView; // представление нашей таблицы для фильтрации

            if (string.IsNullOrEmpty(searchText))
            {
                // Если поисковая строка пустая — убираем фильтр и показываем всё
                dv.RowFilter = string.Empty;
            }
            else
            {
                dv.RowFilter = $"[Название продукта] LIKE '%{searchText}%'";
            }

            dataGridViewRates.DataSource = dv; // Обновляем данные в dataGridView
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonRates(object sender, EventArgs e)
        {

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
