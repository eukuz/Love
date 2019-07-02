using Love.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        BindingList<Anketa> Ankets = new BindingList<Anketa>();
        BindingList<AnketaShown> AnketsShown = new BindingList<AnketaShown>();
        public BindingList<City> Cities = new BindingList<City>();

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "loveDBDataSet.City". При необходимости она может быть перемещена или удалена.
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "loveDBDataSet.Anketa". При необходимости она может быть перемещена или удалена.
            //this.anketaTableAdapter.Fill(this.loveDBDataSet.Anketa);


            FillTable();
            ShowAll();

            
        }

        public void FillTable()
        {
            using (LoveDataContext db = new LoveDataContext())
            {
                Ankets = new BindingList<Anketa>(db.Anketa.Include(a => a.Uvlechenia).ToList());
                Cities = new BindingList<City>(db.City.ToList());
            }
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (comboBoxPol.SelectedItem!= null)
            {
                string city = (comboBoxCity.SelectedItem as City).CityName;
                ShowAll();
                AnketsShown = new BindingList<AnketaShown>(AnketsShown
                    .Where(a =>
                    a.City == city &&
                    a.Age >= numericUpDownAge.Value &&
                    a.Pol == comboBoxPol.SelectedItem.ToString() &&
                    (checkBoxSport.Checked == true && a.Uvlechenia.Sport.Value == checkBoxSport.Checked ||
                     checkBoxTrav.Checked == true && a.Uvlechenia.Travelling.Value == checkBoxTrav.Checked ||
                     checkBoxTV.Checked == true && a.Uvlechenia.TV.Value == checkBoxTV.Checked ||
                     checkBoxShop.Checked == true && a.Uvlechenia.Shopping.Value == checkBoxShop.Checked
                    )
                    ).ToList());

                dataGridViewAnk.DataSource = AnketsShown;
            }
            else
            {
                MessageBox.Show("Выберите пол");
            }
        }

        private void ShowAll()
        {
            AnketsShown = new BindingList<AnketaShown>();

            foreach (Anketa anketa in Ankets)
            {
                AnketsShown.Add(new AnketaShown
                {
                    Age = anketa.Age,
                    City = anketa.City.CityName,
                    FIO = anketa.FIO,
                    Id = anketa.Id,
                    Phone = anketa.Phone,
                    Pol = anketa.Pol,
                    Uvlechenia = anketa.Uvlechenia
                });
            }

            dataGridViewAnk.DataSource = AnketsShown;
            comboBoxCity.DataSource = Cities;
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (LoveDataContext db = new LoveDataContext())
            {
                AnketaDetails anketaDetails = new AnketaDetails(Cities);
                anketaDetails.comboBoxCity.DataSource = Cities;
                DialogResult dialogResult = anketaDetails.ShowDialog();

                if (dialogResult != DialogResult.OK)
                    return;

                string city = (anketaDetails.comboBoxCity.SelectedItem as City).CityName;



                Anketa anketa = new Anketa
                {
                    FIO = anketaDetails.textBoxFIO.Text,
                    Pol = anketaDetails.comboBoxPol.SelectedItem.ToString(),
                    Uvlechenia = new Uvlechenia
                    {
                        Sport = anketaDetails.checkBoxSport.Checked,
                        Travelling = anketaDetails.checkBoxTrav.Checked,
                        TV = anketaDetails.checkBoxTV.Checked,
                        Shopping = anketaDetails.checkBoxShop.Checked
                    },
                    Phone = anketaDetails.maskedTextBoxPhone.Text.ToString(),
                    City = db.City.Where(c => c.CityName == city).FirstOrDefault(),
                    Age = (int)anketaDetails.numericUpDownAge.Value
                };

                db.Anketa.Add(anketa);
                db.SaveChanges();

                FillTable();
                ShowAll();
            }


        }

        private void buttonShowTheAnk_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку!");
                return;
            }

            int rowIndex = dataGridViewAnk.SelectedRows[0].Index;


            using (LoveDataContext db = new LoveDataContext())
            {
                AnketaDetails anketaDetails = new AnketaDetails(Cities);
                anketaDetails.comboBoxCity.DataSource = Cities;

                Anketa anketa = db.Anketa.Find(Convert.ToInt32(dataGridViewAnk[0, rowIndex].Value));

                anketaDetails.textBoxFIO.Text = anketa.FIO;
                anketaDetails.comboBoxPol.SelectedItem = anketa.Pol;
                if (anketa.Uvlechenia != null)
                {
                    anketaDetails.checkBoxSport.Checked = (bool)anketa.Uvlechenia.Sport;
                    anketaDetails.checkBoxTrav.Checked = (bool)anketa.Uvlechenia.Travelling;
                    anketaDetails.checkBoxTV.Checked = (bool)anketa.Uvlechenia.TV;
                    anketaDetails.checkBoxShop.Checked = (bool)anketa.Uvlechenia.Shopping;
                }
                anketaDetails.maskedTextBoxPhone.Text = anketa.Phone;
                anketaDetails.comboBoxCity.Text = anketa.City.CityName;
                anketaDetails.numericUpDownAge.Value = (decimal)anketa.Age;

                anketaDetails.textBoxFIO.Enabled = false;
                anketaDetails.comboBoxPol.Enabled = false;
                anketaDetails.checkBoxSport.Enabled = false;
                anketaDetails.checkBoxTrav.Enabled = false;
                anketaDetails.checkBoxTV.Enabled = false;
                anketaDetails.checkBoxShop.Enabled = false;
                anketaDetails.maskedTextBoxPhone.Enabled = false;
                anketaDetails.comboBoxCity.Enabled = false;
                anketaDetails.numericUpDownAge.Enabled = false;

                anketaDetails.buttonCancel.Visible = false;
                anketaDetails.buttonAddCity.Visible = false;
                anketaDetails.ShowDialog();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAnk.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку!");
                return;
            }

            int rowIndex = dataGridViewAnk.SelectedRows[0].Index;

            

            using (LoveDataContext db = new LoveDataContext())
            {
                Anketa anketa = db.Anketa.Find(Convert.ToInt32(dataGridViewAnk[0, rowIndex].Value));

                DialogResult dialogResult = MessageBox.Show($"Вы увены, что хотите удалить анкету {anketa.FIO}?", "", MessageBoxButtons.OKCancel);

                if (dialogResult != DialogResult.OK)
                    return;
                db.Anketa.Remove(anketa);
                db.SaveChanges();
            }

            FillTable();
            ShowAll();
        }
    }
}
