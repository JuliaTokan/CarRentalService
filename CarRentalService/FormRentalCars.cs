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
    public partial class FormRentalCars : Form
    {
        public FormRentalCars()
        {
            InitializeComponent();
            carsTableAdapter.Fill(dataSetRentalCars.Cars);
            clientsTableAdapter.Fill(dataSetRentalCars.Clients);
            contractsTableAdapter.Fill(dataSetRentalCars.Contracts);
            carsModelsTableAdapter.Fill(dataSetRentalCars.CarsModels);
            carsBrandsTableAdapter.Fill(dataSetRentalCars.CarsBrands);
            carsClassesTableAdapter.Fill(dataSetRentalCars.CarsClasses);
            salonsTableAdapter.Fill(dataSetRentalCars.Salons);
            citiesTableAdapter.Fill(dataSetRentalCars.Cities);
        }

        private void FormRentalCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.Cities' table. You can move, or remove it, as needed.
            //this.citiesTableAdapter.Fill(this.dataSetRentalCars.Cities);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.Salons' table. You can move, or remove it, as needed.
            //this.salonsTableAdapter.Fill(this.dataSetRentalCars.Salons);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.CarsClasses' table. You can move, or remove it, as needed.
            //this.carsClassesTableAdapter.Fill(this.dataSetRentalCars.CarsClasses);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.CarsBrands' table. You can move, or remove it, as needed.
            //this.carsBrandsTableAdapter.Fill(this.dataSetRentalCars.CarsBrands);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.CarsModels' table. You can move, or remove it, as needed.
            //this.carsModelsTableAdapter.Fill(this.dataSetRentalCars.CarsModels);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.Contracts' table. You can move, or remove it, as needed.
            //this.contractsTableAdapter.Fill(this.dataSetRentalCars.Contracts);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            //this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);
            //// TODO: This line of code loads data into the 'dataSetRentalCars.Cars' table. You can move, or remove it, as needed.
            //this.carsTableAdapter.Fill(this.dataSetRentalCars.Cars);
            set_unvisible();
        }

        private void button_save_car_Click(object sender, EventArgs e)
        {
            carsTableAdapter.Update(dataSetRentalCars.Cars);
        }

        private void button_save_contract_Click(object sender, EventArgs e)
        {
             try
             {
                 string date_from = dataGridViewContracts.CurrentRow.Cells["cntrfromDataGridViewTextBoxColumn"].Value.ToString();
                 string date_to = dataGridViewContracts.CurrentRow.Cells["cntrtoDataGridViewTextBoxColumn"].Value.ToString();
                 date_from = new_date(date_from);
                 date_to = new_date(date_to);
                 int car = (int)dataGridViewContracts.CurrentRow.Cells["cntrcarDataGridViewTextBoxColumn"].Value;
                 //MessageBox.Show(car.ToString());

                 global::System.Nullable<int> count_to = qtAdapterDTLibrary1.SQContractTo(date_to, car);
                 global::System.Nullable<int> count_from = qtAdapterDTLibrary1.SQContractFrom(date_from, car);
                 if (count_to == 0 && count_from == 0)
                 {
                    contractsTableAdapter.Update(dataSetRentalCars.Contracts);
                 }
                else
                {
                    MessageBox.Show("On this time exist car's contract", "Information about contracts");
                    dataGridViewContracts.Rows.RemoveAt(dataGridViewContracts.CurrentRow.Index);
                }
            }
             catch
             {
                 MessageBox.Show("Error!", "Add contracts");
             }
        }

        private string new_date (string date)
        {
            return date.Substring(6, 4) + "." + date.Substring(3, 2) + "." + date.Substring(0, 2);
        }

        private void button_save_client_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Update(dataSetRentalCars.Clients);
        }

        private void button_save_models_Click(object sender, EventArgs e)
        {
            carsModelsTableAdapter.Update(dataSetRentalCars.CarsModels);
        }

        private void button_save_brands_Click(object sender, EventArgs e)
        {
            carsBrandsTableAdapter.Update(dataSetRentalCars.CarsBrands);
        }

        private void button_save_classes_Click(object sender, EventArgs e)
        {
            carsClassesTableAdapter.Update(dataSetRentalCars.CarsClasses);
        }

        private void button_save_salons_Click(object sender, EventArgs e)
        {
            salonsTableAdapter.Update(dataSetRentalCars.Salons);
        }

        private void button_save_cities_Click(object sender, EventArgs e)
        {
            citiesTableAdapter.Update(dataSetRentalCars.Cities);
        }



        private void button_delete_client_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClients.CurrentRow.Cells["clidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> client_count = qtAdapterDTLibrary1.SQCountCLIENT_IDInContracts(id);

                if (client_count == 0)
                {
                    clientsBindingSource.RemoveCurrent();
                }
                else
                {
                    //MessageBox.Show("Unable to delete! The clients rented a car!", "Error removing clients");
                    DialogResult res = MessageBox.Show("The clients rented a car! Are you sure you want to delete client's contracts?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        delete_contract((int)dataGridViewClients.CurrentRow.Cells[0].Value, "cntrclDataGridViewTextBoxColumn");
                        clientsBindingSource.RemoveCurrent();
                    }
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about clients");
            }
        }

        private void button_delete_car_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCars.CurrentRow.Cells["caridDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> car_count = qtAdapterDTLibrary1.SQCountCAR_IDInContracts(id);

                if (car_count == 0)
                {
                    carsBindingSource.RemoveCurrent();
                }
                else
                {
                    DialogResult res = MessageBox.Show("The car is rented! Are you sure you want to delete car's contracts?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        delete_contract((int)dataGridViewCars.CurrentRow.Cells[0].Value, "cntrcarDataGridViewTextBoxColumn");
                        carsBindingSource.RemoveCurrent();
                    }
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about cars");
            }
        }

        private void button_delete_contract_Click(object sender, EventArgs e)
        {
            try
            {
                string date_end = dataGridViewContracts.CurrentRow.Cells["cntrtoDataGridViewTextBoxColumn"].Value.ToString();
                DateTime date = DateTime.ParseExact(date_end.Substring(0, 10), "dd.M.yyyy", null);
                DateTime nowDate = DateTime.Now;
                if (nowDate > date)
                {
                    contractsBindingSource.RemoveCurrent();
                    contractsTableAdapter.Update(dataSetRentalCars.Contracts);
                }
                else
                {
                    DialogResult res = MessageBox.Show("The contract is available! Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        contractsBindingSource.RemoveCurrent();
                        contractsTableAdapter.Update(dataSetRentalCars.Contracts);
                    }
                    }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about contracts");
            }
        }

        private void button_delete_models_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewModels.CurrentRow.Cells["cmidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> model_count = qtAdapterDTLibrary1.SQCountMOD_IDInCars(id);

                if (model_count == 0)
                {
                    carsModelsBindingSource.RemoveCurrent();
                }
                else
                {
                    DialogResult res = MessageBox.Show("The car this model available! Are you sure you want to delete this car?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        delete_car((int)dataGridViewModels.CurrentRow.Cells[0].Value, "carmodelDataGridViewTextBoxColumn");
                        carsModelsBindingSource.RemoveCurrent();
                    }
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about models");
            }
        }

        private void button_delete_brands_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewBrands.CurrentRow.Cells["cbidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> brand_count = qtAdapterDTLibrary1.SQCountBRAND_IDInModels(id);

                if (brand_count == 0)
                {
                    carsBrandsBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("The model this brand exists!", "Error!");
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about brands");
            }
        }

        private void button_delete_classes_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewClasses.CurrentRow.Cells["ccidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> class_count = qtAdapterDTLibrary1.SQCountCLASS_IDInCars(id);

                if (class_count == 0)
                {
                    carsClassesBindingSource.RemoveCurrent();
                }
                else
                {
                    DialogResult res = MessageBox.Show("The car this class available! Are you sure you want to delete this car?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        delete_car((int)dataGridViewClasses.CurrentRow.Cells[0].Value, "carclassDataGridViewTextBoxColumn");
                        carsClassesBindingSource.RemoveCurrent();
                    }
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about classes");
            }
        }

        private void button_delete_salons_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewSalons.CurrentRow.Cells["slidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> salon_count = qtAdapterDTLibrary1.SQCountSALON_IDInContracts(id);

                if (salon_count == 0)
                {
                    salonsBindingSource.RemoveCurrent();
                    
                }
                else
                {
                    DialogResult res = MessageBox.Show("The salon is declareted! Are you sure you want to delete this contracts?", "Warning", MessageBoxButtons.YesNoCancel);
                    if (res == DialogResult.Yes)
                    {
                        delete_contract((int)dataGridViewSalons.CurrentRow.Cells[0].Value, "cntrslDataGridViewTextBoxColumn");
                        salonsBindingSource.RemoveCurrent();
                    }
                }
                set_unvisible();
            }
            catch
            {
                MessageBox.Show("Error!", "Information about salons");
            }
        }

        private void button_delete_cities_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dataGridViewCities.CurrentRow.Cells["cityidDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> city_count = qtAdapterDTLibrary1.SQCountCITY_IDInSalons(id);

                if (city_count == 0)
                {
                    citiesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Salons exist in this city!", "Error!");
                }
                set_unvisible();

            }
           
            catch
            {
                MessageBox.Show("Error!", "Information about cities");
            }
        }


        private void delete_contract(int id, string columnName)
        {
            int i=0;
            for(i=0; i<dataGridViewContracts.RowCount; i++)
            {
                if ((int)dataGridViewContracts.Rows[i].Cells[columnName].Value == id)
                {
                    string date_end = dataGridViewContracts.Rows[i].Cells["cntrtoDataGridViewTextBoxColumn"].Value.ToString();
                    DateTime date = DateTime.ParseExact(date_end.Substring(0, 10), "dd.M.yyyy", null);
                    DateTime nowDate = DateTime.Now;
                    if (nowDate > date)
                    {
                        contractsBindingSource.RemoveAt(i);
                        contractsTableAdapter.Update(dataSetRentalCars.Contracts);
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("The contract is available! Are you sure you want to delete?", "Warning", MessageBoxButtons.YesNoCancel);
                        if (res == DialogResult.Yes)
                        {
                            contractsBindingSource.RemoveAt(i);
                            contractsTableAdapter.Update(dataSetRentalCars.Contracts);
                        }
                    }
                }
            }
        }

        private void delete_car(int id, string columnName)
        {
            int i = 0;
            for (i = 0; i < dataGridViewCars.RowCount; i++)
            {
                if ((int)dataGridViewCars.Rows[i].Cells[columnName].Value == id)
                {
                    try
                    {
                        int car_id = (int)dataGridViewCars.Rows[i].Cells["caridDataGridViewTextBoxColumn"].Value;
                        global::System.Nullable<int> car_count = qtAdapterDTLibrary1.SQCountCAR_IDInContracts(car_id);

                        if (car_count == 0)
                        {
                            carsBindingSource.RemoveAt(i);
                        }
                        else
                        {
                            DialogResult res = MessageBox.Show("The car is rented! Are you sure you want to delete car's contracts?", "Warning", MessageBoxButtons.YesNoCancel);
                            if (res == DialogResult.Yes)
                            {
                                delete_contract((int)dataGridViewCars.Rows[i].Cells[0].Value, "cntrcarDataGridViewTextBoxColumn");
                                carsBindingSource.RemoveAt(i);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error!", "Information about cars");
                    }
                }
            }
        }


        private void button_search_car_Click(object sender, EventArgs e)
        {
            try
            {
                FindCar frmClients = new FindCar();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Search");
            }
        }

        private void button_search_salons_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSalons frmClients = new FrmSalons();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Search");
            }
        }

        private void button_search_client_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClients frmClients = new FrmClients();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Search");
            }
        }

        private void button_search_contract_Click(object sender, EventArgs e)
        {
            try
            {
                FrmContracts frmClients = new FrmContracts();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Search");
            }
        }

        private void button_search_models_Click(object sender, EventArgs e)
        {
            try
            {
                FrmModel frmClients = new FrmModel();
                frmClients.ShowDialog(this);
                frmClients.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!", "Search");
            }
        }


        private void set_unvisible()
        {
            dataGridViewCars.Columns[0].Visible = false;
            dataGridViewClients.Columns[0].Visible = false;
            dataGridViewContracts.Columns[0].Visible = false;
            dataGridViewModels.Columns[0].Visible = false;
            dataGridViewBrands.Columns[0].Visible = false;
            dataGridViewClasses.Columns[0].Visible = false;
            dataGridViewSalons.Columns[0].Visible = false;
            dataGridViewCities.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClientByClass clientByClass = new ClientByClass();
                clientByClass.ShowDialog();
                clientByClass.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonQuery2_Click(object sender, EventArgs e)
        {
            try
            {
                SalonByBrand salonByBrand = new SalonByBrand();
                salonByBrand.ShowDialog();
                salonByBrand.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsByClient clientsByClient = new ClientsByClient();
                clientsByClient.ShowDialog();
                clientsByClient.Dispose();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonQuery4_Click(object sender, EventArgs e)
        {
            try
            {
                ClientsByCarsNum clientsByCarsNum = new ClientsByCarsNum();
                clientsByCarsNum.ShowDialog();
                clientsByCarsNum.Dispose();
            }
            catch
            {
                MessageBox.Show("Find", "Error!");
            }
        }

        private void dataGridViewClients_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewContracts_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewCars_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewModels_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewBrands_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewClasses_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewSalons_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }

        private void dataGridViewCities_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Wrong input!", "Error");
        }
    }
}
