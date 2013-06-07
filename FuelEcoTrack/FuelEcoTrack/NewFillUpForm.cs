using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEcoTrackNS
{
    public partial class NewFillUpForm : Form
    {
        NewFillUp myFillUpInfo;
        bool dateTrue = false, fuelPriceTrue = false, fillCostTrue = false, fillQuanitityTrue = false, distanceTrue = false;
        

        public NewFillUpForm(int idNumberToBe)
        {
            InitializeComponent();
            myFillUpInfo = new NewFillUp(idNumberToBe);
            dateTimePickerFill.MaxDate = DateTime.Today;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //Discard the form
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (dateTrue && fuelPriceTrue && fillCostTrue && fillQuanitityTrue && distanceTrue)
            {
                if (myFillUpInfo.GetFuelCost() == ((myFillUpInfo.GetFuelPrice()/100) * myFillUpInfo.GetFuelQuantity()))
                {
                    myFillUpInfo.insertFillUp();
                    //Now close the form
                    this.Close();
                }
                else {
                    MessageBox.Show("Fuel Cost, Fuel Price, and Fuel Quantity do not coincide.\n" +
                        "At least one input is incorret.", "Your Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                MessageBox.Show("At least one field contains an error.", "UH OH...", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        /// <summary>
        /// Auto update the object, myFillUpForm, with most recent results
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerFill_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                myFillUpInfo.SetDate(dateTimePickerFill.Value.Date);
                dateTimePickerFill.ForeColor = Color.Black;
                dateTrue = true;
            }
            catch {
                dateTimePickerFill.ForeColor = Color.Red;
                dateTrue = false;
            }

        }

        private void textBoxFuelPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myFillUpInfo.SetFuelPrice((float)Convert.ToDouble(textBoxFuelPrice.Text));
                textBoxFuelPrice.ForeColor = Color.Black;
                fuelPriceTrue = true;
            }
            catch {
                textBoxFuelPrice.ForeColor = Color.Red;
                fuelPriceTrue = false;
            }

        }

        private void textBoxFillCost_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myFillUpInfo.SetFuelCost((float)Convert.ToDouble(textBoxFillCost.Text));
                textBoxFillCost.ForeColor = Color.Black;
                fillCostTrue = true;
            }
            catch {
                textBoxFillCost.ForeColor = Color.Red;
                fillCostTrue = false;
            }

        }

        private void textBoxFillQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myFillUpInfo.SetFuelQuantity((float)Convert.ToDouble(textBoxFillQuantity.Text));
                textBoxFillQuantity.ForeColor = Color.Black;
                fillQuanitityTrue = true;
            }
            catch {
                textBoxFillQuantity.ForeColor = Color.Red;
                fillQuanitityTrue = false;
            }

        }

        private void textBoxFillDistance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                myFillUpInfo.SetDistance((float)Convert.ToDouble(textBoxFillDistance.Text));
                textBoxFillDistance.ForeColor = Color.Black;
                distanceTrue = true;
            }
            catch {
                textBoxFillDistance.ForeColor = Color.Red;
                distanceTrue = false;
            }

        }
    }
}
