namespace syap2
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbFaculty = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.lbEq = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.следующийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предыдущиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бакалаврToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.магистрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bSave = new System.Windows.Forms.Button();
            this.lbDiploma = new System.Windows.Forms.Label();
            this.tbDiploma = new System.Windows.Forms.TextBox();
            this.bUpgrade = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.Enabled = false;
            this.tbName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(189, 59);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(125, 23);
            this.tbName.TabIndex = 0;
            // 
            // tbSurname
            // 
            this.tbSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSurname.BackColor = System.Drawing.Color.White;
            this.tbSurname.Enabled = false;
            this.tbSurname.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tbSurname.ForeColor = System.Drawing.Color.Black;
            this.tbSurname.Location = new System.Drawing.Point(189, 93);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(125, 23);
            this.tbSurname.TabIndex = 1;
            // 
            // tbFaculty
            // 
            this.tbFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbFaculty.BackColor = System.Drawing.Color.White;
            this.tbFaculty.Enabled = false;
            this.tbFaculty.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tbFaculty.ForeColor = System.Drawing.Color.Black;
            this.tbFaculty.Location = new System.Drawing.Point(189, 127);
            this.tbFaculty.Name = "tbFaculty";
            this.tbFaculty.Size = new System.Drawing.Size(125, 23);
            this.tbFaculty.TabIndex = 2;
            // 
            // lbName
            // 
            this.lbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbName.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbName.Location = new System.Drawing.Point(106, 59);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 23);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Имя";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSurname
            // 
            this.lbSurname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSurname.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSurname.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbSurname.Location = new System.Drawing.Point(106, 93);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(67, 23);
            this.lbSurname.TabIndex = 4;
            this.lbSurname.Text = "Фамилия";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFaculty
            // 
            this.lbFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbFaculty.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbFaculty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFaculty.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbFaculty.Location = new System.Drawing.Point(106, 127);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(67, 23);
            this.lbFaculty.TabIndex = 5;
            this.lbFaculty.Text = "Факультет";
            this.lbFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bPrevious.BackColor = System.Drawing.SystemColors.Control;
            this.bPrevious.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.bPrevious.Location = new System.Drawing.Point(105, 247);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(91, 32);
            this.bPrevious.TabIndex = 6;
            this.bPrevious.Text = "Предыдущий";
            this.bPrevious.UseVisualStyleBackColor = false;
            this.bPrevious.Click += new System.EventHandler(this.bPrevious_Click);
            // 
            // bNext
            // 
            this.bNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bNext.BackColor = System.Drawing.SystemColors.Control;
            this.bNext.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.bNext.Location = new System.Drawing.Point(283, 247);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(91, 32);
            this.bNext.TabIndex = 7;
            this.bNext.Text = "Следующий";
            this.bNext.UseVisualStyleBackColor = false;
            this.bNext.Click += new System.EventHandler(this.bNext_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbSearch.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbSearch.Location = new System.Drawing.Point(26, 297);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(67, 20);
            this.lbSearch.TabIndex = 8;
            this.lbSearch.Text = "Поиск";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Enabled = false;
            this.cbSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.cbSearch.Location = new System.Drawing.Point(26, 320);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(99, 23);
            this.cbSearch.TabIndex = 9;
            this.cbSearch.SelectedIndexChanged += new System.EventHandler(this.cbSearch_SelectedIndexChanged);
            // 
            // lbEq
            // 
            this.lbEq.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbEq.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbEq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbEq.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbEq.Location = new System.Drawing.Point(131, 323);
            this.lbEq.Name = "lbEq";
            this.lbEq.Size = new System.Drawing.Size(27, 20);
            this.lbEq.TabIndex = 10;
            this.lbEq.Text = "=";
            this.lbEq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Enabled = false;
            this.tbSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tbSearch.Location = new System.Drawing.Point(164, 320);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(110, 23);
            this.tbSearch.TabIndex = 11;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.PaleVioletRed;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.студентыToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(479, 24);
            this.menu.TabIndex = 12;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предыдущиToolStripMenuItem,
            this.следующийToolStripMenuItem});
            this.просмотрToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // следующийToolStripMenuItem
            // 
            this.следующийToolStripMenuItem.Name = "следующийToolStripMenuItem";
            this.следующийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.следующийToolStripMenuItem.Text = "Следующий";
            this.следующийToolStripMenuItem.Click += new System.EventHandler(this.следующийToolStripMenuItem_Click);
            // 
            // предыдущиToolStripMenuItem
            // 
            this.предыдущиToolStripMenuItem.Name = "предыдущиToolStripMenuItem";
            this.предыдущиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.предыдущиToolStripMenuItem.Text = "Предыдущий";
            this.предыдущиToolStripMenuItem.Click += new System.EventHandler(this.предыдущиToolStripMenuItem_Click);
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem1});
            this.студентыToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.бакалаврToolStripMenuItem,
            this.магистрToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // бакалаврToolStripMenuItem
            // 
            this.бакалаврToolStripMenuItem.Name = "бакалаврToolStripMenuItem";
            this.бакалаврToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.бакалаврToolStripMenuItem.Text = "Бакалавр";
            this.бакалаврToolStripMenuItem.Click += new System.EventHandler(this.бакалаврToolStripMenuItem_Click);
            // 
            // магистрToolStripMenuItem
            // 
            this.магистрToolStripMenuItem.Name = "магистрToolStripMenuItem";
            this.магистрToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.магистрToolStripMenuItem.Text = "Магистр";
            this.магистрToolStripMenuItem.Click += new System.EventHandler(this.магистрToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem1
            // 
            this.удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            this.удалитьToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.удалитьToolStripMenuItem1.Text = "Удалить";
            this.удалитьToolStripMenuItem1.Click += new System.EventHandler(this.удалитьToolStripMenuItem1_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSave.BackColor = System.Drawing.SystemColors.Control;
            this.bSave.Enabled = false;
            this.bSave.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.bSave.Location = new System.Drawing.Point(202, 205);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 13;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // lbDiploma
            // 
            this.lbDiploma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbDiploma.BackColor = System.Drawing.Color.PaleVioletRed;
            this.lbDiploma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDiploma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.lbDiploma.Location = new System.Drawing.Point(106, 161);
            this.lbDiploma.Name = "lbDiploma";
            this.lbDiploma.Size = new System.Drawing.Size(67, 23);
            this.lbDiploma.TabIndex = 15;
            this.lbDiploma.Text = "Диплом";
            this.lbDiploma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDiploma.Visible = false;
            // 
            // tbDiploma
            // 
            this.tbDiploma.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbDiploma.BackColor = System.Drawing.Color.White;
            this.tbDiploma.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.tbDiploma.ForeColor = System.Drawing.Color.Black;
            this.tbDiploma.Location = new System.Drawing.Point(189, 161);
            this.tbDiploma.Name = "tbDiploma";
            this.tbDiploma.Size = new System.Drawing.Size(125, 23);
            this.tbDiploma.TabIndex = 14;
            this.tbDiploma.Visible = false;
            // 
            // bUpgrade
            // 
            this.bUpgrade.BackColor = System.Drawing.SystemColors.Control;
            this.bUpgrade.Location = new System.Drawing.Point(202, 242);
            this.bUpgrade.Name = "bUpgrade";
            this.bUpgrade.Size = new System.Drawing.Size(75, 42);
            this.bUpgrade.TabIndex = 16;
            this.bUpgrade.Text = "Сделать магистром";
            this.bUpgrade.UseVisualStyleBackColor = false;
            this.bUpgrade.Visible = false;
            this.bUpgrade.Click += new System.EventHandler(this.bUpgrade_Click);
            // 
            // bSearch
            // 
            this.bSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bSearch.BackColor = System.Drawing.SystemColors.Control;
            this.bSearch.Enabled = false;
            this.bSearch.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.bSearch.Location = new System.Drawing.Point(280, 319);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 23);
            this.bSearch.TabIndex = 17;
            this.bSearch.Text = "Найти";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bCancel.BackColor = System.Drawing.SystemColors.Control;
            this.bCancel.Enabled = false;
            this.bCancel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F);
            this.bCancel.Location = new System.Drawing.Point(361, 319);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 18;
            this.bCancel.Text = "Отменить";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(479, 369);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bUpgrade);
            this.Controls.Add(this.lbDiploma);
            this.Controls.Add(this.tbDiploma);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbEq);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.Controls.Add(this.lbFaculty);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbFaculty);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "Студенты";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbFaculty;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.Button bPrevious;
        private System.Windows.Forms.Button bNext;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Label lbEq;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem следующийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предыдущиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem1;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Label lbDiploma;
        private System.Windows.Forms.TextBox tbDiploma;
        private System.Windows.Forms.ToolStripMenuItem бакалаврToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem магистрToolStripMenuItem;
        private System.Windows.Forms.Button bUpgrade;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bCancel;
    }
}

