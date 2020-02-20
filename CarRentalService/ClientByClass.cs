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
    public partial class ClientByClass : Form
    {
        public ClientByClass()
        {
            InitializeComponent();
            clientsTableAdapter.Fill(dataSetRentalCars.Clients);
            dataGridView1.Columns[0].Visible = false;
        }

        private void ClientByClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.CarsClasses' table. You can move, or remove it, as needed.
            this.carsClassesTableAdapter.Fill(this.dataSetRentalCars.CarsClasses);
            // TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);

        }

        private void Find_Click(object sender, EventArgs e)
        {
            string clas = comboBoxClass.Text;
            clientsTableAdapter.FillByClass(this.dataSetRentalCars.Clients, clas);
        }
    }
}
