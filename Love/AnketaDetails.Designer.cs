namespace Love
{
    partial class AnketaDetails
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.groupBoxUvl = new System.Windows.Forms.GroupBox();
            this.checkBoxSport = new System.Windows.Forms.CheckBox();
            this.checkBoxShop = new System.Windows.Forms.CheckBox();
            this.checkBoxTrav = new System.Windows.Forms.CheckBox();
            this.checkBoxTV = new System.Windows.Forms.CheckBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelPol = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.comboBoxPol = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.groupBoxUvl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(315, 241);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(32, 32);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 1;
            this.labelFIO.Text = "ФИО:";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(91, 29);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(246, 20);
            this.textBoxFIO.TabIndex = 2;
            // 
            // groupBoxUvl
            // 
            this.groupBoxUvl.Controls.Add(this.checkBoxSport);
            this.groupBoxUvl.Controls.Add(this.checkBoxShop);
            this.groupBoxUvl.Controls.Add(this.checkBoxTrav);
            this.groupBoxUvl.Controls.Add(this.checkBoxTV);
            this.groupBoxUvl.Location = new System.Drawing.Point(20, 205);
            this.groupBoxUvl.Name = "groupBoxUvl";
            this.groupBoxUvl.Size = new System.Drawing.Size(200, 73);
            this.groupBoxUvl.TabIndex = 11;
            this.groupBoxUvl.TabStop = false;
            this.groupBoxUvl.Text = "Увлечения";
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
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(17, 143);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(52, 13);
            this.labelAge.TabIndex = 20;
            this.labelAge.Text = "Возраст:";
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(91, 141);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(91, 20);
            this.numericUpDownAge.TabIndex = 19;
            // 
            // labelPol
            // 
            this.labelPol.AutoSize = true;
            this.labelPol.Location = new System.Drawing.Point(39, 104);
            this.labelPol.Name = "labelPol";
            this.labelPol.Size = new System.Drawing.Size(30, 13);
            this.labelPol.TabIndex = 18;
            this.labelPol.Text = "Пол:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(29, 68);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(40, 13);
            this.labelCity.TabIndex = 17;
            this.labelCity.Text = "Город:";
            // 
            // comboBoxPol
            // 
            this.comboBoxPol.FormattingEnabled = true;
            this.comboBoxPol.Items.AddRange(new object[] {
            "m",
            "f"});
            this.comboBoxPol.Location = new System.Drawing.Point(91, 101);
            this.comboBoxPol.Name = "comboBoxPol";
            this.comboBoxPol.Size = new System.Drawing.Size(51, 21);
            this.comboBoxPol.TabIndex = 16;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DisplayMember = "CityName";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(91, 65);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(114, 21);
            this.comboBoxCity.TabIndex = 15;
            this.comboBoxCity.ValueMember = "Id";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(14, 170);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 13);
            this.labelPhone.TabIndex = 21;
            this.labelPhone.Text = "Телефон:";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(91, 167);
            this.maskedTextBoxPhone.Mask = "+79 (99) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(246, 20);
            this.maskedTextBoxPhone.TabIndex = 23;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(234, 242);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 24;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(234, 63);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(133, 23);
            this.buttonAddCity.TabIndex = 25;
            this.buttonAddCity.Text = "Добавить город";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            this.buttonAddCity.Click += new System.EventHandler(this.buttonAddCity_Click);
            // 
            // AnketaDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 304);
            this.Controls.Add(this.buttonAddCity);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.labelPol);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.comboBoxPol);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.groupBoxUvl);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnketaDetails";
            this.Text = "Анкета";
            this.groupBoxUvl.ResumeLayout(false);
            this.groupBoxUvl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.GroupBox groupBoxUvl;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelPol;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.TextBox textBoxFIO;
        public System.Windows.Forms.CheckBox checkBoxSport;
        public System.Windows.Forms.CheckBox checkBoxShop;
        public System.Windows.Forms.CheckBox checkBoxTrav;
        public System.Windows.Forms.CheckBox checkBoxTV;
        public System.Windows.Forms.NumericUpDown numericUpDownAge;
        public System.Windows.Forms.ComboBox comboBoxPol;
        public System.Windows.Forms.ComboBox comboBoxCity;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        public System.Windows.Forms.Button buttonAddCity;
        public System.Windows.Forms.Button buttonCancel;
    }
}