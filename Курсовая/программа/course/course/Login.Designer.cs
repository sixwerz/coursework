namespace course
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.LinkLabel();
            this.materialButtonLogin = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(110, 121);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(258, 20);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(110, 204);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(258, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(259, 327);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(106, 20);
            this.registerButton.TabIndex = 7;
            this.registerButton.TabStop = true;
            this.registerButton.Text = "Регистрация";
            this.registerButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerButton_LinkClicked);
            // 
            // materialButtonLogin
            // 
            this.materialButtonLogin.AutoSize = false;
            this.materialButtonLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLogin.Depth = 0;
            this.materialButtonLogin.HighEmphasis = true;
            this.materialButtonLogin.Icon = null;
            this.materialButtonLogin.Location = new System.Drawing.Point(110, 272);
            this.materialButtonLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLogin.Name = "materialButtonLogin";
            this.materialButtonLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLogin.Size = new System.Drawing.Size(258, 38);
            this.materialButtonLogin.TabIndex = 8;
            this.materialButtonLogin.Text = "Войти";
            this.materialButtonLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLogin.UseAccentColor = false;
            this.materialButtonLogin.UseVisualStyleBackColor = true;
            this.materialButtonLogin.Click += new System.EventHandler(this.materialButtonLogin_Click);
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(-23, -46);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(100, 50);
            this.materialTextBox1.TabIndex = 9;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBoxLogin
            // 
            this.materialTextBoxLogin.AnimateReadOnly = false;
            this.materialTextBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxLogin.Depth = 0;
            this.materialTextBoxLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLogin.LeadingIcon = null;
            this.materialTextBoxLogin.Location = new System.Drawing.Point(110, 121);
            this.materialTextBoxLogin.MaxLength = 50;
            this.materialTextBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLogin.Multiline = false;
            this.materialTextBoxLogin.Name = "materialTextBoxLogin";
            this.materialTextBoxLogin.Size = new System.Drawing.Size(258, 50);
            this.materialTextBoxLogin.TabIndex = 10;
            this.materialTextBoxLogin.Text = "";
            this.materialTextBoxLogin.TrailingIcon = null;
            this.materialTextBoxLogin.TextChanged += new System.EventHandler(this.materialTextBoxLogin_TextChanged);
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(110, 204);
            this.materialTextBoxPassword.MaxLength = 50;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Multiline = false;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.Size = new System.Drawing.Size(258, 50);
            this.materialTextBoxPassword.TabIndex = 11;
            this.materialTextBoxPassword.Text = "";
            this.materialTextBoxPassword.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(110, 99);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 12;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(110, 182);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 13;
            this.materialLabel2.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(107, 327);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 19);
            this.materialLabel3.TabIndex = 14;
            this.materialLabel3.Text = "Еще нет аккаунта ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBoxPassword);
            this.Controls.Add(this.materialTextBoxLogin);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.materialButtonLogin);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.LinkLabel registerButton;
        private MaterialSkin.Controls.MaterialButton materialButtonLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

