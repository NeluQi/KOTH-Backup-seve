namespace MultiUser_Steam
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AddSteam = new System.Windows.Forms.Button();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goSteam = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DellData = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSteam
            // 
            this.AddSteam.BackColor = System.Drawing.Color.White;
            this.AddSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddSteam.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSteam.Location = new System.Drawing.Point(12, 81);
            this.AddSteam.Name = "AddSteam";
            this.AddSteam.Size = new System.Drawing.Size(132, 28);
            this.AddSteam.TabIndex = 0;
            this.AddSteam.Text = "Добавить Аккаунт";
            this.AddSteam.UseVisualStyleBackColor = false;
            this.AddSteam.Click += new System.EventHandler(this.AddSteam_Click);
            // 
            // textLogin
            // 
            this.textLogin.Location = new System.Drawing.Point(110, 12);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(119, 20);
            this.textLogin.TabIndex = 4;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(110, 42);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(119, 20);
            this.textPass.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.Password,
            this.goSteam,
            this.DellData});
            this.dataGridView1.Location = new System.Drawing.Point(1, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 252);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // login
            // 
            this.login.HeaderText = "Login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Пароль";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // goSteam
            // 
            this.goSteam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.goSteam.HeaderText = "Вход";
            this.goSteam.Name = "goSteam";
            this.goSteam.ReadOnly = true;
            this.goSteam.Text = "Войти";
            this.goSteam.ToolTipText = "Войти";
            this.goSteam.UseColumnTextForButtonValue = true;
            // 
            // DellData
            // 
            this.DellData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DellData.HeaderText = "Удалить";
            this.DellData.Name = "DellData";
            this.DellData.ReadOnly = true;
            this.DellData.Text = "Удалить";
            this.DellData.ToolTipText = "Редактирование";
            this.DellData.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.AddSteam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiUser Steam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSteam;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn goSteam;
        private System.Windows.Forms.DataGridViewButtonColumn DellData;
    }
}

