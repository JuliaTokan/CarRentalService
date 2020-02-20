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
    public partial class FreeCars : Form
    {
        public FreeCars()
        {
            InitializeComponent();
            freeCarsTableAdapter.Fill(dataSetRentalCars.FreeCars);
        }

        private void FreeCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentalCars.FreeCars' table. You can move, or remove it, as needed.
            this.freeCarsTableAdapter.Fill(this.dataSetRentalCars.FreeCars);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;
            
                if (from.CompareTo(to)<=0)
                {
                string d_from = from.ToString("yyyy.MM.dd H:mm:ss"); //"yyyy.MM.dd"
                string d_to = to.ToString("yyyy.MM.dd H:mm:ss");
               
                    freeCarsTableAdapter.FillByDate(dataSetRentalCars.FreeCars,d_from, d_to);
                }
                else MessageBox.Show("Wrong date period!", "Free cars");
            
        }
    }
}
