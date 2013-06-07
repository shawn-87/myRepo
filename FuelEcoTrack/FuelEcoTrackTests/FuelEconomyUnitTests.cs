using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FuelEcoTrackNS;
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


namespace FuelEcoTrackTests
{
    [TestClass]
    public class FuelEconomyUnitTests
    {

        [TestMethod]
        public void TestUpdateTotalDistance()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateTotalDistance(testForm.getDataGridViewTesting());
            float expected = 3294;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Total Distance");
 
        }

        [TestMethod]
        public void TestUpdateTotalFuelCons()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateTotalFuelCons(testForm.getDataGridViewTesting());
            float expected = 551;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Total Fuel Consumption");
        }

        [TestMethod]
        public void TestUpdateAvgLHKM()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateAvgLHKM(551,3294);
            float expected = 16.72738312f;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect LHKM Formula");

        }

        [TestMethod]
        public void TestUpdateAvgMPG()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateAvgMPG(3294,551);
            float expected = 14.0616f;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect MPG Conversion");
        }

        //365 day measure
        [TestMethod]
        public void TestUpdateAvgFillCost()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateAvgFillCost(testForm.getDataGridViewTesting());
            float expected = 46.5315f;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Avg Fill Cost");
        }

        [TestMethod]
        public void TestUpdateAvgFuelPrice()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateAvgFuelPrice(testForm.getDataGridViewTesting());
            float expected = 94f;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Avg Fuel Price");

        }

        [TestMethod]
        public void TestUpdateDistBtwnFill()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateDistBtwnFill(testForm.getDataGridViewTesting());
            float expected = 326.6666667f;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Avg Dist Between Fills");
        }

        [TestMethod]
        public void TestUpdateYearDist()
        {
            MainForm testForm = new MainForm();

            float actual = testForm.updateYearDist(testForm.getDataGridViewTesting());
            float expected = 980;
            Assert.AreEqual(expected, actual, 0.001, "Incorrect Year Dist");

        }

    }
}
