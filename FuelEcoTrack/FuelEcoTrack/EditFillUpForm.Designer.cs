namespace FuelEcoTrackNS
{
    partial class EditFillUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditFillUpForm));
            this.labelDate = new System.Windows.Forms.Label();
            this.labelFuelPrice = new System.Windows.Forms.Label();
            this.labelFuelCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFuelPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerFill = new System.Windows.Forms.DateTimePicker();
            this.textBoxFillCost = new System.Windows.Forms.TextBox();
            this.textBoxFillQuantity = new System.Windows.Forms.TextBox();
            this.textBoxFillDistance = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(15, 30);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date :";
            // 
            // labelFuelPrice
            // 
            this.labelFuelPrice.AutoSize = true;
            this.labelFuelPrice.Location = new System.Drawing.Point(15, 60);
            this.labelFuelPrice.Name = "labelFuelPrice";
            this.labelFuelPrice.Size = new System.Drawing.Size(75, 13);
            this.labelFuelPrice.TabIndex = 1;
            this.labelFuelPrice.Text = "Fuel Price (¢) :";
            // 
            // labelFuelCost
            // 
            this.labelFuelCost.AutoSize = true;
            this.labelFuelCost.Location = new System.Drawing.Point(15, 90);
            this.labelFuelCost.Name = "labelFuelCost";
            this.labelFuelCost.Size = new System.Drawing.Size(81, 13);
            this.labelFuelCost.TabIndex = 2;
            this.labelFuelCost.Text = "Fill-Up Cost ($) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fuel Quantity (L) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Distance (km) :";
            // 
            // textBoxFuelPrice
            // 
            this.textBoxFuelPrice.Location = new System.Drawing.Point(178, 57);
            this.textBoxFuelPrice.Name = "textBoxFuelPrice";
            this.textBoxFuelPrice.Size = new System.Drawing.Size(148, 20);
            this.textBoxFuelPrice.TabIndex = 5;
            this.textBoxFuelPrice.TextChanged += new System.EventHandler(this.textBoxFuelPrice_TextChanged);
            // 
            // dateTimePickerFill
            // 
            this.dateTimePickerFill.Location = new System.Drawing.Point(178, 30);
            this.dateTimePickerFill.MaxDate = new System.DateTime(4000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFill.Name = "dateTimePickerFill";
            this.dateTimePickerFill.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerFill.TabIndex = 6;
            this.dateTimePickerFill.Value = new System.DateTime(2013, 6, 4, 0, 0, 0, 0);
            this.dateTimePickerFill.ValueChanged += new System.EventHandler(this.dateTimePickerFill_ValueChanged);
            // 
            // textBoxFillCost
            // 
            this.textBoxFillCost.Location = new System.Drawing.Point(178, 87);
            this.textBoxFillCost.Name = "textBoxFillCost";
            this.textBoxFillCost.Size = new System.Drawing.Size(148, 20);
            this.textBoxFillCost.TabIndex = 7;
            this.textBoxFillCost.TextChanged += new System.EventHandler(this.textBoxFillCost_TextChanged);
            // 
            // textBoxFillQuantity
            // 
            this.textBoxFillQuantity.Location = new System.Drawing.Point(178, 117);
            this.textBoxFillQuantity.Name = "textBoxFillQuantity";
            this.textBoxFillQuantity.Size = new System.Drawing.Size(148, 20);
            this.textBoxFillQuantity.TabIndex = 8;
            this.textBoxFillQuantity.TextChanged += new System.EventHandler(this.textBoxFillQuantity_TextChanged);
            // 
            // textBoxFillDistance
            // 
            this.textBoxFillDistance.Location = new System.Drawing.Point(178, 147);
            this.textBoxFillDistance.Name = "textBoxFillDistance";
            this.textBoxFillDistance.Size = new System.Drawing.Size(148, 20);
            this.textBoxFillDistance.TabIndex = 9;
            this.textBoxFillDistance.TextChanged += new System.EventHandler(this.textBoxFillDistance_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(178, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(251, 181);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 11;
            this.buttonCreate.Text = "Done";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // EditFillUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 216);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxFillDistance);
            this.Controls.Add(this.textBoxFillQuantity);
            this.Controls.Add(this.textBoxFillCost);
            this.Controls.Add(this.dateTimePickerFill);
            this.Controls.Add(this.textBoxFuelPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFuelCost);
            this.Controls.Add(this.labelFuelPrice);
            this.Controls.Add(this.labelDate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditFillUpForm";
            this.Text = "Edit Fill-Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelFuelPrice;
        private System.Windows.Forms.Label labelFuelCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFuelPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerFill;
        private System.Windows.Forms.TextBox textBoxFillCost;
        private System.Windows.Forms.TextBox textBoxFillQuantity;
        private System.Windows.Forms.TextBox textBoxFillDistance;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonCreate;
    }
}