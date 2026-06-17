namespace course
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxIsAdmin = new System.Windows.Forms.CheckBox();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTextBoxSearchProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButtonAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxProductDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTextBoxSearchUsers = new MaterialSkin.Controls.MaterialTextBox();
            this.linkLabelLogout2 = new System.Windows.Forms.LinkLabel();
            this.materialButtonAddUser = new MaterialSkin.Controls.MaterialButton();
            this.labelUsername2 = new System.Windows.Forms.Label();
            this.materialTextBoxUserPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxUserLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 232);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(583, 415);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            this.dataGridViewProducts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Название продукта";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(0, 232);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(583, 415);
            this.dataGridViewUsers.TabIndex = 5;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание продукта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Логин пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Пароль пользователя";
            // 
            // checkBoxIsAdmin
            // 
            this.checkBoxIsAdmin.AutoSize = true;
            this.checkBoxIsAdmin.Location = new System.Drawing.Point(225, 126);
            this.checkBoxIsAdmin.Name = "checkBoxIsAdmin";
            this.checkBoxIsAdmin.Size = new System.Drawing.Size(105, 17);
            this.checkBoxIsAdmin.TabIndex = 14;
            this.checkBoxIsAdmin.Text = "Администратор";
            this.checkBoxIsAdmin.UseVisualStyleBackColor = true;
            this.checkBoxIsAdmin.CheckedChanged += new System.EventHandler(this.checkBoxIsAdmin_CheckedChanged);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.tabPage1);
            this.tabPage.Controls.Add(this.tabPage2);
            this.tabPage.Location = new System.Drawing.Point(12, 67);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(597, 682);
            this.tabPage.TabIndex = 15;
            this.tabPage.SelectedIndexChanged += new System.EventHandler(this.tabPage_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialTextBoxSearchProduct);
            this.tabPage1.Controls.Add(this.materialButtonAddProduct);
            this.tabPage1.Controls.Add(this.materialTextBoxProductDesc);
            this.tabPage1.Controls.Add(this.materialTextBoxProductName);
            this.tabPage1.Controls.Add(this.linkLabelLogout);
            this.tabPage1.Controls.Add(this.labelUsername);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridViewProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(589, 656);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продукты";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // materialTextBoxSearchProduct
            // 
            this.materialTextBoxSearchProduct.AnimateReadOnly = false;
            this.materialTextBoxSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSearchProduct.Depth = 0;
            this.materialTextBoxSearchProduct.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxSearchProduct.LeadingIcon = null;
            this.materialTextBoxSearchProduct.Location = new System.Drawing.Point(361, 74);
            this.materialTextBoxSearchProduct.MaxLength = 50;
            this.materialTextBoxSearchProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearchProduct.Multiline = false;
            this.materialTextBoxSearchProduct.Name = "materialTextBoxSearchProduct";
            this.materialTextBoxSearchProduct.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxSearchProduct.TabIndex = 17;
            this.materialTextBoxSearchProduct.Text = "";
            this.materialTextBoxSearchProduct.TrailingIcon = null;
            this.materialTextBoxSearchProduct.TextChanged += new System.EventHandler(this.materialTextBoxSearchProduct_TextChanged);
            // 
            // materialButtonAddProduct
            // 
            this.materialButtonAddProduct.AutoSize = false;
            this.materialButtonAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddProduct.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddProduct.Depth = 0;
            this.materialButtonAddProduct.HighEmphasis = true;
            this.materialButtonAddProduct.Icon = null;
            this.materialButtonAddProduct.Location = new System.Drawing.Point(9, 170);
            this.materialButtonAddProduct.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddProduct.Name = "materialButtonAddProduct";
            this.materialButtonAddProduct.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddProduct.Size = new System.Drawing.Size(210, 35);
            this.materialButtonAddProduct.TabIndex = 16;
            this.materialButtonAddProduct.Text = "Создать";
            this.materialButtonAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddProduct.UseAccentColor = false;
            this.materialButtonAddProduct.UseVisualStyleBackColor = true;
            this.materialButtonAddProduct.Click += new System.EventHandler(this.materialButtonAddProduct_Click);
            // 
            // materialTextBoxProductDesc
            // 
            this.materialTextBoxProductDesc.AnimateReadOnly = false;
            this.materialTextBoxProductDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxProductDesc.Depth = 0;
            this.materialTextBoxProductDesc.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxProductDesc.LeadingIcon = null;
            this.materialTextBoxProductDesc.Location = new System.Drawing.Point(9, 111);
            this.materialTextBoxProductDesc.MaxLength = 50;
            this.materialTextBoxProductDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductDesc.Multiline = false;
            this.materialTextBoxProductDesc.Name = "materialTextBoxProductDesc";
            this.materialTextBoxProductDesc.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxProductDesc.TabIndex = 15;
            this.materialTextBoxProductDesc.Text = "";
            this.materialTextBoxProductDesc.TrailingIcon = null;
            // 
            // materialTextBoxProductName
            // 
            this.materialTextBoxProductName.AnimateReadOnly = false;
            this.materialTextBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxProductName.Depth = 0;
            this.materialTextBoxProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxProductName.LeadingIcon = null;
            this.materialTextBoxProductName.Location = new System.Drawing.Point(9, 31);
            this.materialTextBoxProductName.MaxLength = 50;
            this.materialTextBoxProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxProductName.Multiline = false;
            this.materialTextBoxProductName.Name = "materialTextBoxProductName";
            this.materialTextBoxProductName.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxProductName.TabIndex = 14;
            this.materialTextBoxProductName.Text = "";
            this.materialTextBoxProductName.TrailingIcon = null;
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(358, 31);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(39, 13);
            this.linkLabelLogout.TabIndex = 13;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Выйти";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(358, 12);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(41, 13);
            this.labelUsername.TabIndex = 12;
            this.labelUsername.Text = "label7";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск продукта";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialTextBoxSearchUsers);
            this.tabPage2.Controls.Add(this.linkLabelLogout2);
            this.tabPage2.Controls.Add(this.materialButtonAddUser);
            this.tabPage2.Controls.Add(this.labelUsername2);
            this.tabPage2.Controls.Add(this.materialTextBoxUserPassword);
            this.tabPage2.Controls.Add(this.materialTextBoxUserLogin);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Controls.Add(this.checkBoxIsAdmin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(589, 656);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxSearchUsers
            // 
            this.materialTextBoxSearchUsers.AnimateReadOnly = false;
            this.materialTextBoxSearchUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSearchUsers.Depth = 0;
            this.materialTextBoxSearchUsers.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxSearchUsers.LeadingIcon = null;
            this.materialTextBoxSearchUsers.Location = new System.Drawing.Point(361, 74);
            this.materialTextBoxSearchUsers.MaxLength = 50;
            this.materialTextBoxSearchUsers.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearchUsers.Multiline = false;
            this.materialTextBoxSearchUsers.Name = "materialTextBoxSearchUsers";
            this.materialTextBoxSearchUsers.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxSearchUsers.TabIndex = 22;
            this.materialTextBoxSearchUsers.Text = "";
            this.materialTextBoxSearchUsers.TrailingIcon = null;
            this.materialTextBoxSearchUsers.TextChanged += new System.EventHandler(this.materialTextBoxSearchUsers_TextChanged);
            // 
            // linkLabelLogout2
            // 
            this.linkLabelLogout2.AutoSize = true;
            this.linkLabelLogout2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelLogout2.LinkColor = System.Drawing.Color.Blue;
            this.linkLabelLogout2.Location = new System.Drawing.Point(358, 31);
            this.linkLabelLogout2.Name = "linkLabelLogout2";
            this.linkLabelLogout2.Size = new System.Drawing.Size(39, 13);
            this.linkLabelLogout2.TabIndex = 18;
            this.linkLabelLogout2.TabStop = true;
            this.linkLabelLogout2.Text = "Выйти";
            this.linkLabelLogout2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout2_LinkClicked);
            // 
            // materialButtonAddUser
            // 
            this.materialButtonAddUser.AutoSize = false;
            this.materialButtonAddUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddUser.Depth = 0;
            this.materialButtonAddUser.HighEmphasis = true;
            this.materialButtonAddUser.Icon = null;
            this.materialButtonAddUser.Location = new System.Drawing.Point(9, 170);
            this.materialButtonAddUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddUser.Name = "materialButtonAddUser";
            this.materialButtonAddUser.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddUser.Size = new System.Drawing.Size(210, 35);
            this.materialButtonAddUser.TabIndex = 21;
            this.materialButtonAddUser.Text = "Создать";
            this.materialButtonAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddUser.UseAccentColor = false;
            this.materialButtonAddUser.UseVisualStyleBackColor = true;
            this.materialButtonAddUser.Click += new System.EventHandler(this.materialButtonAddUser_Click);
            // 
            // labelUsername2
            // 
            this.labelUsername2.AutoSize = true;
            this.labelUsername2.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername2.Location = new System.Drawing.Point(358, 12);
            this.labelUsername2.Name = "labelUsername2";
            this.labelUsername2.Size = new System.Drawing.Size(41, 13);
            this.labelUsername2.TabIndex = 17;
            this.labelUsername2.Text = "label7";
            // 
            // materialTextBoxUserPassword
            // 
            this.materialTextBoxUserPassword.AnimateReadOnly = false;
            this.materialTextBoxUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxUserPassword.Depth = 0;
            this.materialTextBoxUserPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxUserPassword.LeadingIcon = null;
            this.materialTextBoxUserPassword.Location = new System.Drawing.Point(9, 111);
            this.materialTextBoxUserPassword.MaxLength = 50;
            this.materialTextBoxUserPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxUserPassword.Multiline = false;
            this.materialTextBoxUserPassword.Name = "materialTextBoxUserPassword";
            this.materialTextBoxUserPassword.Password = true;
            this.materialTextBoxUserPassword.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxUserPassword.TabIndex = 20;
            this.materialTextBoxUserPassword.Text = "";
            this.materialTextBoxUserPassword.TrailingIcon = null;
            // 
            // materialTextBoxUserLogin
            // 
            this.materialTextBoxUserLogin.AnimateReadOnly = false;
            this.materialTextBoxUserLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxUserLogin.Depth = 0;
            this.materialTextBoxUserLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxUserLogin.LeadingIcon = null;
            this.materialTextBoxUserLogin.Location = new System.Drawing.Point(9, 31);
            this.materialTextBoxUserLogin.MaxLength = 50;
            this.materialTextBoxUserLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxUserLogin.Multiline = false;
            this.materialTextBoxUserLogin.Name = "materialTextBoxUserLogin";
            this.materialTextBoxUserLogin.Size = new System.Drawing.Size(210, 50);
            this.materialTextBoxUserLogin.TabIndex = 19;
            this.materialTextBoxUserLogin.Text = "";
            this.materialTextBoxUserLogin.TrailingIcon = null;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Поиск пользователя";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 751);
            this.Controls.Add(this.tabPage);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxIsAdmin;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUsername2;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.LinkLabel linkLabelLogout2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxProductName;
        private MaterialSkin.Controls.MaterialButton materialButtonAddProduct;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxProductDesc;
        private MaterialSkin.Controls.MaterialButton materialButtonAddUser;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxUserPassword;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxUserLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchUsers;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchProduct;
    }
}