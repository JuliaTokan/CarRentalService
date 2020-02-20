namespace Lab1RentalCars
{
    partial class FindCar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caryearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtransmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.carsClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carsClassesTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsClassesTableAdapter();
            this.button_search_frm_car = new System.Windows.Forms.Button();
            this.dataTable1TableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.DataTable1TableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.carsModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.carsModelsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsModelsTableAdapter();
            this.checkBoxClass = new System.Windows.Forms.CheckBox();
            this.checkBoxModel = new System.Windows.Forms.CheckBox();
            this.checkBoxPrice = new System.Windows.Forms.CheckBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.button_free_cars = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsModelsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caridDataGridViewTextBoxColumn,
            this.carnumDataGridViewTextBoxColumn,
            this.caryearDataGridViewTextBoxColumn,
            this.cmidDataGridViewTextBoxColumn,
            this.cmbrandDataGridViewTextBoxColumn,
            this.cmbodyDataGridViewTextBoxColumn,
            this.cmtransmissionDataGridViewTextBoxColumn,
            this.ccidDataGridViewTextBoxColumn,
            this.ccnameDataGridViewTextBoxColumn,
            this.ccpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(3, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(940, 603);
            this.dataGridView1.TabIndex = 0;
            // 
            // caridDataGridViewTextBoxColumn
            // 
            this.caridDataGridViewTextBoxColumn.DataPropertyName = "car_id";
            this.caridDataGridViewTextBoxColumn.HeaderText = "car_id";
            this.caridDataGridViewTextBoxColumn.Name = "caridDataGridViewTextBoxColumn";
            this.caridDataGridViewTextBoxColumn.ReadOnly = true;
            this.caridDataGridViewTextBoxColumn.Visible = false;
            // 
            // carnumDataGridViewTextBoxColumn
            // 
            this.carnumDataGridViewTextBoxColumn.DataPropertyName = "car_num";
            this.carnumDataGridViewTextBoxColumn.HeaderText = "Car Num";
            this.carnumDataGridViewTextBoxColumn.Name = "carnumDataGridViewTextBoxColumn";
            // 
            // caryearDataGridViewTextBoxColumn
            // 
            this.caryearDataGridViewTextBoxColumn.DataPropertyName = "car_year";
            this.caryearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.caryearDataGridViewTextBoxColumn.Name = "caryearDataGridViewTextBoxColumn";
            // 
            // cmidDataGridViewTextBoxColumn
            // 
            this.cmidDataGridViewTextBoxColumn.DataPropertyName = "cm_id";
            this.cmidDataGridViewTextBoxColumn.HeaderText = "cm_id";
            this.cmidDataGridViewTextBoxColumn.Name = "cmidDataGridViewTextBoxColumn";
            this.cmidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cmidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmbrandDataGridViewTextBoxColumn
            // 
            this.cmbrandDataGridViewTextBoxColumn.DataPropertyName = "cm_brand";
            this.cmbrandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.cmbrandDataGridViewTextBoxColumn.Name = "cmbrandDataGridViewTextBoxColumn";
            // 
            // cmbodyDataGridViewTextBoxColumn
            // 
            this.cmbodyDataGridViewTextBoxColumn.DataPropertyName = "cm_body";
            this.cmbodyDataGridViewTextBoxColumn.HeaderText = "Body";
            this.cmbodyDataGridViewTextBoxColumn.Name = "cmbodyDataGridViewTextBoxColumn";
            // 
            // cmtransmissionDataGridViewTextBoxColumn
            // 
            this.cmtransmissionDataGridViewTextBoxColumn.DataPropertyName = "cm_transmission";
            this.cmtransmissionDataGridViewTextBoxColumn.HeaderText = "Transmission";
            this.cmtransmissionDataGridViewTextBoxColumn.Name = "cmtransmissionDataGridViewTextBoxColumn";
            // 
            // ccidDataGridViewTextBoxColumn
            // 
            this.ccidDataGridViewTextBoxColumn.DataPropertyName = "cc_id";
            this.ccidDataGridViewTextBoxColumn.HeaderText = "cc_id";
            this.ccidDataGridViewTextBoxColumn.Name = "ccidDataGridViewTextBoxColumn";
            this.ccidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ccidDataGridViewTextBoxColumn.Visible = false;
            // 
            // ccnameDataGridViewTextBoxColumn
            // 
            this.ccnameDataGridViewTextBoxColumn.DataPropertyName = "cc_name";
            this.ccnameDataGridViewTextBoxColumn.HeaderText = "Class";
            this.ccnameDataGridViewTextBoxColumn.Name = "ccnameDataGridViewTextBoxColumn";
            // 
            // ccpriceDataGridViewTextBoxColumn
            // 
            this.ccpriceDataGridViewTextBoxColumn.DataPropertyName = "cc_price";
            this.ccpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.ccpriceDataGridViewTextBoxColumn.Name = "ccpriceDataGridViewTextBoxColumn";
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.carsClassesBindingSource;
            this.comboBox1.DisplayMember = "cc_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(210, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(339, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "cc_id";
            // 
            // carsClassesBindingSource
            // 
            this.carsClassesBindingSource.DataMember = "CarsClasses";
            this.carsClassesBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // carsClassesTableAdapter
            // 
            this.carsClassesTableAdapter.ClearBeforeFill = true;
            // 
            // button_search_frm_car
            // 
            this.button_search_frm_car.BackColor = System.Drawing.Color.CadetBlue;
            this.button_search_frm_car.Location = new System.Drawing.Point(705, 29);
            this.button_search_frm_car.Name = "button_search_frm_car";
            this.button_search_frm_car.Size = new System.Drawing.Size(167, 131);
            this.button_search_frm_car.TabIndex = 2;
            this.button_search_frm_car.Text = "SEARCH";
            this.button_search_frm_car.UseVisualStyleBackColor = false;
            this.button_search_frm_car.Click += new System.EventHandler(this.button_search_frm_car_Click);
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.carsModelsBindingSource;
            this.comboBox2.DisplayMember = "cm_info";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(210, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(339, 33);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "cm_id";
            // 
            // carsModelsBindingSource
            // 
            this.carsModelsBindingSource.DataMember = "CarsModels";
            this.carsModelsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // textBoxMin
            // 
            this.textBoxMin.Location = new System.Drawing.Point(210, 217);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(136, 31);
            this.textBoxMin.TabIndex = 5;
            // 
            // carsModelsTableAdapter
            // 
            this.carsModelsTableAdapter.ClearBeforeFill = true;
            // 
            // checkBoxClass
            // 
            this.checkBoxClass.AutoSize = true;
            this.checkBoxClass.Location = new System.Drawing.Point(25, 24);
            this.checkBoxClass.Name = "checkBoxClass";
            this.checkBoxClass.Size = new System.Drawing.Size(138, 29);
            this.checkBoxClass.TabIndex = 9;
            this.checkBoxClass.Text = "Car Class";
            this.checkBoxClass.UseVisualStyleBackColor = true;
            // 
            // checkBoxModel
            // 
            this.checkBoxModel.AutoSize = true;
            this.checkBoxModel.Location = new System.Drawing.Point(20, 127);
            this.checkBoxModel.Name = "checkBoxModel";
            this.checkBoxModel.Size = new System.Drawing.Size(143, 29);
            this.checkBoxModel.TabIndex = 10;
            this.checkBoxModel.Text = "Car Model";
            this.checkBoxModel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrice
            // 
            this.checkBoxPrice.AutoSize = true;
            this.checkBoxPrice.Location = new System.Drawing.Point(20, 219);
            this.checkBoxPrice.Name = "checkBoxPrice";
            this.checkBoxPrice.Size = new System.Drawing.Size(168, 29);
            this.checkBoxPrice.TabIndex = 11;
            this.checkBoxPrice.Text = "Price($/hour)";
            this.checkBoxPrice.UseVisualStyleBackColor = true;
            // 
            // textBoxMax
            // 
            this.textBoxMax.Location = new System.Drawing.Point(406, 217);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(143, 31);
            this.textBoxMax.TabIndex = 12;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(364, 216);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(26, 25);
            this.label.TabIndex = 13;
            this.label.Text = "--";
            // 
            // button_free_cars
            // 
            this.button_free_cars.BackColor = System.Drawing.Color.CadetBlue;
            this.button_free_cars.Location = new System.Drawing.Point(669, 197);
            this.button_free_cars.Name = "button_free_cars";
            this.button_free_cars.Size = new System.Drawing.Size(238, 70);
            this.button_free_cars.TabIndex = 14;
            this.button_free_cars.Text = "Free cars";
            this.button_free_cars.UseVisualStyleBackColor = false;
            this.button_free_cars.Visible = false;
            this.button_free_cars.Click += new System.EventHandler(this.button_free_cars_Click);
            // 
            // FindCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1021, 988);
            this.Controls.Add(this.button_free_cars);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxMax);
            this.Controls.Add(this.checkBoxPrice);
            this.Controls.Add(this.checkBoxModel);
            this.Controls.Add(this.checkBoxClass);
            this.Controls.Add(this.textBoxMin);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button_search_frm_car);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FindCar";
            this.Text = "CarSearch";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsModelsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource carsClassesBindingSource;
        private DataSetRentalCarsTableAdapters.CarsClassesTableAdapter carsClassesTableAdapter;
        private System.Windows.Forms.Button button_search_frm_car;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSetRentalCarsTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.BindingSource carsModelsBindingSource;
        private DataSetRentalCarsTableAdapters.CarsModelsTableAdapter carsModelsTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxClass;
        private System.Windows.Forms.CheckBox checkBoxModel;
        private System.Windows.Forms.CheckBox checkBoxPrice;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caryearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtransmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_free_cars;
    }
}