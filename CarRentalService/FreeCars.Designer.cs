namespace Lab1RentalCars
{
    partial class FreeCars
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
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.Find = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.caridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cminfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caryearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.freeCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.freeCarsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.FreeCarsTableAdapter();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(116, 103);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(301, 31);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.CadetBlue;
            this.Find.Location = new System.Drawing.Point(887, 69);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(236, 103);
            this.Find.TabIndex = 3;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caridDataGridViewTextBoxColumn,
            this.carnumDataGridViewTextBoxColumn,
            this.cminfoDataGridViewTextBoxColumn,
            this.ccnameDataGridViewTextBoxColumn,
            this.caryearDataGridViewTextBoxColumn,
            this.carinfoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.DataSource = this.freeCarsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1118, 676);
            this.dataGridView1.TabIndex = 4;
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
            this.carnumDataGridViewTextBoxColumn.HeaderText = "car_num";
            this.carnumDataGridViewTextBoxColumn.Name = "carnumDataGridViewTextBoxColumn";
            // 
            // cminfoDataGridViewTextBoxColumn
            // 
            this.cminfoDataGridViewTextBoxColumn.DataPropertyName = "cm_info";
            this.cminfoDataGridViewTextBoxColumn.HeaderText = "cm_info";
            this.cminfoDataGridViewTextBoxColumn.Name = "cminfoDataGridViewTextBoxColumn";
            // 
            // ccnameDataGridViewTextBoxColumn
            // 
            this.ccnameDataGridViewTextBoxColumn.DataPropertyName = "cc_name";
            this.ccnameDataGridViewTextBoxColumn.HeaderText = "cc_name";
            this.ccnameDataGridViewTextBoxColumn.Name = "ccnameDataGridViewTextBoxColumn";
            // 
            // caryearDataGridViewTextBoxColumn
            // 
            this.caryearDataGridViewTextBoxColumn.DataPropertyName = "car_year";
            this.caryearDataGridViewTextBoxColumn.HeaderText = "car_year";
            this.caryearDataGridViewTextBoxColumn.Name = "caryearDataGridViewTextBoxColumn";
            // 
            // carinfoDataGridViewTextBoxColumn
            // 
            this.carinfoDataGridViewTextBoxColumn.DataPropertyName = "car_info";
            this.carinfoDataGridViewTextBoxColumn.HeaderText = "car_info";
            this.carinfoDataGridViewTextBoxColumn.Name = "carinfoDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "car_model";
            this.dataGridViewTextBoxColumn1.HeaderText = "car_model";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "car_class";
            this.dataGridViewTextBoxColumn2.HeaderText = "car_class";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "cc_id";
            this.dataGridViewTextBoxColumn3.HeaderText = "cc_id";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "cm_id";
            this.dataGridViewTextBoxColumn4.HeaderText = "cm_id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cm_body";
            this.dataGridViewTextBoxColumn5.HeaderText = "cm_body";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cm_transmission";
            this.dataGridViewTextBoxColumn6.HeaderText = "cm_transmission";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // freeCarsBindingSource
            // 
            this.freeCarsBindingSource.DataMember = "FreeCars";
            this.freeCarsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // freeCarsTableAdapter
            // 
            this.freeCarsTableAdapter.ClearBeforeFill = true;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(503, 103);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(301, 31);
            this.dateTimePickerTo.TabIndex = 5;
            // 
            // FreeCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1198, 940);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "FreeCars";
            this.Text = "Free Cars";
            this.Load += new System.EventHandler(this.FreeCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn carmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbodyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmtransmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource freeCarsBindingSource;
        private DataSetRentalCarsTableAdapters.FreeCarsTableAdapter freeCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cminfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caryearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    }
}