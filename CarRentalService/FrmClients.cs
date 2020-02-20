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
    public partial class FrmClients : Form
    {
        public FrmClients()
        {
            InitializeComponent();
        }

        private void FrmClients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.dataSetRentalCars.Clients);

        }

        private void button_search_frm_client_Click(object sender, EventArgs e)
        {
            if (textBoxPassport.Text != "" && textBoxSurname.Text == "" && textBoxTel.Text == "")
                find_passport();
            if (textBoxPassport.Text == "" && textBoxSurname.Text != "" && textBoxTel.Text == "")
                find_surname();
            if (textBoxPassport.Text == "" && textBoxSurname.Text == "" && textBoxTel.Text != "")
                find_tel();
            if (textBoxPassport.Text != "" && textBoxSurname.Text != "" && textBoxTel.Text == "")
                find_passport_surname();
            if (textBoxPassport.Text == "" && textBoxSurname.Text != "" && textBoxTel.Text != "")
                find_surname_tel();
            if (textBoxPassport.Text != "" && textBoxSurname.Text == "" && textBoxTel.Text != "")
                find_passport_tel();
            if (textBoxPassport.Text != "" && textBoxSurname.Text != "" && textBoxTel.Text != "")
                find_passport_surname_tel();
        }

        private void find_passport()
        {
            string findpassport = textBoxPassport.Text;
            if (findpassport !="")
            {
               // clientsTableAdapter.FillByPassport(dataSetRentalCars.Clients, findpassport);
            }
            else MessageBox.Show("Error!", "Find");
        }

        private void find_surname()
        {
            string findsurname = textBoxSurname.Text;
            if (findsurname != "")
            {
                clientsTableAdapter.FillBySurname(dataSetRentalCars.Clients, findsurname);
            }
            else MessageBox.Show("Error!", "Find");
        }

        private void find_tel()
        {
            try
            {
                int findtel = Int32.Parse(textBoxTel.Text);

                if (findtel >= 0)
                {
                    clientsTableAdapter.FillByTel(dataSetRentalCars.Clients, findtel);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong format telephone!", "Error");
            }
        }

        private void find_passport_tel()
        {
            try
            {
                string findpassport = textBoxPassport.Text;
                int findtel = Int32.Parse(textBoxTel.Text);
                if (findtel >= 0 && findpassport != "")
                {
                    clientsTableAdapter.FillByPassportTel(dataSetRentalCars.Clients, findpassport, findtel);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong format telephone!", "Error");
            }
        }

        private void find_surname_tel()
        {
            try
            {
                string findsurname = textBoxSurname.Text;
                int findtel = Int32.Parse(textBoxTel.Text);
                if (findtel >= 0 && findsurname != "")
                {
                    clientsTableAdapter.FillBySurnameTel(dataSetRentalCars.Clients, findsurname, findtel);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong format telephone!", "Error");
            }
        }

        private void find_passport_surname()
        {
            string findpassport = textBoxPassport.Text;
            string findsurname = textBoxSurname.Text;
            if (findpassport != "" && findsurname != "")
            {
                clientsTableAdapter.FillByPassportSurname(dataSetRentalCars.Clients, findpassport, findsurname);
            }
            else MessageBox.Show("Error!", "Find");
        }

        private void find_passport_surname_tel()
        {
            try
            {
                string findpassport = textBoxPassport.Text;
                string findsurname = textBoxSurname.Text;
                int findtel = Int32.Parse(textBoxTel.Text);
                if (findtel >= 0 && findpassport != "" && findsurname != "")
                {
                    clientsTableAdapter.FillByPassportSurnameTel(dataSetRentalCars.Clients, findpassport, findsurname, findtel);
                }
                else MessageBox.Show("Error!", "Find");
            }
            catch
            {
                MessageBox.Show("Wrong format telephone!", "Error");
            }
        }
    }
}
