namespace Love
{
    using Love.DB;
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAnk = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anketaShownBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anketaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFilter = new System.Windows.Forms.Button();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.cityBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxSport = new System.Windows.Forms.CheckBox();
            this.comboBoxPol = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelPol = new System.Windows.Forms.Label();
            this.checkBoxTrav = new System.Windows.Forms.CheckBox();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.checkBoxShop = new System.Windows.Forms.CheckBox();
            this.groupBoxUvl = new System.Windows.Forms.GroupBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.anketaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.anketaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowTheAnk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaShownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            this.groupBoxUvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAnk
            // 
            this.dataGridViewAnk.AllowUserToAddRows = false;
            this.dataGridViewAnk.AllowUserToDeleteRows = false;
            this.dataGridViewAnk.AutoGenerateColumns = false;
            this.dataGridViewAnk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAnk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.Age,
            this.polDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.City});
            this.dataGridViewAnk.DataSource = this.anketaShownBindingSource;
            this.dataGridViewAnk.Location = new System.Drawing.Point(23, 41);
            this.dataGridViewAnk.Name = "dataGridViewAnk";
            this.dataGridViewAnk.ReadOnly = true;
            this.dataGridViewAnk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnk.Size = new System.Drawing.Size(445, 277);
            this.dataGridViewAnk.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "Pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.ReadOnly = true;
            this.polDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // anketaShownBindingSource
            // 
            this.anketaShownBindingSource.DataSource = typeof(Love.DB.AnketaShown);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            // 
            // anketaBindingSource
            // 
            this.anketaBindingSource.DataMember = "Anketa";
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(249, 397);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(75, 23);
            this.buttonFilter.TabIndex = 1;
            this.buttonFilter.Text = "Найти";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DataSource = this.cityBindingSource1;
            this.comboBoxCity.DisplayMember = "CityName";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(66, 351);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 2;
            this.comboBoxCity.ValueMember = "Id";
            // 
            // cityBindingSource1
            // 
            this.cityBindingSource1.DataSource = typeof(Love.DB.City);
            // 
            // checkBoxSport
            // 
            this.checkBoxSport.AutoSize = true;
            this.checkBoxSport.Location = new System.Drawing.Point(6, 19);
            this.checkBoxSport.Name = "checkBoxSport";
            this.checkBoxSport.Size = new System.Drawing.Size(56, 17);
            this.checkBoxSport.TabIndex = 3;
            this.checkBoxSport.Text = "Спорт";
            this.checkBoxSport.UseVisualStyleBackColor = true;
            // 
            // comboBoxPol
            // 
            this.comboBoxPol.FormattingEnabled = true;
            this.comboBoxPol.Items.AddRange(new object[] {
            "m",
            "f"});
            this.comboBoxPol.Location = new System.Drawing.Point(239, 351);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(51, 21);
            this.comboBoxPol.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(20, 354);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 13);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Город:";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(203, 354);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(30, 13);
            this.labelPol.TabIndex = 6;
            this.labelPol.Text = "Пол:";
            // 
            // checkBoxTrav
            // 
            this.checkBoxTrav.AutoSize = true;
            this.checkBoxTrav.Location = new System.Drawing.Point(92, 19);
            this.checkBoxTrav.Name = "checkBoxTrav";
            this.checkBoxTrav.Size = new System.Drawing.Size(93, 17);
            this.checkBoxTrav.TabIndex = 7;
            this.checkBoxTrav.Text = "Путешествия";
            this.checkBoxTrav.UseVisualStyleBackColor = true;
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(6, 43);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(40, 17);
            this.checkBoxTV.TabIndex = 8;
            this.checkBoxTV.Text = "TV";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxShop
            // 
            this.checkBoxShop.AutoSize = true;
            this.checkBoxShop.Location = new System.Drawing.Point(92, 42);
            this.checkBoxShop.Name = "checkBoxShop";
            this.checkBoxShop.Size = new System.Drawing.Size(70, 17);
            this.checkBoxShop.TabIndex = 9;
            this.checkBoxShop.Text = "Шоппинг";
            this.checkBoxShop.UseVisualStyleBackColor = true;
            // 
            // groupBoxUvl
            // 
            this.groupBoxUvl.Controls.Add(this.checkBoxSport);
            this.groupBoxUvl.Controls.Add(this.checkBoxShop);
            this.groupBoxUvl.Controls.Add(this.checkBoxTrav);
            this.groupBoxUvl.Controls.Add(this.checkBoxTV);
            this.groupBoxUvl.Location = new System.Drawing.Point(23, 378);
            this.groupBoxUvl.Name = "groupBoxUvl";
            this.groupBoxUvl.Size = new System.Drawing.Size(200, 73);
            this.groupBoxUvl.TabIndex = 10;
            this.groupBoxUvl.TabStop = false;
            this.groupBoxUvl.Text = "Увлечения";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(339, 397);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(118, 23);
            this.buttonShowAll.TabIndex = 11;
            this.buttonShowAll.Text = "Отобразить Все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(329, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(139, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить Анкету";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(366, 351);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownAge.TabIndex = 13;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(305, 354);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 14;
            this.labelAge.Text = "Возраст:";
            // 
            // anketaBindingSource2
            // 
            this.anketaBindingSource2.DataSource = typeof(Love.DB.Anketa);
            // 
            // anketaBindingSource1
            // 
            this.anketaBindingSource1.DataSource = typeof(Love.DB.Anketa);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(23, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 23);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить Анкету";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowTheAnk
            // 
            this.buttonShowTheAnk.Location = new System.Drawing.Point(179, 12);
            this.buttonShowTheAnk.Name = "buttonShowTheAnk";
            this.buttonShowTheAnk.Size = new System.Drawing.Size(139, 23);
            this.buttonShowTheAnk.TabIndex = 16;
            this.buttonShowTheAnk.Text = "Посмотреть Анкету";
            this.buttonShowTheAnk.UseVisualStyleBackColor = true;
            this.buttonShowTheAnk.Click += new System.EventHandler(this.buttonShowTheAnk_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 474);
            this.Controls.Add(this.buttonShowTheAnk);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.groupBoxUvl);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.comboBoxPol);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.dataGridViewAnk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Служба Знакомств";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaShownBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).EndInit();
            this.groupBoxUvl.ResumeLayout(false);
            this.groupBoxUvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAnk;
        private System.Windows.Forms.BindingSource anketaBindingSource;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxSport;
        private System.Windows.Forms.ComboBox comboBoxPol;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.CheckBox checkBoxTrav;
        private System.Windows.Forms.CheckBox checkBoxTV;
        private System.Windows.Forms.CheckBox checkBoxShop;
        private System.Windows.Forms.GroupBox groupBoxUvl;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource anketaBindingSource1;
        private System.Windows.Forms.BindingSource cityBindingSource1;
        private System.Windows.Forms.BindingSource anketaBindingSource2;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn polDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.BindingSource anketaShownBindingSource;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonShowTheAnk;
        public System.Windows.Forms.ComboBox comboBoxCity;
    }
}

