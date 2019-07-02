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
    public partial class CityAdding : Form
    {
        public CityAdding()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (textBoxCity.Text.Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите название города!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            return;
        }
    }
}
