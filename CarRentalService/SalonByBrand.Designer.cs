namespace Lab1RentalCars
{
    partial class SalonByBrand
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.carsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.slidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sladdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonsCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonsCitiesTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.SalonsCitiesTableAdapter();
            this.carsBrandsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsBrandsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsCitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DataSource = this.carsBrandsBindingSource;
            this.comboBoxBrand.DisplayMember = "cb_name";
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(231, 117);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(347, 33);
            this.comboBoxBrand.TabIndex = 1;
            this.comboBoxBrand.ValueMember = "cb_name";
            // 
            // carsBrandsBindingSource
            // 
            this.carsBrandsBindingSource.DataMember = "CarsBrands";
            this.carsBrandsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.CadetBlue;
            this.Find.Location = new System.Drawing.Point(666, 80);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(212, 80);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(735, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Знайти салон з автопарком, де є автомобіль бренду:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slidDataGridViewTextBoxColumn,
            this.citynameDataGridViewTextBoxColumn,
            this.slcityDataGridViewTextBoxColumn,
            this.sladdressDataGridViewTextBoxColumn,
            this.cityidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salonsCitiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(850, 516);
            this.dataGridView1.TabIndex = 4;
            // 
            // slidDataGridViewTextBoxColumn
            // 
            this.slidDataGridViewTextBoxColumn.DataPropertyName = "sl_id";
            this.slidDataGridViewTextBoxColumn.HeaderText = "sl_id";
            this.slidDataGridViewTextBoxColumn.Name = "slidDataGridViewTextBoxColumn";
            this.slidDataGridViewTextBoxColumn.ReadOnly = true;
            this.slidDataGridViewTextBoxColumn.Visible = false;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "city_name";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            this.citynameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // slcityDataGridViewTextBoxColumn
            // 
            this.slcityDataGridViewTextBoxColumn.DataPropertyName = "sl_city";
            this.slcityDataGridViewTextBoxColumn.HeaderText = "sl_city";
            this.slcityDataGridViewTextBoxColumn.Name = "slcityDataGridViewTextBoxColumn";
            this.slcityDataGridViewTextBoxColumn.ReadOnly = true;
            this.slcityDataGridViewTextBoxColumn.Visible = false;
            // 
            // sladdressDataGridViewTextBoxColumn
            // 
            this.sladdressDataGridViewTextBoxColumn.DataPropertyName = "sl_address";
            this.sladdressDataGridViewTextBoxColumn.HeaderText = "sl_address";
            this.sladdressDataGridViewTextBoxColumn.Name = "sladdressDataGridViewTextBoxColumn";
            this.sladdressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityidDataGridViewTextBoxColumn
            // 
            this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
            this.cityidDataGridViewTextBoxColumn.HeaderText = "city_id";
            this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
            this.cityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityidDataGridViewTextBoxColumn.Visible = false;
            // 
            // salonsCitiesBindingSource
            // 
            this.salonsCitiesBindingSource.DataMember = "SalonsCities";
            this.salonsCitiesBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // salonsCitiesTableAdapter
            // 
            this.salonsCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // carsBrandsTableAdapter
            // 
            this.carsBrandsTableAdapter.ClearBeforeFill = true;
            // 
            // SalonByBrand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(998, 803);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.comboBoxBrand);
            this.Name = "SalonByBrand";
            this.Text = "SalonByBrand";
            this.Load += new System.EventHandler(this.SalonByBrand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsCitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource salonsCitiesBindingSource;
        private DataSetRentalCarsTableAdapters.SalonsCitiesTableAdapter salonsCitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn slidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sladdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carsBrandsBindingSource;
        private DataSetRentalCarsTableAdapters.CarsBrandsTableAdapter carsBrandsTableAdapter;
    }
}