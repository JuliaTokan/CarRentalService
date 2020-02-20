namespace Lab1RentalCars
{
    partial class FrmSalons
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.slidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slcityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sladdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.citynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonsCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars1 = new Lab1RentalCars.DataSetRentalCars();
            this.button_search_city = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.salonsCitiesTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.SalonsCitiesTableAdapter();
            this.citiesTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsCitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slidDataGridViewTextBoxColumn,
            this.slcityDataGridViewTextBoxColumn,
            this.sladdressDataGridViewTextBoxColumn,
            this.cityidDataGridViewTextBoxColumn,
            this.citynameDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.salonsCitiesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(17, 192);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 33;
            this.dataGridView.Size = new System.Drawing.Size(543, 340);
            this.dataGridView.TabIndex = 0;
            // 
            // slidDataGridViewTextBoxColumn
            // 
            this.slidDataGridViewTextBoxColumn.DataPropertyName = "sl_id";
            this.slidDataGridViewTextBoxColumn.HeaderText = "sl_id";
            this.slidDataGridViewTextBoxColumn.Name = "slidDataGridViewTextBoxColumn";
            this.slidDataGridViewTextBoxColumn.ReadOnly = true;
            this.slidDataGridViewTextBoxColumn.Visible = false;
            // 
            // slcityDataGridViewTextBoxColumn
            // 
            this.slcityDataGridViewTextBoxColumn.DataPropertyName = "sl_city";
            this.slcityDataGridViewTextBoxColumn.HeaderText = "sl_city";
            this.slcityDataGridViewTextBoxColumn.Name = "slcityDataGridViewTextBoxColumn";
            this.slcityDataGridViewTextBoxColumn.Visible = false;
            // 
            // sladdressDataGridViewTextBoxColumn
            // 
            this.sladdressDataGridViewTextBoxColumn.DataPropertyName = "sl_address";
            this.sladdressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.sladdressDataGridViewTextBoxColumn.Name = "sladdressDataGridViewTextBoxColumn";
            // 
            // cityidDataGridViewTextBoxColumn
            // 
            this.cityidDataGridViewTextBoxColumn.DataPropertyName = "city_id";
            this.cityidDataGridViewTextBoxColumn.HeaderText = "city_id";
            this.cityidDataGridViewTextBoxColumn.Name = "cityidDataGridViewTextBoxColumn";
            this.cityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityidDataGridViewTextBoxColumn.Visible = false;
            // 
            // citynameDataGridViewTextBoxColumn
            // 
            this.citynameDataGridViewTextBoxColumn.DataPropertyName = "city_name";
            this.citynameDataGridViewTextBoxColumn.HeaderText = "City";
            this.citynameDataGridViewTextBoxColumn.Name = "citynameDataGridViewTextBoxColumn";
            // 
            // salonsCitiesBindingSource
            // 
            this.salonsCitiesBindingSource.DataMember = "SalonsCities";
            this.salonsCitiesBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DataSource = this.citiesBindingSource;
            this.comboBoxCity.DisplayMember = "city_name";
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(120, 88);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(208, 33);
            this.comboBoxCity.TabIndex = 1;
            this.comboBoxCity.ValueMember = "city_id";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.dataSetRentalCars1;
            // 
            // dataSetRentalCars1
            // 
            this.dataSetRentalCars1.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_search_city
            // 
            this.button_search_city.BackColor = System.Drawing.Color.CadetBlue;
            this.button_search_city.Location = new System.Drawing.Point(376, 51);
            this.button_search_city.Name = "button_search_city";
            this.button_search_city.Size = new System.Drawing.Size(140, 104);
            this.button_search_city.TabIndex = 2;
            this.button_search_city.Text = "SEARCH";
            this.button_search_city.UseVisualStyleBackColor = false;
            this.button_search_city.Click += new System.EventHandler(this.button_search_city_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(54, 91);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(49, 25);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "City";
            // 
            // salonsCitiesTableAdapter
            // 
            this.salonsCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmSalons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(611, 585);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.button_search_city);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmSalons";
            this.Text = "SalonsSearch";
            this.Load += new System.EventHandler(this.FrmSalons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonsCitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button button_search_city;
        private System.Windows.Forms.Label labelCity;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource salonsCitiesBindingSource;
        private DataSetRentalCarsTableAdapters.SalonsCitiesTableAdapter salonsCitiesTableAdapter;
        private DataSetRentalCars dataSetRentalCars1;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private DataSetRentalCarsTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn slidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slcityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sladdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn citynameDataGridViewTextBoxColumn;
    }
}