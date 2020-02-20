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
    public partial class FrmContracts : Form
    {
        public FrmContracts()
        {
            InitializeComponent();
        }

        private void FrmContracts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.ContractsCarCl' table. You can move, or remove it, as needed.
            this.contractsCarClTableAdapter.Fill(this.dataSetRentalCars.ContractsCarCl);

        }

        private void button_search_frm_car_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text != "" && textBoxCar.Text == "" && textBoxPassp.Text == "")
                find_num();
            if (textBoxNum.Text == "" && textBoxCar.Text != "" && textBoxPassp.Text == "")
                find_car();
            if (textBoxNum.Text == "" && textBoxCar.Text == "" && textBoxPassp.Text != "")
                find_passp();
            if (textBoxNum.Text != "" && textBoxCar.Text != "" && textBoxPassp.Text == "")
                find_num_car();
            if (textBoxNum.Text == "" && textBoxCar.Text != "" && textBoxPassp.Text != "")
                find_car_passp();
            if (textBoxNum.Text != "" && textBoxCar.Text == "" && textBoxPassp.Text != "")
                find_num_passp();
            if (textBoxNum.Text != "" && textBoxCar.Text != "" && textBoxPassp.Text != "")
                find_num_car_passp();
        }

        private void find_num()
        {
            string num = textBoxNum.Text;
            contractsCarClTableAdapter.FillByNum(dataSetRentalCars.ContractsCarCl, num);
        }

        private void find_car()
        {
            string car = textBoxCar.Text;
            contractsCarClTableAdapter.FillByCar(dataSetRentalCars.ContractsCarCl, car);
        }

        private void find_passp()
        {
            string passp = textBoxPassp.Text;
            contractsCarClTableAdapter.FillByPassp(dataSetRentalCars.ContractsCarCl, passp);
        }

        private void find_num_car()
        {
            string num = textBoxNum.Text;
            string car = textBoxCar.Text;
            contractsCarClTableAdapter.FillByNumCar(dataSetRentalCars.ContractsCarCl, num, car);
        }

        private void find_num_passp()
        {
            string num = textBoxNum.Text;
            string passp = textBoxPassp.Text;
            contractsCarClTableAdapter.FillByNumPassp(dataSetRentalCars.ContractsCarCl, num, passp);
        }

        private void find_car_passp()
        {
            string car = textBoxCar.Text;
            string passp = textBoxPassp.Text;
            contractsCarClTableAdapter.FillByCarPassp(dataSetRentalCars.ContractsCarCl, car, passp);
        }

        private void find_num_car_passp()
        {
            string num = textBoxNum.Text;
            string car = textBoxCar.Text;
            string passp = textBoxPassp.Text;
            contractsCarClTableAdapter.FillByNumCarPassp(dataSetRentalCars.ContractsCarCl, num, car, passp);
        }
    }
}
