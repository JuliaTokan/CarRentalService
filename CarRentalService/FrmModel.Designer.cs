namespace Lab1RentalCars
{
    partial class FrmModel
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
            this.cmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbodyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmtransmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cminfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.button_search_frm_model = new System.Windows.Forms.Button();
            this.comboBoxBrand = new System.Windows.Forms.ComboBox();
            this.carsBrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxTrans = new System.Windows.Forms.ComboBox();
            this.transBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars4 = new Lab1RentalCars.DataSetRentalCars();
            this.carsModelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxBody = new System.Windows.Forms.ComboBox();
            this.bodyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars3 = new Lab1RentalCars.DataSetRentalCars();
            this.checkBoxBrand = new System.Windows.Forms.CheckBox();
            this.checkBoxBody = new System.Windows.Forms.CheckBox();
            this.checkBoxTrans = new System.Windows.Forms.CheckBox();
            this.modelsBrandsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.ModelsBrandsTableAdapter();
            this.carsBrandsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsBrandsTableAdapter();
            this.carsModelsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsModelsTableAdapter();
            this.dataSetRentalCars1 = new Lab1RentalCars.DataSetRentalCars();
            this.dataSetRentalCars2 = new Lab1RentalCars.DataSetRentalCars();
            this.bodyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bodyTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.BodyTableAdapter();
            this.transTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.TransTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsModelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmidDataGridViewTextBoxColumn,
            this.cmbrandDataGridViewTextBoxColumn,
            this.cmbodyDataGridViewTextBoxColumn,
            this.cmtransmissionDataGridViewTextBoxColumn,
            this.cminfoDataGridViewTextBoxColumn,
            this.cbidDataGridViewTextBoxColumn,
            this.cbnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.modelsBrandsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(859, 588);
            this.dataGridView1.TabIndex = 0;
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
            this.cmbrandDataGridViewTextBoxColumn.HeaderText = "cm_brand";
            this.cmbrandDataGridViewTextBoxColumn.Name = "cmbrandDataGridViewTextBoxColumn";
            this.cmbrandDataGridViewTextBoxColumn.Visible = false;
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
            // cminfoDataGridViewTextBoxColumn
            // 
            this.cminfoDataGridViewTextBoxColumn.DataPropertyName = "cm_info";
            this.cminfoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.cminfoDataGridViewTextBoxColumn.Name = "cminfoDataGridViewTextBoxColumn";
            // 
            // cbidDataGridViewTextBoxColumn
            // 
            this.cbidDataGridViewTextBoxColumn.DataPropertyName = "cb_id";
            this.cbidDataGridViewTextBoxColumn.HeaderText = "cb_id";
            this.cbidDataGridViewTextBoxColumn.Name = "cbidDataGridViewTextBoxColumn";
            this.cbidDataGridViewTextBoxColumn.ReadOnly = true;
            this.cbidDataGridViewTextBoxColumn.Visible = false;
            // 
            // cbnameDataGridViewTextBoxColumn
            // 
            this.cbnameDataGridViewTextBoxColumn.DataPropertyName = "cb_name";
            this.cbnameDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.cbnameDataGridViewTextBoxColumn.Name = "cbnameDataGridViewTextBoxColumn";
            // 
            // modelsBrandsBindingSource
            // 
            this.modelsBrandsBindingSource.DataMember = "ModelsBrands";
            this.modelsBrandsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_search_frm_model
            // 
            this.button_search_frm_model.BackColor = System.Drawing.Color.CadetBlue;
            this.button_search_frm_model.Location = new System.Drawing.Point(678, 100);
            this.button_search_frm_model.Name = "button_search_frm_model";
            this.button_search_frm_model.Size = new System.Drawing.Size(167, 131);
            this.button_search_frm_model.TabIndex = 3;
            this.button_search_frm_model.Text = "Search";
            this.button_search_frm_model.UseVisualStyleBackColor = false;
            this.button_search_frm_model.Click += new System.EventHandler(this.button_search_frm_model_Click);
            // 
            // comboBoxBrand
            // 
            this.comboBoxBrand.DataSource = this.carsBrandsBindingSource;
            this.comboBoxBrand.DisplayMember = "cb_name";
            this.comboBoxBrand.FormattingEnabled = true;
            this.comboBoxBrand.Location = new System.Drawing.Point(207, 58);
            this.comboBoxBrand.Name = "comboBoxBrand";
            this.comboBoxBrand.Size = new System.Drawing.Size(325, 33);
            this.comboBoxBrand.TabIndex = 4;
            this.comboBoxBrand.ValueMember = "cb_id";
            // 
            // carsBrandsBindingSource
            // 
            this.carsBrandsBindingSource.DataMember = "CarsBrands";
            this.carsBrandsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // comboBoxTrans
            // 
            this.comboBoxTrans.DataSource = this.transBindingSource;
            this.comboBoxTrans.DisplayMember = "cm_transmission";
            this.comboBoxTrans.FormattingEnabled = true;
            this.comboBoxTrans.Location = new System.Drawing.Point(207, 214);
            this.comboBoxTrans.Name = "comboBoxTrans";
            this.comboBoxTrans.Size = new System.Drawing.Size(325, 33);
            this.comboBoxTrans.TabIndex = 5;
            this.comboBoxTrans.ValueMember = "cm_transmission";
            // 
            // transBindingSource
            // 
            this.transBindingSource.DataMember = "Trans";
            this.transBindingSource.DataSource = this.dataSetRentalCars4;
            // 
            // dataSetRentalCars4
            // 
            this.dataSetRentalCars4.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carsModelsBindingSource
            // 
            this.carsModelsBindingSource.DataMember = "CarsModels";
            this.carsModelsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // comboBoxBody
            // 
            this.comboBoxBody.DataSource = this.bodyBindingSource1;
            this.comboBoxBody.DisplayMember = "cm_body";
            this.comboBoxBody.FormattingEnabled = true;
            this.comboBoxBody.Location = new System.Drawing.Point(207, 135);
            this.comboBoxBody.Name = "comboBoxBody";
            this.comboBoxBody.Size = new System.Drawing.Size(325, 33);
            this.comboBoxBody.TabIndex = 6;
            this.comboBoxBody.ValueMember = "cm_body";
            // 
            // bodyBindingSource1
            // 
            this.bodyBindingSource1.DataMember = "Body";
            this.bodyBindingSource1.DataSource = this.dataSetRentalCars3;
            // 
            // dataSetRentalCars3
            // 
            this.dataSetRentalCars3.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // checkBoxBrand
            // 
            this.checkBoxBrand.AutoSize = true;
            this.checkBoxBrand.Location = new System.Drawing.Point(29, 62);
            this.checkBoxBrand.Name = "checkBoxBrand";
            this.checkBoxBrand.Size = new System.Drawing.Size(101, 29);
            this.checkBoxBrand.TabIndex = 7;
            this.checkBoxBrand.Text = "Brand";
            this.checkBoxBrand.UseVisualStyleBackColor = true;
            // 
            // checkBoxBody
            // 
            this.checkBoxBody.AutoSize = true;
            this.checkBoxBody.Location = new System.Drawing.Point(29, 139);
            this.checkBoxBody.Name = "checkBoxBody";
            this.checkBoxBody.Size = new System.Drawing.Size(93, 29);
            this.checkBoxBody.TabIndex = 8;
            this.checkBoxBody.Text = "Body";
            this.checkBoxBody.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrans
            // 
            this.checkBoxTrans.AutoSize = true;
            this.checkBoxTrans.Location = new System.Drawing.Point(29, 218);
            this.checkBoxTrans.Name = "checkBoxTrans";
            this.checkBoxTrans.Size = new System.Drawing.Size(172, 29);
            this.checkBoxTrans.TabIndex = 9;
            this.checkBoxTrans.Text = "Transmission";
            this.checkBoxTrans.UseVisualStyleBackColor = true;
            // 
            // modelsBrandsTableAdapter
            // 
            this.modelsBrandsTableAdapter.ClearBeforeFill = true;
            // 
            // carsBrandsTableAdapter
            // 
            this.carsBrandsTableAdapter.ClearBeforeFill = true;
            // 
            // carsModelsTableAdapter
            // 
            this.carsModelsTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetRentalCars1
            // 
            this.dataSetRentalCars1.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSetRentalCars2
            // 
            this.dataSetRentalCars2.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bodyBindingSource
            // 
            this.bodyBindingSource.DataMember = "Body";
            this.bodyBindingSource.DataSource = this.dataSetRentalCars2;
            // 
            // bodyTableAdapter
            // 
            this.bodyTableAdapter.ClearBeforeFill = true;
            // 
            // transTableAdapter
            // 
            this.transTableAdapter.ClearBeforeFill = true;
            // 
            // FrmModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(963, 996);
            this.Controls.Add(this.checkBoxTrans);
            this.Controls.Add(this.checkBoxBody);
            this.Controls.Add(this.checkBoxBrand);
            this.Controls.Add(this.comboBoxBody);
            this.Controls.Add(this.comboBoxTrans);
            this.Controls.Add(this.comboBoxBrand);
            this.Controls.Add(this.button_search_frm_model);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmModel";
            this.Text = "ModelsSearch";
            this.Load += new System.EventHandler(this.FrmModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsBrandsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carsModelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_search_frm_model;
        private System.Windows.Forms.ComboBox comboBoxBrand;
        private System.Windows.Forms.ComboBox comboBoxTrans;
        private System.Windows.Forms.ComboBox comboBoxBody;
        private System.Windows.Forms.CheckBox checkBoxBrand;
        private System.Windows.Forms.CheckBox checkBoxBody;
        private System.Windows.Forms.CheckBox checkBoxTrans;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource modelsBrandsBindingSource;
        private DataSetRentalCarsTableAdapters.ModelsBrandsTableAdapter modelsBrandsTableAdapter;
        private System.Windows.Forms.BindingSource carsBrandsBindingSource;
        private DataSetRentalCarsTableAdapters.CarsBrandsTableAdapter carsBrandsTableAdapter;
        private System.Windows.Forms.BindingSource carsModelsBindingSource;
        private DataSetRentalCarsTableAdapters.CarsModelsTableAdapter carsModelsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtransmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cminfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbnameDataGridViewTextBoxColumn;
        private DataSetRentalCars dataSetRentalCars1;
        private DataSetRentalCars dataSetRentalCars2;
        private System.Windows.Forms.BindingSource bodyBindingSource;
        private DataSetRentalCarsTableAdapters.BodyTableAdapter bodyTableAdapter;
        private DataSetRentalCars dataSetRentalCars3;
        private System.Windows.Forms.BindingSource bodyBindingSource1;
        private DataSetRentalCars dataSetRentalCars4;
        private System.Windows.Forms.BindingSource transBindingSource;
        private DataSetRentalCarsTableAdapters.TransTableAdapter transTableAdapter;
    }
}