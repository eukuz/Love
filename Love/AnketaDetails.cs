using Love.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Love
{
    public partial class AnketaDetails : Form
    {
        BindingList<City> cities;
        public AnketaDetails(BindingList<City> cities)
        {
            InitializeComponent();

            this.cities = cities;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxFIO.Text.Length == 0 || comboBoxPol.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, заполните обязательные поля (ФИО, Пол, Город)!");
                
                return;
            }

            this.DialogResult = DialogResult.OK;
            return;
        }

        private void buttonAddCity_Click(object sender, EventArgs e)
        {
            CityAdding cityAdding = new CityAdding();
            DialogResult dialogResult = cityAdding.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            using (LoveDataContext db = new LoveDataContext())
            {
                db.City.Add(new City { CityName = cityAdding.textBoxCity.Text });
                db.SaveChanges();

                cities = new BindingList<City>(db.City.ToList());
                comboBoxCity.DataSource = cities;
            }
        }
    }
}
