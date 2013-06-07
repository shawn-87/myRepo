using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelEcoTrackNS
{
    class NewFillUp
    {

        // Field 
        private int fillID = 0;
        private DateTime fillDate;
        private float fillFuelPrice = 0;
        private float fillFuelQuantity = 0;
        private float fillFuelCost = 0;
        private float fillDistance = 0;


        // Constructor that takes no arguments. 
        public NewFillUp(int myID)
        {
            fillID = myID;
            fillFuelPrice = 0;
            fillFuelQuantity = 0;
            fillFuelCost = 0;
            fillDistance = 0;
        }


        //Add Fill-Up To Table
        public void insertFillUp()
        {
            // Retrieve the connection string from the settings file.
            string conString = Properties.Settings.Default.MyFillUpDBConnectionString;

            // Open the connection using the connection string.
            using (SqlCeConnection con = new SqlCeConnection(conString))
            {
                con.Open();

                // Insert into the SqlCe table. ExecuteNonQuery is best for inserts.
                int fillID_DB = GetID();
                DateTime fillDate_DB = GetDate();
                float fillFuelPrice_DB = GetFuelPrice();
                float fillFuelQuantity_DB = GetFuelQuantity();
                float fillFuelCost_DB = GetFuelCost();
                float fillDistance_DB = GetDistance();
                if ((fillFuelPrice_DB/100) * fillFuelQuantity_DB == fillFuelCost_DB)
                {
                    using (SqlCeCommand com = new SqlCeCommand("INSERT INTO FillUpsTable (ID, Date, FuelPrice, FuelQuantity, FuelCost, Distance) VALUES (@fillID_DB , @fillDate_DB , @fillFuelPrice_DB , @fillFuelQuantity_DB , @fillFuelCost_DB , @fillDistance_DB)", con))
                    {
                        com.Parameters.AddWithValue("@fillID_DB", fillID_DB);
                        com.Parameters.AddWithValue("@fillDate_DB", fillDate_DB);
                        com.Parameters.AddWithValue("@fillFuelPrice_DB", fillFuelPrice_DB);
                        com.Parameters.AddWithValue("@fillFuelQuantity_DB", fillFuelQuantity_DB);
                        com.Parameters.AddWithValue("@fillFuelCost_DB", fillFuelCost_DB);
                        com.Parameters.AddWithValue("@fillDistance_DB", fillDistance_DB);
                        com.ExecuteNonQuery();
                    }
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Fuel Cost, Fuel Price, and Fuel Quantity do not coincide.\n"+
                        "At least one input is incorret.", "Your Update Failed",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }


        // Methods
        // Setters
        public void SetID(int newID)
        {
            fillID = newID;
        }
        public void SetDate(DateTime newDate)
        {
            fillDate = newDate;
        }
        public void SetFuelPrice(float newFuelPrice)
        {
            fillFuelPrice = newFuelPrice;
        }
        public void SetFuelQuantity(float newFuelQuantity)
        {
            fillFuelQuantity = newFuelQuantity;
        }
        public void SetFuelCost(float newFuelCost)
        {
            fillFuelCost = newFuelCost;
        }
        public void SetDistance(float newDistance)
        {
            fillDistance = newDistance;
        }

        // Getters
        public int GetID()
        {
            return fillID;
        }
        public DateTime GetDate()
        {
            return fillDate;
        }
        public float GetFuelPrice()
        {
            return fillFuelPrice;
        }
        public float GetFuelQuantity()
        {
            return fillFuelQuantity;
        }
        public float GetFuelCost()
        {
            return fillFuelCost;
        }
        public float GetDistance()
        {
            return fillDistance;
        }

    }
}
