namespace FuelEcoTrackNS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripFillUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripRemove = new System.Windows.Forms.ToolStripButton();
            this.usageGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelYearDistData = new System.Windows.Forms.Label();
            this.labelYearDistAvg = new System.Windows.Forms.Label();
            this.labelDistBtwFillNum = new System.Windows.Forms.Label();
            this.avgDistBtwFill = new System.Windows.Forms.Label();
            this.labelAvgFuelPriceNum = new System.Windows.Forms.Label();
            this.labelAvgFillCostNum = new System.Windows.Forms.Label();
            this.labelAvgFuelCostYear = new System.Windows.Forms.Label();
            this.labelAvgFillCostYear = new System.Windows.Forms.Label();
            this.labelMPGData = new System.Windows.Forms.Label();
            this.labelLHKMData = new System.Windows.Forms.Label();
            this.labelConsData = new System.Windows.Forms.Label();
            this.labelDistData = new System.Windows.Forms.Label();
            this.labelMPG = new System.Windows.Forms.Label();
            this.labelLHKM = new System.Windows.Forms.Label();
            this.labelFuelCons = new System.Windows.Forms.Label();
            this.totalDistance = new System.Windows.Forms.Label();
            this.savingsGroupBox = new System.Windows.Forms.GroupBox();
            this.labelSplitBar = new System.Windows.Forms.Label();
            this.labelSavingsEst = new System.Windows.Forms.Label();
            this.labelSavings = new System.Windows.Forms.Label();
            this.textBoxEstDist = new System.Windows.Forms.TextBox();
            this.labelEstDist = new System.Windows.Forms.Label();
            this.labelLorM = new System.Windows.Forms.Label();
            this.buttonUSAChoice = new System.Windows.Forms.Button();
            this.buttonMetricChoice = new System.Windows.Forms.Button();
            this.textBoxEstFuelPrice = new System.Windows.Forms.TextBox();
            this.textBoxNewFuelEco = new System.Windows.Forms.TextBox();
            this.labelFuelEstCost = new System.Windows.Forms.Label();
            this.labelNewEconomy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.usageGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.savingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 248);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(950, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetDatabaseToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.resetToolStripMenuItem.Text = "Reset...";
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset Database";
            this.resetDatabaseToolStripMenuItem.Click += new System.EventHandler(this.resetDatabaseToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // chartsToolStripMenuItem
            // 
            this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
            this.chartsToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.chartsToolStripMenuItem.Text = "Charts...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFillUp,
            this.toolStripEdit,
            this.toolStripRemove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripFillUp
            // 
            this.toolStripFillUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripFillUp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFillUp.Image")));
            this.toolStripFillUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFillUp.Name = "toolStripFillUp";
            this.toolStripFillUp.Size = new System.Drawing.Size(69, 22);
            this.toolStripFillUp.Text = "Add Fill Up";
            this.toolStripFillUp.Click += new System.EventHandler(this.toolStripFillUp_Click);
            // 
            // toolStripEdit
            // 
            this.toolStripEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdit.Image")));
            this.toolStripEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdit.Name = "toolStripEdit";
            this.toolStripEdit.Size = new System.Drawing.Size(67, 22);
            this.toolStripEdit.Text = "Edit Fill Up";
            this.toolStripEdit.Click += new System.EventHandler(this.toolStripEdit_Click);
            // 
            // toolStripRemove
            // 
            this.toolStripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripRemove.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRemove.Image")));
            this.toolStripRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRemove.Name = "toolStripRemove";
            this.toolStripRemove.Size = new System.Drawing.Size(90, 22);
            this.toolStripRemove.Text = "Remove Fill Up";
            this.toolStripRemove.Click += new System.EventHandler(this.toolStripRemove_Click);
            // 
            // usageGroupBox
            // 
            this.usageGroupBox.Controls.Add(this.groupBox1);
            this.usageGroupBox.Controls.Add(this.labelMPGData);
            this.usageGroupBox.Controls.Add(this.labelLHKMData);
            this.usageGroupBox.Controls.Add(this.labelConsData);
            this.usageGroupBox.Controls.Add(this.labelDistData);
            this.usageGroupBox.Controls.Add(this.labelMPG);
            this.usageGroupBox.Controls.Add(this.labelLHKM);
            this.usageGroupBox.Controls.Add(this.labelFuelCons);
            this.usageGroupBox.Controls.Add(this.totalDistance);
            this.usageGroupBox.Location = new System.Drawing.Point(12, 56);
            this.usageGroupBox.Name = "usageGroupBox";
            this.usageGroupBox.Size = new System.Drawing.Size(662, 186);
            this.usageGroupBox.TabIndex = 3;
            this.usageGroupBox.TabStop = false;
            this.usageGroupBox.Text = "Your Usage";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelYearDistData);
            this.groupBox1.Controls.Add(this.labelYearDistAvg);
            this.groupBox1.Controls.Add(this.labelDistBtwFillNum);
            this.groupBox1.Controls.Add(this.avgDistBtwFill);
            this.groupBox1.Controls.Add(this.labelAvgFuelPriceNum);
            this.groupBox1.Controls.Add(this.labelAvgFillCostNum);
            this.groupBox1.Controls.Add(this.labelAvgFuelCostYear);
            this.groupBox1.Controls.Add(this.labelAvgFillCostYear);
            this.groupBox1.Location = new System.Drawing.Point(318, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 164);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "365 Day Breakdown";
            // 
            // labelYearDistData
            // 
            this.labelYearDistData.AutoSize = true;
            this.labelYearDistData.Location = new System.Drawing.Point(225, 134);
            this.labelYearDistData.Name = "labelYearDistData";
            this.labelYearDistData.Size = new System.Drawing.Size(10, 13);
            this.labelYearDistData.TabIndex = 7;
            this.labelYearDistData.Text = "-";
            // 
            // labelYearDistAvg
            // 
            this.labelYearDistAvg.AutoSize = true;
            this.labelYearDistAvg.Location = new System.Drawing.Point(6, 134);
            this.labelYearDistAvg.Name = "labelYearDistAvg";
            this.labelYearDistAvg.Size = new System.Drawing.Size(97, 13);
            this.labelYearDistAvg.TabIndex = 6;
            this.labelYearDistAvg.Text = "Year Distance (km)";
            // 
            // labelDistBtwFillNum
            // 
            this.labelDistBtwFillNum.AutoSize = true;
            this.labelDistBtwFillNum.Location = new System.Drawing.Point(225, 101);
            this.labelDistBtwFillNum.Name = "labelDistBtwFillNum";
            this.labelDistBtwFillNum.Size = new System.Drawing.Size(10, 13);
            this.labelDistBtwFillNum.TabIndex = 5;
            this.labelDistBtwFillNum.Text = "-";
            // 
            // avgDistBtwFill
            // 
            this.avgDistBtwFill.AutoSize = true;
            this.avgDistBtwFill.Location = new System.Drawing.Point(6, 101);
            this.avgDistBtwFill.Name = "avgDistBtwFill";
            this.avgDistBtwFill.Size = new System.Drawing.Size(174, 13);
            this.avgDistBtwFill.TabIndex = 4;
            this.avgDistBtwFill.Text = "Average Distance b/w Fill-Ups (km)";
            // 
            // labelAvgFuelPriceNum
            // 
            this.labelAvgFuelPriceNum.AutoSize = true;
            this.labelAvgFuelPriceNum.Location = new System.Drawing.Point(225, 65);
            this.labelAvgFuelPriceNum.Name = "labelAvgFuelPriceNum";
            this.labelAvgFuelPriceNum.Size = new System.Drawing.Size(10, 13);
            this.labelAvgFuelPriceNum.TabIndex = 3;
            this.labelAvgFuelPriceNum.Text = "-";
            // 
            // labelAvgFillCostNum
            // 
            this.labelAvgFillCostNum.AutoSize = true;
            this.labelAvgFillCostNum.Location = new System.Drawing.Point(225, 29);
            this.labelAvgFillCostNum.Name = "labelAvgFillCostNum";
            this.labelAvgFillCostNum.Size = new System.Drawing.Size(10, 13);
            this.labelAvgFillCostNum.TabIndex = 2;
            this.labelAvgFillCostNum.Text = "-";
            // 
            // labelAvgFuelCostYear
            // 
            this.labelAvgFuelCostYear.AutoSize = true;
            this.labelAvgFuelCostYear.Location = new System.Drawing.Point(6, 65);
            this.labelAvgFuelCostYear.Name = "labelAvgFuelCostYear";
            this.labelAvgFuelCostYear.Size = new System.Drawing.Size(118, 13);
            this.labelAvgFuelCostYear.TabIndex = 1;
            this.labelAvgFuelCostYear.Text = "Average Fuel Price ( ¢ )";
            // 
            // labelAvgFillCostYear
            // 
            this.labelAvgFillCostYear.AutoSize = true;
            this.labelAvgFillCostYear.Location = new System.Drawing.Point(6, 29);
            this.labelAvgFillCostYear.Name = "labelAvgFillCostYear";
            this.labelAvgFillCostYear.Size = new System.Drawing.Size(124, 13);
            this.labelAvgFillCostYear.TabIndex = 0;
            this.labelAvgFillCostYear.Text = "Average Fill Up Cost ( $ )";
            // 
            // labelMPGData
            // 
            this.labelMPGData.AutoSize = true;
            this.labelMPGData.Location = new System.Drawing.Point(190, 145);
            this.labelMPGData.Name = "labelMPGData";
            this.labelMPGData.Size = new System.Drawing.Size(10, 13);
            this.labelMPGData.TabIndex = 7;
            this.labelMPGData.Text = "-";
            // 
            // labelLHKMData
            // 
            this.labelLHKMData.AutoSize = true;
            this.labelLHKMData.Location = new System.Drawing.Point(190, 112);
            this.labelLHKMData.Name = "labelLHKMData";
            this.labelLHKMData.Size = new System.Drawing.Size(10, 13);
            this.labelLHKMData.TabIndex = 6;
            this.labelLHKMData.Text = "-";
            // 
            // labelConsData
            // 
            this.labelConsData.AutoSize = true;
            this.labelConsData.Location = new System.Drawing.Point(190, 76);
            this.labelConsData.Name = "labelConsData";
            this.labelConsData.Size = new System.Drawing.Size(10, 13);
            this.labelConsData.TabIndex = 5;
            this.labelConsData.Text = "-";
            // 
            // labelDistData
            // 
            this.labelDistData.AutoSize = true;
            this.labelDistData.Location = new System.Drawing.Point(190, 40);
            this.labelDistData.Name = "labelDistData";
            this.labelDistData.Size = new System.Drawing.Size(10, 13);
            this.labelDistData.TabIndex = 4;
            this.labelDistData.Text = "-";
            // 
            // labelMPG
            // 
            this.labelMPG.AutoSize = true;
            this.labelMPG.Location = new System.Drawing.Point(6, 145);
            this.labelMPG.Name = "labelMPG";
            this.labelMPG.Size = new System.Drawing.Size(74, 13);
            this.labelMPG.TabIndex = 3;
            this.labelMPG.Text = "Average MPG";
            // 
            // labelLHKM
            // 
            this.labelLHKM.AutoSize = true;
            this.labelLHKM.Location = new System.Drawing.Point(6, 112);
            this.labelLHKM.Name = "labelLHKM";
            this.labelLHKM.Size = new System.Drawing.Size(99, 13);
            this.labelLHKM.TabIndex = 2;
            this.labelLHKM.Text = "Average L / 100km";
            // 
            // labelFuelCons
            // 
            this.labelFuelCons.AutoSize = true;
            this.labelFuelCons.Location = new System.Drawing.Point(6, 76);
            this.labelFuelCons.Name = "labelFuelCons";
            this.labelFuelCons.Size = new System.Drawing.Size(133, 13);
            this.labelFuelCons.TabIndex = 1;
            this.labelFuelCons.Text = "Total Fuel Consumption (L)";
            // 
            // totalDistance
            // 
            this.totalDistance.AutoSize = true;
            this.totalDistance.Location = new System.Drawing.Point(6, 40);
            this.totalDistance.Name = "totalDistance";
            this.totalDistance.Size = new System.Drawing.Size(99, 13);
            this.totalDistance.TabIndex = 0;
            this.totalDistance.Text = "Total Distance (km)";
            // 
            // savingsGroupBox
            // 
            this.savingsGroupBox.Controls.Add(this.labelSplitBar);
            this.savingsGroupBox.Controls.Add(this.labelSavingsEst);
            this.savingsGroupBox.Controls.Add(this.labelSavings);
            this.savingsGroupBox.Controls.Add(this.textBoxEstDist);
            this.savingsGroupBox.Controls.Add(this.labelEstDist);
            this.savingsGroupBox.Controls.Add(this.labelLorM);
            this.savingsGroupBox.Controls.Add(this.buttonUSAChoice);
            this.savingsGroupBox.Controls.Add(this.buttonMetricChoice);
            this.savingsGroupBox.Controls.Add(this.textBoxEstFuelPrice);
            this.savingsGroupBox.Controls.Add(this.textBoxNewFuelEco);
            this.savingsGroupBox.Controls.Add(this.labelFuelEstCost);
            this.savingsGroupBox.Controls.Add(this.labelNewEconomy);
            this.savingsGroupBox.Location = new System.Drawing.Point(674, 56);
            this.savingsGroupBox.Name = "savingsGroupBox";
            this.savingsGroupBox.Size = new System.Drawing.Size(288, 186);
            this.savingsGroupBox.TabIndex = 4;
            this.savingsGroupBox.TabStop = false;
            this.savingsGroupBox.Text = "Upgrade Savings";
            // 
            // labelSplitBar
            // 
            this.labelSplitBar.AutoSize = true;
            this.labelSplitBar.Location = new System.Drawing.Point(6, 135);
            this.labelSplitBar.Name = "labelSplitBar";
            this.labelSplitBar.Size = new System.Drawing.Size(277, 13);
            this.labelSplitBar.TabIndex = 11;
            this.labelSplitBar.Text = "_____________________________________________";
            // 
            // labelSavingsEst
            // 
            this.labelSavingsEst.AutoSize = true;
            this.labelSavingsEst.Location = new System.Drawing.Point(167, 155);
            this.labelSavingsEst.Name = "labelSavingsEst";
            this.labelSavingsEst.Size = new System.Drawing.Size(10, 13);
            this.labelSavingsEst.TabIndex = 10;
            this.labelSavingsEst.Text = "-";
            // 
            // labelSavings
            // 
            this.labelSavings.AutoSize = true;
            this.labelSavings.Location = new System.Drawing.Point(6, 155);
            this.labelSavings.Name = "labelSavings";
            this.labelSavings.Size = new System.Drawing.Size(119, 13);
            this.labelSavings.TabIndex = 9;
            this.labelSavings.Text = "Potential Savings  ( $ ) :";
            // 
            // textBoxEstDist
            // 
            this.textBoxEstDist.Location = new System.Drawing.Point(138, 78);
            this.textBoxEstDist.Name = "textBoxEstDist";
            this.textBoxEstDist.Size = new System.Drawing.Size(144, 20);
            this.textBoxEstDist.TabIndex = 8;
            this.textBoxEstDist.Text = "e.g.    20000";
            this.textBoxEstDist.TextChanged += new System.EventHandler(this.textBoxEstDist_TextChanged);
            // 
            // labelEstDist
            // 
            this.labelEstDist.AutoSize = true;
            this.labelEstDist.Location = new System.Drawing.Point(6, 81);
            this.labelEstDist.Name = "labelEstDist";
            this.labelEstDist.Size = new System.Drawing.Size(98, 13);
            this.labelEstDist.TabIndex = 7;
            this.labelEstDist.Text = "Estimate Distance :";
            // 
            // labelLorM
            // 
            this.labelLorM.AutoSize = true;
            this.labelLorM.Location = new System.Drawing.Point(6, 114);
            this.labelLorM.Name = "labelLorM";
            this.labelLorM.Size = new System.Drawing.Size(75, 13);
            this.labelLorM.TabIndex = 6;
            this.labelLorM.Text = "Calculate For :";
            // 
            // buttonUSAChoice
            // 
            this.buttonUSAChoice.Location = new System.Drawing.Point(213, 109);
            this.buttonUSAChoice.Name = "buttonUSAChoice";
            this.buttonUSAChoice.Size = new System.Drawing.Size(69, 23);
            this.buttonUSAChoice.TabIndex = 5;
            this.buttonUSAChoice.Text = "USA";
            this.buttonUSAChoice.UseVisualStyleBackColor = true;
            this.buttonUSAChoice.Click += new System.EventHandler(this.buttonUSAChoice_Click);
            // 
            // buttonMetricChoice
            // 
            this.buttonMetricChoice.Location = new System.Drawing.Point(138, 109);
            this.buttonMetricChoice.Name = "buttonMetricChoice";
            this.buttonMetricChoice.Size = new System.Drawing.Size(69, 23);
            this.buttonMetricChoice.TabIndex = 4;
            this.buttonMetricChoice.Text = "Metric";
            this.buttonMetricChoice.UseVisualStyleBackColor = true;
            this.buttonMetricChoice.Click += new System.EventHandler(this.buttonMetricChoice_Click);
            // 
            // textBoxEstFuelPrice
            // 
            this.textBoxEstFuelPrice.Location = new System.Drawing.Point(138, 51);
            this.textBoxEstFuelPrice.Name = "textBoxEstFuelPrice";
            this.textBoxEstFuelPrice.Size = new System.Drawing.Size(144, 20);
            this.textBoxEstFuelPrice.TabIndex = 3;
            this.textBoxEstFuelPrice.Text = "e.g.   112.78";
            this.textBoxEstFuelPrice.TextChanged += new System.EventHandler(this.textBoxEstFuelPrice_TextChanged);
            // 
            // textBoxNewFuelEco
            // 
            this.textBoxNewFuelEco.Location = new System.Drawing.Point(138, 25);
            this.textBoxNewFuelEco.Name = "textBoxNewFuelEco";
            this.textBoxNewFuelEco.Size = new System.Drawing.Size(144, 20);
            this.textBoxNewFuelEco.TabIndex = 2;
            this.textBoxNewFuelEco.Text = "e.g.    4.6";
            this.textBoxNewFuelEco.TextChanged += new System.EventHandler(this.textBoxNewFuelEco_TextChanged);
            // 
            // labelFuelEstCost
            // 
            this.labelFuelEstCost.AutoSize = true;
            this.labelFuelEstCost.Location = new System.Drawing.Point(6, 54);
            this.labelFuelEstCost.Name = "labelFuelEstCost";
            this.labelFuelEstCost.Size = new System.Drawing.Size(75, 13);
            this.labelFuelEstCost.TabIndex = 1;
            this.labelFuelEstCost.Text = "Fuel Price ( ¢ )";
            // 
            // labelNewEconomy
            // 
            this.labelNewEconomy.AutoSize = true;
            this.labelNewEconomy.Location = new System.Drawing.Point(6, 28);
            this.labelNewEconomy.Name = "labelNewEconomy";
            this.labelNewEconomy.Size = new System.Drawing.Size(99, 13);
            this.labelNewEconomy.TabIndex = 0;
            this.labelNewEconomy.Text = "New Fuel Economy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 561);
            this.Controls.Add(this.savingsGroupBox);
            this.Controls.Add(this.usageGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(990, 600);
            this.Name = "MainForm";
            this.Text = "Fuel Economy Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.usageGroupBox.ResumeLayout(false);
            this.usageGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.savingsGroupBox.ResumeLayout(false);
            this.savingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripFillUp;
        private System.Windows.Forms.ToolStripButton toolStripEdit;
        private System.Windows.Forms.ToolStripButton toolStripRemove;
        private System.Windows.Forms.GroupBox usageGroupBox;
        private System.Windows.Forms.Label labelFuelCons;
        private System.Windows.Forms.Label totalDistance;
        private System.Windows.Forms.GroupBox savingsGroupBox;
        private System.Windows.Forms.Label labelMPG;
        private System.Windows.Forms.Label labelLHKM;
        private System.Windows.Forms.Label labelMPGData;
        private System.Windows.Forms.Label labelLHKMData;
        private System.Windows.Forms.Label labelConsData;
        private System.Windows.Forms.Label labelDistData;
        private System.Windows.Forms.Label labelSplitBar;
        private System.Windows.Forms.Label labelSavingsEst;
        private System.Windows.Forms.Label labelSavings;
        private System.Windows.Forms.TextBox textBoxEstDist;
        private System.Windows.Forms.Label labelEstDist;
        private System.Windows.Forms.Label labelLorM;
        private System.Windows.Forms.Button buttonUSAChoice;
        private System.Windows.Forms.Button buttonMetricChoice;
        private System.Windows.Forms.TextBox textBoxEstFuelPrice;
        private System.Windows.Forms.TextBox textBoxNewFuelEco;
        private System.Windows.Forms.Label labelFuelEstCost;
        private System.Windows.Forms.Label labelNewEconomy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label labelAvgFuelCostYear;
        private System.Windows.Forms.Label labelAvgFillCostYear;
        private System.Windows.Forms.Label avgDistBtwFill;
        private System.Windows.Forms.Label labelAvgFuelPriceNum;
        private System.Windows.Forms.Label labelAvgFillCostNum;
        private System.Windows.Forms.Label labelDistBtwFillNum;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
        private System.Windows.Forms.Label labelYearDistData;
        private System.Windows.Forms.Label labelYearDistAvg;
    }
}

