using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1RentalCars
{
    public partial class FrmSalons : Form
    {
        public FrmSalons()
        {
            InitializeComponent();
        }

        private void FrmSalons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars1.Cities' table. You can move, or remove it, as needed.
            this.citiesTableAdapter.Fill(this.dataSetRentalCars1.Cities);
            // TODO: This line of code loads data into the 'dataSetRentalCars.SalonsCities' table. You can move, or remove it, as needed.
            this.salonsCitiesTableAdapter.Fill(this.dataSetRentalCars.SalonsCities);

        }

        private void button_search_city_Click(object sender, EventArgs e)
        {
            find_city();
        }

        private void find_city()
        {
            int findcity = Convert.ToInt32(comboBoxCity.SelectedValue);
            if (findcity >= 0)
            {
                salonsCitiesTableAdapter.FillByCity(dataSetRentalCars.SalonsCities, findcity);
            }
            else MessageBox.Show("Error!", "Find");
        }
    }
}
