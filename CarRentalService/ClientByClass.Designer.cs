namespace Lab1RentalCars
{
    partial class ClientByClass
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
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.carsClassesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.ClientsTableAdapter();
            this.carsClassesTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.CarsClassesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carsClassesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DataSource = this.carsClassesBindingSource;
            this.comboBoxClass.DisplayMember = "cc_name";
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(406, 142);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(397, 33);
            this.comboBoxClass.TabIndex = 0;
            this.comboBoxClass.ValueMember = "cc_name";
            // 
            // carsClassesBindingSource
            // 
            this.carsClassesBindingSource.DataMember = "CarsClasses";
            this.carsClassesBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.CadetBlue;
            this.Find.Location = new System.Drawing.Point(925, 77);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(239, 143);
            this.Find.TabIndex = 1;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(772, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Знайти клієнтів, що орендовували авто принаймі класу:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidDataGridViewTextBoxColumn,
            this.clpassportDataGridViewTextBoxColumn,
            this.clnameDataGridViewTextBoxColumn,
            this.clsurnameDataGridViewTextBoxColumn,
            this.clinfoDataGridViewTextBoxColumn,
            this.clphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(64, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1150, 668);
            this.dataGridView1.TabIndex = 3;
            // 
            // clidDataGridViewTextBoxColumn
            // 
            this.clidDataGridViewTextBoxColumn.DataPropertyName = "cl_id";
            this.clidDataGridViewTextBoxColumn.HeaderText = "cl_id";
            this.clidDataGridViewTextBoxColumn.Name = "clidDataGridViewTextBoxColumn";
            this.clidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clidDataGridViewTextBoxColumn.Visible = false;
            // 
            // clpassportDataGridViewTextBoxColumn
            // 
            this.clpassportDataGridViewTextBoxColumn.DataPropertyName = "cl_passport";
            this.clpassportDataGridViewTextBoxColumn.HeaderText = "cl_passport";
            this.clpassportDataGridViewTextBoxColumn.Name = "clpassportDataGridViewTextBoxColumn";
            this.clpassportDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clnameDataGridViewTextBoxColumn
            // 
            this.clnameDataGridViewTextBoxColumn.DataPropertyName = "cl_name";
            this.clnameDataGridViewTextBoxColumn.HeaderText = "cl_name";
            this.clnameDataGridViewTextBoxColumn.Name = "clnameDataGridViewTextBoxColumn";
            this.clnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clsurnameDataGridViewTextBoxColumn
            // 
            this.clsurnameDataGridViewTextBoxColumn.DataPropertyName = "cl_surname";
            this.clsurnameDataGridViewTextBoxColumn.HeaderText = "cl_surname";
            this.clsurnameDataGridViewTextBoxColumn.Name = "clsurnameDataGridViewTextBoxColumn";
            this.clsurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clinfoDataGridViewTextBoxColumn
            // 
            this.clinfoDataGridViewTextBoxColumn.DataPropertyName = "cl_info";
            this.clinfoDataGridViewTextBoxColumn.HeaderText = "cl_info";
            this.clinfoDataGridViewTextBoxColumn.Name = "clinfoDataGridViewTextBoxColumn";
            this.clinfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clphoneDataGridViewTextBoxColumn
            // 
            this.clphoneDataGridViewTextBoxColumn.DataPropertyName = "cl_phone";
            this.clphoneDataGridViewTextBoxColumn.HeaderText = "cl_phone";
            this.clphoneDataGridViewTextBoxColumn.Name = "clphoneDataGridViewTextBoxColumn";
            this.clphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // carsClassesTableAdapter
            // 
            this.carsClassesTableAdapter.ClearBeforeFill = true;
            // 
            // ClientByClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1285, 992);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.comboBoxClass);
            this.Name = "ClientByClass";
            this.Text = "ClientByClass";
            this.Load += new System.EventHandler(this.ClientByClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carsClassesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DataSetRentalCarsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource carsClassesBindingSource;
        private DataSetRentalCarsTableAdapters.CarsClassesTableAdapter carsClassesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clphoneDataGridViewTextBoxColumn;
    }
}