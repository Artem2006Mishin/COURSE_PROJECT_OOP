namespace Course_work_in_OOP_Lipatov
{
    partial class DataBaseManagerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseManagerForm));
            listBoxDatabases = new System.Windows.Forms.ListBox();
            txtNewDbName = new System.Windows.Forms.TextBox();
            btnCreate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnSwitch = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnBack = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // listBoxDatabases
            // 
            listBoxDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            listBoxDatabases.BackColor = System.Drawing.Color.LightGray;
            listBoxDatabases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            listBoxDatabases.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            listBoxDatabases.FormattingEnabled = true;
            listBoxDatabases.Location = new System.Drawing.Point(38, 40);
            listBoxDatabases.Margin = new System.Windows.Forms.Padding(4);
            listBoxDatabases.Name = "listBoxDatabases";
            listBoxDatabases.Size = new System.Drawing.Size(292, 146);
            listBoxDatabases.TabIndex = 1;
            // 
            // txtNewDbName
            // 
            txtNewDbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
            txtNewDbName.BackColor = System.Drawing.Color.WhiteSmoke;
            txtNewDbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtNewDbName.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            txtNewDbName.Location = new System.Drawing.Point(455, 38);
            txtNewDbName.Margin = new System.Windows.Forms.Padding(4);
            txtNewDbName.Name = "txtNewDbName";
            txtNewDbName.Size = new System.Drawing.Size(233, 30);
            txtNewDbName.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = System.Drawing.Color.LightGray;
            btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreate.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnCreate.ForeColor = System.Drawing.Color.Black;
            btnCreate.Location = new System.Drawing.Point(696, 37);
            btnCreate.Margin = new System.Windows.Forms.Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new System.Drawing.Size(214, 30);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Создать";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnDelete.BackColor = System.Drawing.Color.Red;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 10.199999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnDelete.ForeColor = System.Drawing.Color.Black;
            btnDelete.Location = new System.Drawing.Point(38, 270);
            btnDelete.Margin = new System.Windows.Forms.Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(292, 27);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить базу данных";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSwitch
            // 
            btnSwitch.BackColor = System.Drawing.Color.LightGray;
            btnSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSwitch.FlatAppearance.BorderSize = 0;
            btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSwitch.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnSwitch.ForeColor = System.Drawing.Color.Black;
            btnSwitch.Location = new System.Drawing.Point(38, 200);
            btnSwitch.Margin = new System.Windows.Forms.Padding(4);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new System.Drawing.Size(292, 27);
            btnSwitch.TabIndex = 7;
            btnSwitch.Text = "Подключиться к базе данных";
            btnSwitch.UseVisualStyleBackColor = false;
            btnSwitch.Click += BtnSwitch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnRefresh.BackColor = System.Drawing.Color.LightGray;
            btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnRefresh.ForeColor = System.Drawing.Color.Black;
            btnRefresh.Location = new System.Drawing.Point(38, 235);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(292, 27);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Загрузить список баз данных";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnExit.BackColor = System.Drawing.Color.LightGray;
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnExit.ForeColor = System.Drawing.Color.Black;
            btnExit.Location = new System.Drawing.Point(696, 233);
            btnExit.Margin = new System.Windows.Forms.Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(214, 27);
            btnExit.TabIndex = 10;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += BtnExit_Click;
            // 
            // btnBack
            // 
            btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnBack.BackColor = System.Drawing.Color.LightGray;
            btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBack.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnBack.ForeColor = System.Drawing.Color.Black;
            btnBack.Location = new System.Drawing.Point(696, 268);
            btnBack.Margin = new System.Windows.Forms.Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(214, 27);
            btnBack.TabIndex = 11;
            btnBack.Text = "Назад";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label2.Location = new System.Drawing.Point(354, 8);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(267, 24);
            label2.TabIndex = 4;
            label2.Text = "Создать новую базу данных";
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label3.Location = new System.Drawing.Point(354, 40);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 21);
            label3.TabIndex = 9;
            label3.Text = "Имя БД:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label1.Location = new System.Drawing.Point(38, 8);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(292, 24);
            label1.TabIndex = 2;
            label1.Text = "Список доступных баз данных";
            // 
            // DataBaseManagerForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(923, 307);
            Controls.Add(btnBack);
            Controls.Add(btnExit);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(btnSwitch);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(label2);
            Controls.Add(txtNewDbName);
            Controls.Add(label1);
            Controls.Add(listBoxDatabases);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Управление базами данных";
            FormClosed += DataBaseManagerForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        private bool isNavigatingBack;

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            isNavigatingBack = true;
            Hide();
            using (var authorForm = new AuthorForm())
            {
                authorForm.ShowDialog();
            }
            Close();
        }

        private void DataBaseManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isNavigatingBack && !isClosingAfterSwitch)
            {
                Application.Exit();
            }
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ListBox listBoxDatabases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewDbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
    }
}