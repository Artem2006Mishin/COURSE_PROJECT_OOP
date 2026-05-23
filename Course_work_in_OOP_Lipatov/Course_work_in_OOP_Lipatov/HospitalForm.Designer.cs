namespace Course_work_in_OOP_Lipatov
{
    partial class HospitalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalForm));
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnAdd = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnClearDatabase = new System.Windows.Forms.Button();
            btnManageDatabases = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            button1.BackColor = System.Drawing.Color.LightGray;
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            button1.ForeColor = System.Drawing.Color.Black;
            button1.Location = new System.Drawing.Point(563, 510);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(470, 32);
            button1.TabIndex = 1;
            button1.Text = "Вернуться на страницу \"информация об авторе\"";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnBack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            dataGridView1.GridColor = System.Drawing.Color.LightGray;
            dataGridView1.Location = new System.Drawing.Point(12, 99);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(1021, 312);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = System.Drawing.Color.LightGray;
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAdd.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnAdd.ForeColor = System.Drawing.Color.Black;
            btnAdd.Location = new System.Drawing.Point(308, 13);
            btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(193, 32);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить пациента";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.LightGray;
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnEdit.ForeColor = System.Drawing.Color.Black;
            btnEdit.Location = new System.Drawing.Point(12, 51);
            btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(290, 30);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Редактировать пациента";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.LightGray;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnDelete.ForeColor = System.Drawing.Color.Black;
            btnDelete.Location = new System.Drawing.Point(308, 51);
            btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(193, 30);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Удалить пациента";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            txtSearch.Location = new System.Drawing.Point(320, 440);
            txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(342, 26);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = System.Drawing.Color.LightGray;
            btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSearch.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnSearch.ForeColor = System.Drawing.Color.Black;
            btnSearch.Location = new System.Drawing.Point(668, 440);
            btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(233, 28);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Найти пациента";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = System.Drawing.Color.LightGray;
            btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExport.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnExport.ForeColor = System.Drawing.Color.Black;
            btnExport.Location = new System.Drawing.Point(532, 49);
            btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(279, 34);
            btnExport.TabIndex = 8;
            btnExport.Text = "Экспорт базы данных (pdf)";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = System.Drawing.Color.LightGray;
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnRefresh.ForeColor = System.Drawing.Color.Black;
            btnRefresh.Location = new System.Drawing.Point(12, 13);
            btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(290, 32);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "Загрузить список пациентов";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnClearDatabase
            // 
            btnClearDatabase.BackColor = System.Drawing.Color.Red;
            btnClearDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClearDatabase.FlatAppearance.BorderSize = 0;
            btnClearDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClearDatabase.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10.199999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnClearDatabase.ForeColor = System.Drawing.Color.Black;
            btnClearDatabase.Location = new System.Drawing.Point(532, 13);
            btnClearDatabase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClearDatabase.Name = "btnClearDatabase";
            btnClearDatabase.Size = new System.Drawing.Size(279, 32);
            btnClearDatabase.TabIndex = 10;
            btnClearDatabase.Text = "Очистить базу данных";
            btnClearDatabase.UseVisualStyleBackColor = false;
            btnClearDatabase.Click += BtnClearDatabase_Click;
            // 
            // btnManageDatabases
            // 
            btnManageDatabases.BackColor = System.Drawing.Color.LightGray;
            btnManageDatabases.Cursor = System.Windows.Forms.Cursors.Hand;
            btnManageDatabases.FlatAppearance.BorderSize = 0;
            btnManageDatabases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnManageDatabases.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnManageDatabases.ForeColor = System.Drawing.Color.Black;
            btnManageDatabases.Location = new System.Drawing.Point(12, 510);
            btnManageDatabases.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnManageDatabases.Name = "btnManageDatabases";
            btnManageDatabases.Size = new System.Drawing.Size(545, 32);
            btnManageDatabases.TabIndex = 12;
            btnManageDatabases.Text = "Вернуться на страницу \"управление базами данных\"";
            btnManageDatabases.UseVisualStyleBackColor = false;
            btnManageDatabases.Click += BtnManageDatabases_Click;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label2.Location = new System.Drawing.Point(12, 440);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(302, 23);
            label2.TabIndex = 13;
            label2.Text = "Найти пациента в базе данных:";
            // 
            // HospitalForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(1068, 555);
            Controls.Add(label2);
            Controls.Add(btnManageDatabases);
            Controls.Add(btnClearDatabase);
            Controls.Add(btnRefresh);
            Controls.Add(btnExport);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Главная форма";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClearDatabase;
        private System.Windows.Forms.Button btnManageDatabases;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeverity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
    }
}