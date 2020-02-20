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
    public partial class SalonByBrand : Form
    {
        public SalonByBrand()
        {
            InitializeComponent();
        }

        private void SalonByBrand_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsBrands' table. You can move, or remove it, as needed.
            this.carsBrandsTableAdapter.Fill(this.dataSetRentalCars.CarsBrands);
            // TODO: This line of code loads data into the 'dataSetRentalCars.SalonsCities' table. You can move, or remove it, as needed.
            this.salonsCitiesTableAdapter.Fill(this.dataSetRentalCars.SalonsCities);

        }

        private void Find_Click(object sender, EventArgs e)
        {
            try
            {
                string brand = comboBoxBrand.Text;
                salonsCitiesTableAdapter.FillByBrand(dataSetRentalCars.SalonsCities, brand);
            }
            catch 
            {
                MessageBox.Show("Error find!");
            }
        }
    }
}
