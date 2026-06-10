namespace course
{
    partial class UserPanel
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialTextBoxSearchProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialTextBoxSearchRatesProducts = new MaterialSkin.Controls.MaterialTextBox();
            this.linkLabelLogout2 = new System.Windows.Forms.LinkLabel();
            this.labelUsername2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewRates = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(557, 455);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 612);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.materialTextBoxSearchProduct);
            this.tabPage1.Controls.Add(this.linkLabelLogout);
            this.tabPage1.Controls.Add(this.labelUsername);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 586);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Товары";
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
            this.materialTextBoxSearchProduct.Location = new System.Drawing.Point(6, 38);
            this.materialTextBoxSearchProduct.MaxLength = 50;
            this.materialTextBoxSearchProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearchProduct.Multiline = false;
            this.materialTextBoxSearchProduct.Name = "materialTextBoxSearchProduct";
            this.materialTextBoxSearchProduct.Size = new System.Drawing.Size(268, 50);
            this.materialTextBoxSearchProduct.TabIndex = 11;
            this.materialTextBoxSearchProduct.Text = "";
            this.materialTextBoxSearchProduct.TrailingIcon = null;
            this.materialTextBoxSearchProduct.TextChanged += new System.EventHandler(this.materialTextBoxSearchProduct_TextChanged);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(315, 39);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(39, 13);
            this.linkLabelLogout.TabIndex = 4;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Выйти";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername.Location = new System.Drawing.Point(315, 16);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(41, 13);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "label3";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название продукта";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.materialTextBoxSearchRatesProducts);
            this.tabPage2.Controls.Add(this.linkLabelLogout2);
            this.tabPage2.Controls.Add(this.labelUsername2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridViewRates);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 586);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialTextBoxSearchRatesProducts
            // 
            this.materialTextBoxSearchRatesProducts.AnimateReadOnly = false;
            this.materialTextBoxSearchRatesProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxSearchRatesProducts.Depth = 0;
            this.materialTextBoxSearchRatesProducts.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxSearchRatesProducts.LeadingIcon = null;
            this.materialTextBoxSearchRatesProducts.Location = new System.Drawing.Point(6, 38);
            this.materialTextBoxSearchRatesProducts.MaxLength = 50;
            this.materialTextBoxSearchRatesProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxSearchRatesProducts.Multiline = false;
            this.materialTextBoxSearchRatesProducts.Name = "materialTextBoxSearchRatesProducts";
            this.materialTextBoxSearchRatesProducts.Size = new System.Drawing.Size(268, 50);
            this.materialTextBoxSearchRatesProducts.TabIndex = 9;
            this.materialTextBoxSearchRatesProducts.Text = "";
            this.materialTextBoxSearchRatesProducts.TrailingIcon = null;
            this.materialTextBoxSearchRatesProducts.TextChanged += new System.EventHandler(this.materialTextBoxSearchRatesProducts_TextChanged);
            // 
            // linkLabelLogout2
            // 
            this.linkLabelLogout2.AutoSize = true;
            this.linkLabelLogout2.Location = new System.Drawing.Point(315, 39);
            this.linkLabelLogout2.Name = "linkLabelLogout2";
            this.linkLabelLogout2.Size = new System.Drawing.Size(39, 13);
            this.linkLabelLogout2.TabIndex = 8;
            this.linkLabelLogout2.TabStop = true;
            this.linkLabelLogout2.Text = "Выйти";
            this.linkLabelLogout2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout2_LinkClicked);
            // 
            // labelUsername2
            // 
            this.labelUsername2.AutoSize = true;
            this.labelUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUsername2.Location = new System.Drawing.Point(315, 16);
            this.labelUsername2.Name = "labelUsername2";
            this.labelUsername2.Size = new System.Drawing.Size(41, 13);
            this.labelUsername2.TabIndex = 7;
            this.labelUsername2.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название продукта";
            // 
            // dataGridViewRates
            // 
            this.dataGridViewRates.AllowUserToAddRows = false;
            this.dataGridViewRates.AllowUserToDeleteRows = false;
            this.dataGridViewRates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRates.Location = new System.Drawing.Point(6, 113);
            this.dataGridViewRates.Name = "dataGridViewRates";
            this.dataGridViewRates.ReadOnly = true;
            this.dataGridViewRates.RowHeadersVisible = false;
            this.dataGridViewRates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRates.Size = new System.Drawing.Size(557, 455);
            this.dataGridViewRates.TabIndex = 4;
            this.dataGridViewRates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRates_CellContentClick);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 692);
            this.Controls.Add(this.tabControl1);
            this.Name = "UserPanel";
            this.Text = "userPanel";
            this.Load += new System.EventHandler(this.UserPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewRates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUsername2;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.LinkLabel linkLabelLogout2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchProduct;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxSearchRatesProducts;
    }
}