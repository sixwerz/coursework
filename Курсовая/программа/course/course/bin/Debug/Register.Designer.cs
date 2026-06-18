namespace course
{
    partial class Register
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
            this.loginButton = new System.Windows.Forms.LinkLabel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.materialTextBoxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxRepeatPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialRegisterButton = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginButton.Location = new System.Drawing.Point(259, 375);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(56, 20);
            this.loginButton.TabIndex = 15;
            this.loginButton.TabStop = true;
            this.loginButton.Text = "Войти";
            this.loginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginButton_LinkClicked);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(111, 105);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(258, 20);
            this.textBoxLogin.TabIndex = 9;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // materialTextBoxLogin
            // 
            this.materialTextBoxLogin.AnimateReadOnly = false;
            this.materialTextBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxLogin.Depth = 0;
            this.materialTextBoxLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLogin.LeadingIcon = null;
            this.materialTextBoxLogin.Location = new System.Drawing.Point(111, 102);
            this.materialTextBoxLogin.MaxLength = 50;
            this.materialTextBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLogin.Multiline = false;
            this.materialTextBoxLogin.Name = "materialTextBoxLogin";
            this.materialTextBoxLogin.Size = new System.Drawing.Size(258, 50);
            this.materialTextBoxLogin.TabIndex = 18;
            this.materialTextBoxLogin.Text = "";
            this.materialTextBoxLogin.TrailingIcon = null;
            // 
            // materialTextBoxPassword
            // 
            this.materialTextBoxPassword.AnimateReadOnly = false;
            this.materialTextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxPassword.Depth = 0;
            this.materialTextBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxPassword.LeadingIcon = null;
            this.materialTextBoxPassword.Location = new System.Drawing.Point(110, 182);
            this.materialTextBoxPassword.MaxLength = 50;
            this.materialTextBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxPassword.Multiline = false;
            this.materialTextBoxPassword.Name = "materialTextBoxPassword";
            this.materialTextBoxPassword.Password = true;
            this.materialTextBoxPassword.Size = new System.Drawing.Size(258, 50);
            this.materialTextBoxPassword.TabIndex = 19;
            this.materialTextBoxPassword.Text = "";
            this.materialTextBoxPassword.TrailingIcon = null;
            // 
            // materialTextBoxRepeatPassword
            // 
            this.materialTextBoxRepeatPassword.AnimateReadOnly = false;
            this.materialTextBoxRepeatPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxRepeatPassword.Depth = 0;
            this.materialTextBoxRepeatPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxRepeatPassword.LeadingIcon = null;
            this.materialTextBoxRepeatPassword.Location = new System.Drawing.Point(110, 264);
            this.materialTextBoxRepeatPassword.MaxLength = 50;
            this.materialTextBoxRepeatPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxRepeatPassword.Multiline = false;
            this.materialTextBoxRepeatPassword.Name = "materialTextBoxRepeatPassword";
            this.materialTextBoxRepeatPassword.Password = true;
            this.materialTextBoxRepeatPassword.Size = new System.Drawing.Size(258, 50);
            this.materialTextBoxRepeatPassword.TabIndex = 20;
            this.materialTextBoxRepeatPassword.Text = "";
            this.materialTextBoxRepeatPassword.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(107, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 21;
            this.materialLabel1.Text = "Логин";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(108, 160);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 22;
            this.materialLabel2.Text = "Пароль";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(108, 242);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(139, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Повторите пароль";
            // 
            // materialRegisterButton
            // 
            this.materialRegisterButton.AutoSize = false;
            this.materialRegisterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRegisterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialRegisterButton.Depth = 0;
            this.materialRegisterButton.HighEmphasis = true;
            this.materialRegisterButton.Icon = null;
            this.materialRegisterButton.Location = new System.Drawing.Point(110, 324);
            this.materialRegisterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialRegisterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRegisterButton.Name = "materialRegisterButton";
            this.materialRegisterButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialRegisterButton.Size = new System.Drawing.Size(259, 36);
            this.materialRegisterButton.TabIndex = 24;
            this.materialRegisterButton.Text = "Создать аккаунт";
            this.materialRegisterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialRegisterButton.UseAccentColor = false;
            this.materialRegisterButton.UseVisualStyleBackColor = true;
            this.materialRegisterButton.Click += new System.EventHandler(this.materialRegisterButton_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(108, 378);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(145, 19);
            this.materialLabel4.TabIndex = 25;
            this.materialLabel4.Text = "Уже есть аккаунт ?";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 454);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialRegisterButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTextBoxRepeatPassword);
            this.Controls.Add(this.materialTextBoxPassword);
            this.Controls.Add(this.materialTextBoxLogin);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBoxLogin);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.TextBox textBoxLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxLogin;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxRepeatPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton materialRegisterButton;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
    }
}