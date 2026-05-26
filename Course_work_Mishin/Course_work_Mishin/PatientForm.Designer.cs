namespace Course_work_Mishin
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            label1 = new System.Windows.Forms.Label();
            txtFullName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            numAge = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            cmbGender = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            txtDisease = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            cmbSeverity = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            numDuration = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            txtDepartment = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label1.Location = new System.Drawing.Point(12, 104);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 20);
            label1.TabIndex = 0;
            label1.Text = "ФИО пациента:";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtFullName.BackColor = System.Drawing.Color.WhiteSmoke;
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFullName.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            txtFullName.Location = new System.Drawing.Point(189, 97);
            txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(230, 27);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label2.Location = new System.Drawing.Point(12, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(157, 20);
            label2.TabIndex = 2;
            label2.Text = "Возраст пациента:";
            // 
            // numAge
            // 
            numAge.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            numAge.BackColor = System.Drawing.Color.WhiteSmoke;
            numAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numAge.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            numAge.Location = new System.Drawing.Point(189, 139);
            numAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numAge.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            numAge.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAge.Name = "numAge";
            numAge.Size = new System.Drawing.Size(230, 27);
            numAge.TabIndex = 3;
            numAge.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label3.Location = new System.Drawing.Point(12, 188);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(126, 20);
            label3.TabIndex = 4;
            label3.Text = "Пол пациента:";
            // 
            // cmbGender
            // 
            cmbGender.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            cmbGender.BackColor = System.Drawing.Color.WhiteSmoke;
            cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Мужской", "Женский" });
            cmbGender.Location = new System.Drawing.Point(189, 182);
            cmbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new System.Drawing.Size(230, 26);
            cmbGender.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label4.Location = new System.Drawing.Point(12, 235);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(80, 20);
            label4.TabIndex = 6;
            label4.Text = "Диагноз:";
            // 
            // txtDisease
            // 
            txtDisease.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtDisease.BackColor = System.Drawing.Color.WhiteSmoke;
            txtDisease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDisease.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            txtDisease.Location = new System.Drawing.Point(189, 228);
            txtDisease.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDisease.Name = "txtDisease";
            txtDisease.Size = new System.Drawing.Size(230, 27);
            txtDisease.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label5.Location = new System.Drawing.Point(12, 280);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 20);
            label5.TabIndex = 8;
            label5.Text = "Тяжесть:";
            // 
            // cmbSeverity
            // 
            cmbSeverity.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            cmbSeverity.BackColor = System.Drawing.Color.WhiteSmoke;
            cmbSeverity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSeverity.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            cmbSeverity.FormattingEnabled = true;
            cmbSeverity.Items.AddRange(new object[] { "Легкая", "Средняя", "Тяжелая" });
            cmbSeverity.Location = new System.Drawing.Point(189, 272);
            cmbSeverity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbSeverity.Name = "cmbSeverity";
            cmbSeverity.Size = new System.Drawing.Size(230, 28);
            cmbSeverity.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label6.Location = new System.Drawing.Point(12, 325);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 20);
            label6.TabIndex = 10;
            label6.Text = "Длительность:";
            // 
            // numDuration
            // 
            numDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            numDuration.BackColor = System.Drawing.Color.WhiteSmoke;
            numDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            numDuration.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            numDuration.Location = new System.Drawing.Point(189, 318);
            numDuration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            numDuration.Maximum = new decimal(new int[] { 365, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new System.Drawing.Size(230, 27);
            numDuration.TabIndex = 11;
            numDuration.Value = new decimal(new int[] { 7, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label7.Location = new System.Drawing.Point(12, 367);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(100, 20);
            label7.TabIndex = 12;
            label7.Text = "Отделение:";
            // 
            // txtDepartment
            // 
            txtDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            txtDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDepartment.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            txtDepartment.Location = new System.Drawing.Point(189, 360);
            txtDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new System.Drawing.Size(230, 27);
            txtDepartment.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnSave.BackColor = System.Drawing.Color.LightGray;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnSave.ForeColor = System.Drawing.Color.Black;
            btnSave.Location = new System.Drawing.Point(8, 459);
            btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(120, 28);
            btnSave.TabIndex = 14;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
            btnCancel.BackColor = System.Drawing.Color.LightGray;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("JetBrains Mono", 10.199999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            btnCancel.ForeColor = System.Drawing.Color.Black;
            btnCancel.Location = new System.Drawing.Point(299, 459);
            btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 28);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)204));
            label8.Location = new System.Drawing.Point(12, 9);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(411, 23);
            label8.TabIndex = 16;
            label8.Text = "Заполните поля для добавления пациента";
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.WhiteSmoke;
            ClientSize = new System.Drawing.Size(446, 500);
            Controls.Add(label8);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtDepartment);
            Controls.Add(label7);
            Controls.Add(numDuration);
            Controls.Add(label6);
            Controls.Add(cmbSeverity);
            Controls.Add(label5);
            Controls.Add(txtDisease);
            Controls.Add(label4);
            Controls.Add(cmbGender);
            Controls.Add(label3);
            Controls.Add(numAge);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Icon = ((System.Drawing.Icon)resources.GetObject("$this.Icon"));
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Создать пациента";
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSeverity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
    }
}
