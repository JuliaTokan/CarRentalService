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
    public partial class FindCar : Form
    {
        public FindCar()
        {
            InitializeComponent();
            dataTable1TableAdapter.Fill(dataSetRentalCars.DataTable1);
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsModels' table. You can move, or remove it, as needed.
            this.carsModelsTableAdapter.Fill(this.dataSetRentalCars.CarsModels);
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsClasses' table. You can move, or remove it, as needed.
            this.carsClassesTableAdapter.Fill(this.dataSetRentalCars.CarsClasses);
            dataGridView1.Columns[0].Visible = false;
        }

        private void button_search_frm_car_Click(object sender, EventArgs e)
        {
            if (checkBoxClass.Checked && !checkBoxModel.Checked && !checkBoxPrice.Checked)
                find_class();
            if (!checkBoxClass.Checked && checkBoxModel.Checked && !checkBoxPrice.Checked)
                find_model();
            if (!checkBoxClass.Checked && !checkBoxModel.Checked && checkBoxPrice.Checked)
                find_price();
            if (checkBoxClass.Checked && checkBoxModel.Checked && !checkBoxPrice.Checked)
                find_class_model();
            if (checkBoxClass.Checked && !checkBoxModel.Checked && checkBoxPrice.Checked)
                find_class_price();
            if (!checkBoxClass.Checked && checkBoxModel.Checked && checkBoxPrice.Checked)
                find_model_price();
            if (checkBoxClass.Checked && checkBoxModel.Checked && checkBoxPrice.Checked)
                find_class_model_price();
        }

        private void find_class()
        {
            int cc_findname = Convert.ToInt32(comboBox1.SelectedValue);
            if (cc_findname >= 0)
            {
                dataTable1TableAdapter.FillByClass(dataSetRentalCars.DataTable1, cc_findname);
            }
            else MessageBox.Show("Error!", "Find");
        }

        private void find_model()
        {
            int findmodel = Convert.ToInt32(comboBox2.SelectedValue);
            if (findmodel >= 0)
            {
                dataTable1TableAdapter.FillByModel(dataSetRentalCars.DataTable1, findmodel);
            }
            else MessageBox.Show("Error!", "Find");
        }

        private void find_price()
        {
            try
            {
                int min = Convert.ToInt32(textBoxMin.Text);
                int max = Convert.ToInt32(textBoxMax.Text);
                if (min >= 0 && max >= 0)
                {
                    dataTable1TableAdapter.FillByPrice(dataSetRentalCars.DataTable1, min, max);
                }
                else MessageBox.Show("Wrong price format!", "Price");
            }
            catch
            {
                MessageBox.Show("Wrong price format!", "Price");
            }
        }

        private void find_class_model()
        {
            try
            {
                int findclass = Convert.ToInt32(comboBox1.SelectedValue);
                int findmodel = Convert.ToInt32(comboBox2.SelectedValue);
                if (findclass >= 0 && findmodel >= 0)
                {
                    dataTable1TableAdapter.FillByClassModel(dataSetRentalCars.DataTable1, findclass, findmodel);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Problem");
            }
        }

        private void find_class_price()
        {
            try
            {
                int findclass = Convert.ToInt32(comboBox1.SelectedValue);
                int min = Convert.ToInt32(textBoxMin.Text);
                int max = Convert.ToInt32(textBoxMax.Text);
                if (findclass >= 0 && min >= 0 && max >= 0)
                {
                    dataTable1TableAdapter.FillByClassPrice(dataSetRentalCars.DataTable1, findclass, min, max);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong price format!", "Price");
            }
        }

        private void find_model_price()
        {
            try
            {
                int findmodel = Convert.ToInt32(comboBox2.SelectedValue);
                int min = Convert.ToInt32(textBoxMin.Text);
                int max = Convert.ToInt32(textBoxMax.Text);
                if (findmodel >= 0 && min >= 0 && max >= 0)
                {
                    dataTable1TableAdapter.FillByModelPrice(dataSetRentalCars.DataTable1, findmodel, min, max);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong price format!", "Price");
            }
        }

        private void find_class_model_price()
        {
            try
            {
                int findclass = Convert.ToInt32(comboBox1.SelectedValue);
                int findmodel = Convert.ToInt32(comboBox2.SelectedValue);
                int min = Convert.ToInt32(textBoxMin.Text);
                int max = Convert.ToInt32(textBoxMax.Text);
                if (findclass >= 0 && findmodel >= 0 && min >= 0 && max >= 0)
                {
                    dataTable1TableAdapter.FillByClassModelPrice(dataSetRentalCars.DataTable1, findclass, findmodel, min, max);
                    MessageBox.Show(findclass.ToString() + " " + findmodel.ToString() + " " + min.ToString() + " " + max.ToString());
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong price format!", "Price");
            }
        }

        private void button_free_cars_Click(object sender, EventArgs e)
        {
            try
            {
                FreeCars frmClients = new FreeCars();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Free cars");
            }
        }
    }
}
