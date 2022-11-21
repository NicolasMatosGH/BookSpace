namespace BookSpace
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabpagePrincipal = new System.Windows.Forms.TabPage();
            this.tabpageAuthor = new System.Windows.Forms.TabPage();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnAuthorSearch = new System.Windows.Forms.Button();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.textAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.tabPagePublishingCompany = new System.Windows.Forms.TabPage();
            this.groupBoxSearchPublishingCompany = new System.Windows.Forms.GroupBox();
            this.lblPublishingCompanyNameSearch = new System.Windows.Forms.Label();
            this.textBoxPublishingCompanyNameSearch = new System.Windows.Forms.TextBox();
            this.btnPublingCompanySearch = new System.Windows.Forms.Button();
            this.pnlPublishingCompany = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPrincipal.SuspendLayout();
            this.tabpageAuthor.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.tabPagePublishingCompany.SuspendLayout();
            this.groupBoxSearchPublishingCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Controls.Add(this.tabpagePrincipal);
            this.tabPrincipal.Controls.Add(this.tabpageAuthor);
            this.tabPrincipal.Controls.Add(this.tabPagePublishingCompany);
            this.tabPrincipal.Controls.Add(this.tabPageTheme);
            this.tabPrincipal.Controls.Add(this.tabPageBook);
            this.tabPrincipal.Controls.Add(this.tabPageClient);
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1214, 711);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabpagePrincipal
            // 
            this.tabpagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabpagePrincipal.Name = "tabpagePrincipal";
            this.tabpagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabpagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabpagePrincipal.TabIndex = 0;
            this.tabpagePrincipal.Text = "Principal";
            this.tabpagePrincipal.UseVisualStyleBackColor = true;
            this.tabpagePrincipal.Click += new System.EventHandler(this.tabpagePrincipal_Click);
            // 
            // tabpageAuthor
            // 
            this.tabpageAuthor.Controls.Add(this.pnlAuthor);
            this.tabpageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabpageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabpageAuthor.Name = "tabpageAuthor";
            this.tabpageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabpageAuthor.TabIndex = 1;
            this.tabpageAuthor.Text = "Autores";
            this.tabpageAuthor.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnAuthorSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.textAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1194, 148);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnAuthorSearch
            // 
            this.btnAuthorSearch.BackgroundImage = global::BookSpace.Properties.Resources.Search;
            this.btnAuthorSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAuthorSearch.Location = new System.Drawing.Point(598, 58);
            this.btnAuthorSearch.Name = "btnAuthorSearch";
            this.btnAuthorSearch.Size = new System.Drawing.Size(30, 30);
            this.btnAuthorSearch.TabIndex = 9;
            this.btnAuthorSearch.UseVisualStyleBackColor = true;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(417, 59);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(175, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            this.cmbAuthorNationalitySearch.SelectedIndexChanged += new System.EventHandler(this.cmbAuthorNationalitySearch_SelectedIndexChanged);
            // 
            // textAuthorNameSearch
            // 
            this.textAuthorNameSearch.Location = new System.Drawing.Point(6, 59);
            this.textAuthorNameSearch.Name = "textAuthorNameSearch";
            this.textAuthorNameSearch.Size = new System.Drawing.Size(405, 29);
            this.textAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(417, 35);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 35);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(128, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do Autor";
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 3;
            this.tabPageTheme.Text = "Temas";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1206, 683);
            this.tabPageBook.TabIndex = 4;
            this.tabPageBook.Text = "Livros";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1206, 683);
            this.tabPageClient.TabIndex = 5;
            this.tabPageClient.Text = "Clientes";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlAuthor.Controls.Add(this.btnDeleteAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(6, 160);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1194, 502);
            this.pnlAuthor.TabIndex = 6;
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(0, 123);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1194, 379);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackgroundImage = global::BookSpace.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(6, 3);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = true;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackgroundImage = global::BookSpace.Properties.Resources.Edit;
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.Location = new System.Drawing.Point(74, 3);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackgroundImage = global::BookSpace.Properties.Resources.Delete;
            this.btnDeleteAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(141, 3);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(50, 50);
            this.btnDeleteAuthor.TabIndex = 3;
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            // 
            // tabPagePublishingCompany
            // 
            this.tabPagePublishingCompany.Controls.Add(this.dataGridView1);
            this.tabPagePublishingCompany.Controls.Add(this.pnlPublishingCompany);
            this.tabPagePublishingCompany.Controls.Add(this.groupBoxSearchPublishingCompany);
            this.tabPagePublishingCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPagePublishingCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishingCompany.Name = "tabPagePublishingCompany";
            this.tabPagePublishingCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishingCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishingCompany.TabIndex = 2;
            this.tabPagePublishingCompany.Text = "Editoras";
            this.tabPagePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchPublishingCompany
            // 
            this.groupBoxSearchPublishingCompany.Controls.Add(this.btnPublingCompanySearch);
            this.groupBoxSearchPublishingCompany.Controls.Add(this.textBoxPublishingCompanyNameSearch);
            this.groupBoxSearchPublishingCompany.Controls.Add(this.lblPublishingCompanyNameSearch);
            this.groupBoxSearchPublishingCompany.Location = new System.Drawing.Point(6, 6);
            this.groupBoxSearchPublishingCompany.Name = "groupBoxSearchPublishingCompany";
            this.groupBoxSearchPublishingCompany.Size = new System.Drawing.Size(1194, 148);
            this.groupBoxSearchPublishingCompany.TabIndex = 0;
            this.groupBoxSearchPublishingCompany.TabStop = false;
            this.groupBoxSearchPublishingCompany.Text = "Consulta";
            // 
            // lblPublishingCompanyNameSearch
            // 
            this.lblPublishingCompanyNameSearch.AutoSize = true;
            this.lblPublishingCompanyNameSearch.Location = new System.Drawing.Point(6, 31);
            this.lblPublishingCompanyNameSearch.Name = "lblPublishingCompanyNameSearch";
            this.lblPublishingCompanyNameSearch.Size = new System.Drawing.Size(139, 21);
            this.lblPublishingCompanyNameSearch.TabIndex = 0;
            this.lblPublishingCompanyNameSearch.Text = "Nome da Editora";
            this.lblPublishingCompanyNameSearch.Click += new System.EventHandler(this.lblPublishingCompanyNameSearch_Click);
            // 
            // textBoxPublishingCompanyNameSearch
            // 
            this.textBoxPublishingCompanyNameSearch.Location = new System.Drawing.Point(6, 55);
            this.textBoxPublishingCompanyNameSearch.Name = "textBoxPublishingCompanyNameSearch";
            this.textBoxPublishingCompanyNameSearch.Size = new System.Drawing.Size(361, 29);
            this.textBoxPublishingCompanyNameSearch.TabIndex = 1;
            // 
            // btnPublingCompanySearch
            // 
            this.btnPublingCompanySearch.BackgroundImage = global::BookSpace.Properties.Resources.Search;
            this.btnPublingCompanySearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPublingCompanySearch.Location = new System.Drawing.Point(373, 55);
            this.btnPublingCompanySearch.Name = "btnPublingCompanySearch";
            this.btnPublingCompanySearch.Size = new System.Drawing.Size(30, 30);
            this.btnPublingCompanySearch.TabIndex = 10;
            this.btnPublingCompanySearch.UseVisualStyleBackColor = true;
            // 
            // pnlPublishingCompany
            // 
            this.pnlPublishingCompany.Location = new System.Drawing.Point(6, 160);
            this.pnlPublishingCompany.Name = "pnlPublishingCompany";
            this.pnlPublishingCompany.Size = new System.Drawing.Size(1194, 124);
            this.pnlPublishingCompany.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1194, 381);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabPrincipal.ResumeLayout(false);
            this.tabpageAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.pnlAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.tabPagePublishingCompany.ResumeLayout(false);
            this.groupBoxSearchPublishingCompany.ResumeLayout(false);
            this.groupBoxSearchPublishingCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tabPrincipal;
        private TabPage tabpagePrincipal;
        private TabPage tabpageAuthor;
        private StatusStrip statusStrip1;
        private GroupBox groupBoxSearchAuthor;
        private Button btnAuthorSearch;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox textAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private TabPage tabPageTheme;
        private TabPage tabPageBook;
        private TabPage tabPageClient;
        private Panel pnlAuthor;
        private Button btnDeleteAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
        private TabPage tabPagePublishingCompany;
        private GroupBox groupBoxSearchPublishingCompany;
        private TextBox textBoxPublishingCompanyNameSearch;
        private Label lblPublishingCompanyNameSearch;
        private Button btnPublingCompanySearch;
        private DataGridView dataGridView1;
        private Panel pnlPublishingCompany;
    }
}