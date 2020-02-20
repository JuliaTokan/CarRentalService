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
    public partial class ClientsByCarsNum : Form
    {
        public ClientsByCarsNum()
        {
            InitializeComponent();
        }

        private void ClientsByCarsNum_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Int32.Parse(textBoxNum.Text);
                clientsTableAdapter.FillByCarNum(dataSetRentalCars.Clients, num);
            }
            catch (Exception)
            {
                MessageBox.Show("Error input num!");
            }
        }
    }
}
