using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Threading;



namespace FuelEcoTrackNS
{
    public partial class MainForm : Form
    {
        //private bool upgradeEconomy = false, upgradePrice = false, upgradeDistance = false;

        public MainForm()
        {
            InitializeComponent();
            FillData();
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                //column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
        }
        public DataGridView getDataGridViewTesting()
        {
            return dataGridView1;
        }

        //
        //Update Label Methods and Method To Call Update All Update Label Methods
        //
        public float updateTotalDistance(DataGridView theGrid)
        {
            float sumDist=0;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                sumDist += (float) Convert.ToDouble( theGrid.Rows[i].Cells[5].Value.ToString() ); 
            }
            //labelDistData.Text = sumDist.ToString();
            return sumDist;
        }

        public float updateTotalFuelCons(DataGridView theGrid)
        {
            float sumFuelCons = 0;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                sumFuelCons += (float)Convert.ToDouble(theGrid.Rows[i].Cells[3].Value.ToString());
            }
            //labelConsData.Text = sumFuelCons.ToString();
            return sumFuelCons;
        }

        public float updateAvgLHKM(float sumFuelCons, float sumDist) 
        {
            float avgLHKM = (sumFuelCons / sumDist) * 100;
            //labelLHKMData.Text = avgLHKM.ToString();
            return avgLHKM;
        }

        public float updateAvgMPG(float sumDistKilometers, float sumFuelConsLiters)
        {
            float miles, gallons;
            miles = sumDistKilometers * (float)0.621371;
            gallons = sumFuelConsLiters * (float)0.264172;
            //labelMPGData.Text = (miles / gallons).ToString();
            return (miles / gallons);
        }

        //365 Day Measure
        public float updateAvgFillCost(DataGridView theGrid)
        {
            float fillUpCostTemp = 0, numFillUpsTemp = 0;
            DateTime todayDate = DateTime.Now;
            DateTime pastFillUpDate;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                pastFillUpDate = (DateTime)theGrid.Rows[i].Cells[1].Value;
                TimeSpan ts = todayDate - pastFillUpDate;
                int differenceInDays = ts.Days;
                if ((differenceInDays < 365) && (differenceInDays >= 0))
                {
                    fillUpCostTemp += (float)Convert.ToDouble(theGrid.Rows[i].Cells[4].Value.ToString());
                    numFillUpsTemp++;
                }
            }
            //labelAvgFillCostNum.Text = (fillUpCostTemp / numFillUpsTemp).ToString();
            return (fillUpCostTemp / numFillUpsTemp);
        }

        //365 Day Measure
        public float updateAvgFuelPrice(DataGridView theGrid)
        {
            float fuelCostTemp = 0, numFillUpsTemp = 0;
            DateTime todayDate = DateTime.Now;
            DateTime pastFillUpDate;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                pastFillUpDate = (DateTime)theGrid.Rows[i].Cells[1].Value;
                TimeSpan ts = todayDate - pastFillUpDate;
                int differenceInDays = ts.Days;
                if ((differenceInDays < 365) && (differenceInDays >= 0))
                {
                    fuelCostTemp += (float)Convert.ToDouble(theGrid.Rows[i].Cells[2].Value.ToString());
                    numFillUpsTemp++;
                }
            }
            //labelAvgFuelPriceNum.Text = (fuelCostTemp / numFillUpsTemp).ToString();
            return (fuelCostTemp / numFillUpsTemp);
        }

        //365 Day Measure
        public float updateDistBtwnFill(DataGridView theGrid)
        {
            float fillUpDistTemp = 0, numFillUpsTemp = 0;
            DateTime todayDate = DateTime.Now;
            DateTime pastFillUpDate;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                pastFillUpDate = (DateTime)theGrid.Rows[i].Cells[1].Value;
                TimeSpan ts = todayDate - pastFillUpDate;
                int differenceInDays = ts.Days;
                if ((differenceInDays < 365) && (differenceInDays >= 0))
                {
                    fillUpDistTemp += (float)Convert.ToDouble(theGrid.Rows[i].Cells[5].Value.ToString());
                    numFillUpsTemp++;
                }
            }
            //labelDistBtwFillNum.Text = (fillUpDistTemp / numFillUpsTemp).ToString();
            return (fillUpDistTemp / numFillUpsTemp);
        }

        //365 Day Measure
        public float updateYearDist(DataGridView theGrid)
        {
            float yearDistTemp = 0;
            DateTime todayDate = DateTime.Now;
            DateTime pastFillUpDate;
            for (int i = 0; i < theGrid.RowCount; i++)
            {
                pastFillUpDate = (DateTime)theGrid.Rows[i].Cells[1].Value;
                TimeSpan ts = todayDate - pastFillUpDate;
                int differenceInDays = ts.Days;
                if ((differenceInDays < 365) && (differenceInDays >= 0))
                {
                   yearDistTemp += (float)Convert.ToDouble(theGrid.Rows[i].Cells[5].Value.ToString());
                    
                }
            }
            //labelYearDistData.Text = yearDistTemp.ToString();
            return yearDistTemp;
        }

        //all calls return data, and update the labels here. fuction calls can be unit tested.
        private void callAllUpdates()
        {
            labelDistData.Text = (updateTotalDistance(dataGridView1)).ToString();
            labelConsData.Text = (updateTotalFuelCons(dataGridView1)).ToString();
            labelLHKMData.Text = (updateAvgLHKM(updateTotalFuelCons(dataGridView1), updateTotalDistance(dataGridView1))).ToString();
            labelMPGData.Text = (updateAvgMPG(updateTotalDistance(dataGridView1), updateTotalFuelCons(dataGridView1))).ToString();
            labelAvgFillCostNum.Text = (updateAvgFillCost(dataGridView1)).ToString();
            labelAvgFuelPriceNum.Text = (updateAvgFuelPrice(dataGridView1)).ToString();
            labelDistBtwFillNum.Text = (updateDistBtwnFill(dataGridView1)).ToString();
            labelYearDistData.Text = (updateYearDist(dataGridView1)).ToString();
        }


        //
        //
        //


        //Button Clicks
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Retrieve the connection string from the settings file.
            string conString = Properties.Settings.Default.MyFillUpDBConnectionString;
            // Open the connection using the connection string.
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM FillUpsTable", con))
                {
                    com.ExecuteNonQuery();
                }
            }
            FillData();
        }

        private void toolStripFillUp_Click(object sender, EventArgs e)
        {
            int lastRow = dataGridView1.Rows.Count;
            int maxIDFound = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32( dataGridView1.Rows[i].Cells[0].Value.ToString() ) > maxIDFound)
                {
                    maxIDFound = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                
            }
            NewFillUpForm myNewFillUpForm = new NewFillUpForm((maxIDFound+ 1));
            myNewFillUpForm.ShowDialog();
            FillData();
            
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.SelectedRows[0];
            int editID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            DateTime editDateTime = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[1].Value);
            float editFuelPrice = (float)Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            float editFuelQuantity = (float)Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            float editFuelCost = (float)Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            float editDistance = (float)Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            EditFillUpForm myEditFillUpForm = new EditFillUpForm(editID,editDateTime, editFuelPrice, editFuelQuantity, editFuelCost, editDistance);
            myEditFillUpForm.ShowDialog();
            FillData();

            
        }

        private void toolStripRemove_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.SelectedRows[0];
            int deleteID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

            // Retrieve the connection string from the settings file.
            string conString = Properties.Settings.Default.MyFillUpDBConnectionString;
            // Open the connection using the connection string.
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                con.Open();
                using (SqlCeCommand com = new SqlCeCommand("DELETE FROM FillUpsTable WHERE [ID] = @ID_DB", con))
                {
                    com.Parameters.AddWithValue("@ID_DB", deleteID);
                    com.ExecuteNonQuery();
                }
            }
            FillData();
        }

        //Calculate Potential Saving
        private void buttonMetricChoice_Click(object sender, EventArgs e)
        {
            float newCarFuelEco = 0, newCarFuelPrice = 0, newCarDistance = 0 , oldCarFuelEco = 0;
            try
            {
                newCarFuelEco = (float)Convert.ToDouble(textBoxNewFuelEco.Text);
                newCarFuelPrice = (float)Convert.ToDouble(textBoxEstFuelPrice.Text);
                newCarDistance = (float)Convert.ToDouble(textBoxEstDist.Text);

                oldCarFuelEco = (float)Convert.ToDouble(labelLHKMData.Text);
                float newCarCost = (newCarFuelEco / 100) * newCarDistance * (newCarFuelPrice / 100);
                float myCarCost = (oldCarFuelEco / 100) * newCarDistance * (newCarFuelPrice / 100);
                labelSavingsEst.Text = (myCarCost - newCarCost).ToString();
            }
            catch
            {
                MessageBox.Show("At least one field in \"Upgrade Savings\" is not a valid number.", "My Application",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void buttonUSAChoice_Click(object sender, EventArgs e)
        {
            float newCarFuelEco = 0, newCarFuelPrice = 0, newCarDistance = 0, oldCarFuelEco = 0;
            newCarFuelEco = (float)Convert.ToDouble(textBoxNewFuelEco.Text);
            newCarFuelPrice = (float)Convert.ToDouble(textBoxEstFuelPrice.Text);
            newCarDistance = (float)Convert.ToDouble(textBoxEstDist.Text);
            oldCarFuelEco = (float)Convert.ToDouble(labelMPGData.Text);
            float newCarCost = (newCarDistance / newCarFuelEco ) * (newCarFuelPrice);
            float myCarCost = (newCarDistance / oldCarFuelEco ) * (newCarFuelPrice);
            labelSavingsEst.Text = (myCarCost - newCarCost).ToString();
        }
        //End

        //Fill dataGridView
        void FillData()
        {
            // Open connection
            using (SqlCeConnection c = new SqlCeConnection(
            Properties.Settings.Default.MyFillUpDBConnectionString))
            {
                c.Open();
                // Create new DataAdapter
                using (SqlCeDataAdapter a = new SqlCeDataAdapter(
                    "SELECT * FROM FillUpsTable", c))
                {
                    // Use DataAdapter to fill DataTable
                    DataTable t = new DataTable();
                    a.Fill(t);
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = t;
                    // Render data onto the screen
                    dataGridView1.DataSource = bSource;
                }
            }
            callAllUpdates();
        }

        private void textBoxNewFuelEco_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstFuelPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEstDist_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
