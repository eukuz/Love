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
            this.anketaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.anketaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonShowTheAnk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAgeHigh = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAnk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaShownBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource1)).BeginInit();
            this.groupBoxUvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anketaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeHigh)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.dataGridViewAnk.Location = new System.Drawing.Point(34, 63);
            this.dataGridViewAnk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewAnk.Name = "dataGridViewAnk";
            this.dataGridViewAnk.ReadOnly = true;
            this.dataGridViewAnk.RowHeadersWidth = 62;
            this.dataGridViewAnk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAnk.Size = new System.Drawing.Size(668, 426);
            this.dataGridViewAnk.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fIODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            this.fIODataGridViewTextBoxColumn.ReadOnly = true;
            this.fIODataGridViewTextBoxColumn.Width = 150;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 50;
            // 
            // polDataGridViewTextBoxColumn
            // 
            this.polDataGridViewTextBoxColumn.DataPropertyName = "Pol";
            this.polDataGridViewTextBoxColumn.HeaderText = "Пол";
            this.polDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.polDataGridViewTextBoxColumn.Name = "polDataGridViewTextBoxColumn";
            this.polDataGridViewTextBoxColumn.ReadOnly = true;
            this.polDataGridViewTextBoxColumn.Width = 50;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Город";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 150;
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
            this.buttonFilter.Location = new System.Drawing.Point(374, 611);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(112, 35);
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
            this.comboBoxCity.Location = new System.Drawing.Point(99, 540);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(180, 28);
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
            this.checkBoxSport.Location = new System.Drawing.Point(9, 29);
            this.checkBoxSport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSport.Name = "checkBoxSport";
            this.checkBoxSport.Size = new System.Drawing.Size(82, 24);
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
            this.comboBoxPol.Location = new System.Drawing.Point(358, 540);
            this.comboBoxPol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(74, 28);
            this.comboBoxPol.TabIndex = 4;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(30, 545);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(60, 20);
            this.labelCity.TabIndex = 5;
            this.labelCity.Text = "Город:";
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(304, 545);
            this.labelPol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(44, 20);
            this.labelPol.TabIndex = 6;
            this.labelPol.Text = "Пол:";
            // 
            // checkBoxTrav
            // 
            this.checkBoxTrav.AutoSize = true;
            this.checkBoxTrav.Location = new System.Drawing.Point(138, 29);
            this.checkBoxTrav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTrav.Name = "checkBoxTrav";
            this.checkBoxTrav.Size = new System.Drawing.Size(138, 24);
            this.checkBoxTrav.TabIndex = 7;
            this.checkBoxTrav.Text = "Путешествия";
            this.checkBoxTrav.UseVisualStyleBackColor = true;
            // 
            // checkBoxTV
            // 
            this.checkBoxTV.AutoSize = true;
            this.checkBoxTV.Location = new System.Drawing.Point(9, 66);
            this.checkBoxTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTV.Name = "checkBoxTV";
            this.checkBoxTV.Size = new System.Drawing.Size(55, 24);
            this.checkBoxTV.TabIndex = 8;
            this.checkBoxTV.Text = "TV";
            this.checkBoxTV.UseVisualStyleBackColor = true;
            // 
            // checkBoxShop
            // 
            this.checkBoxShop.AutoSize = true;
            this.checkBoxShop.Location = new System.Drawing.Point(138, 65);
            this.checkBoxShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxShop.Name = "checkBoxShop";
            this.checkBoxShop.Size = new System.Drawing.Size(100, 24);
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
            this.groupBoxUvl.Location = new System.Drawing.Point(34, 582);
            this.groupBoxUvl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUvl.Name = "groupBoxUvl";
            this.groupBoxUvl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxUvl.Size = new System.Drawing.Size(300, 112);
            this.groupBoxUvl.TabIndex = 10;
            this.groupBoxUvl.TabStop = false;
            this.groupBoxUvl.Text = "Увлечения";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Location = new System.Drawing.Point(508, 611);
            this.buttonShowAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(177, 35);
            this.buttonShowAll.TabIndex = 11;
            this.buttonShowAll.Text = "Отобразить Все";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(494, 18);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(208, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить Анкету";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(51, 27);
            this.numericUpDownAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownAge.TabIndex = 13;
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
            this.buttonDelete.Location = new System.Drawing.Point(34, 18);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(208, 35);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Удалить Анкету";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonShowTheAnk
            // 
            this.buttonShowTheAnk.Location = new System.Drawing.Point(268, 18);
            this.buttonShowTheAnk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowTheAnk.Name = "buttonShowTheAnk";
            this.buttonShowTheAnk.Size = new System.Drawing.Size(208, 35);
            this.buttonShowTheAnk.TabIndex = 16;
            this.buttonShowTheAnk.Text = "Посмотреть Анкету";
            this.buttonShowTheAnk.UseVisualStyleBackColor = true;
            this.buttonShowTheAnk.Click += new System.EventHandler(this.buttonShowTheAnk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "от:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "до:";
            // 
            // numericUpDownAgeHigh
            // 
            this.numericUpDownAgeHigh.Location = new System.Drawing.Point(173, 28);
            this.numericUpDownAgeHigh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAgeHigh.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAgeHigh.Name = "numericUpDownAgeHigh";
            this.numericUpDownAgeHigh.Size = new System.Drawing.Size(83, 26);
            this.numericUpDownAgeHigh.TabIndex = 18;
            this.numericUpDownAgeHigh.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownAgeHigh);
            this.groupBox1.Location = new System.Drawing.Point(472, 524);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 65);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возраст";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonShowTheAnk);
            this.Controls.Add(this.buttonDelete);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgeHigh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAgeHigh;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

