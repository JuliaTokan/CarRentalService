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
    public partial class ClientsByClient : Form
    {
        public ClientsByClient()
        {
            InitializeComponent();
        }

        private void ClientsByClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);
            // TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);

        }

        private void Find_Click(object sender, EventArgs e)
        {
            int id = (int)comboBoxClient.SelectedValue;
            clientsTableAdapter.FillByClient(dataSetRentalCars.Clients, id);
        }
    }
}
