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
    public partial class FrmModel : Form
    {
        public FrmModel()
        {
            InitializeComponent();
        }

        private void FrmModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars4.Trans' table. You can move, or remove it, as needed.
            this.transTableAdapter.Fill(this.dataSetRentalCars4.Trans);
            // TODO: This line of code loads data into the 'dataSetRentalCars3.Body' table. You can move, or remove it, as needed.
            this.bodyTableAdapter.Fill(this.dataSetRentalCars3.Body);
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsModels' table. You can move, or remove it, as needed.
            this.carsModelsTableAdapter.Fill(this.dataSetRentalCars.CarsModels);
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsBrands' table. You can move, or remove it, as needed.
            this.carsBrandsTableAdapter.Fill(this.dataSetRentalCars.CarsBrands);
            // TODO: This line of code loads data into the 'dataSetRentalCars.ModelsBrands' table. You can move, or remove it, as needed.
            this.modelsBrandsTableAdapter.Fill(this.dataSetRentalCars.ModelsBrands);
            
        }

        private void add_combo()
        {
            comboBoxTrans.Items.Add("Avtomat");
            comboBoxTrans.Items.Add("Mechanika");
        }

        private void button_search_frm_model_Click(object sender, EventArgs e)
        {
            if (checkBoxBrand.Checked && !checkBoxBody.Checked && !checkBoxTrans.Checked)
                find_brand();
            if (!checkBoxBrand.Checked && checkBoxBody.Checked && !checkBoxTrans.Checked)
                find_body();
            if (!checkBoxBrand.Checked && !checkBoxBody.Checked && checkBoxTrans.Checked)
                find_trans();
            if (checkBoxBrand.Checked && checkBoxBody.Checked && !checkBoxTrans.Checked)
                find_brand_body();
            if (checkBoxBrand.Checked && !checkBoxBody.Checked && checkBoxTrans.Checked)
                find_brand_trans();
            if (!checkBoxBrand.Checked && checkBoxBody.Checked && checkBoxTrans.Checked)
                find_body_trans();
            if (checkBoxBrand.Checked && checkBoxBody.Checked && checkBoxTrans.Checked)
                find_brand_body_trans();
        }

        private void find_brand()
        {
            int brand = Convert.ToInt32(comboBoxBrand.SelectedValue);
            modelsBrandsTableAdapter.FillByBrand(dataSetRentalCars.ModelsBrands, brand);
        }

        private void find_body()
        {
            string body = comboBoxBody.SelectedValue.ToString();
            modelsBrandsTableAdapter.FillByBody(dataSetRentalCars.ModelsBrands, body);
        }

        private void find_trans()
        {
            string trans = comboBoxTrans.SelectedValue.ToString();
            modelsBrandsTableAdapter.FillByTrans(dataSetRentalCars.ModelsBrands, trans);
        }

        private void find_body_trans()
        {
            string body = comboBoxBody.SelectedValue.ToString();
            string trans = comboBoxTrans.SelectedValue.ToString();
            modelsBrandsTableAdapter.FillByBodyTrans(dataSetRentalCars.ModelsBrands,body, trans);
        }

        private void find_brand_trans()
        {
            int brand = Convert.ToInt32(comboBoxBrand.SelectedValue);
            string trans = comboBoxTrans.SelectedValue.ToString();
            modelsBrandsTableAdapter.FillByBrandTrans(dataSetRentalCars.ModelsBrands, brand, trans);
        }

        private void find_brand_body()
        {
            string body = comboBoxBody.SelectedValue.ToString();
            int brand = Convert.ToInt32(comboBoxBrand.SelectedValue);
            modelsBrandsTableAdapter.FillByBrandBody(dataSetRentalCars.ModelsBrands, brand, body);
        }

        private void find_brand_body_trans()
        {
            int brand = Convert.ToInt32(comboBoxBrand.SelectedValue);
            string body = comboBoxBody.SelectedValue.ToString();
            string trans = comboBoxTrans.SelectedValue.ToString();
            modelsBrandsTableAdapter.FillByBrandBodyTrans(dataSetRentalCars.ModelsBrands,brand, body, trans);
        }
    }
}
