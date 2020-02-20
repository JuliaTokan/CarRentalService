namespace Lab1RentalCars
{
    partial class FrmContracts
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
            this.button_search_frm_car = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxPassp = new System.Windows.Forms.TextBox();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.labelCar = new System.Windows.Forms.Label();
            this.labelCl = new System.Windows.Forms.Label();
            this.cntridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrcarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrclDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrfromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrprepayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntrinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractsCarClBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.contractsCarClTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.ContractsCarClTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsCarClBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
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
            this.cntridDataGridViewTextBoxColumn,
            this.cntrnumDataGridViewTextBoxColumn,
            this.cntrcarDataGridViewTextBoxColumn,
            this.carnumDataGridViewTextBoxColumn,
            this.clpassportDataGridViewTextBoxColumn,
            this.cntrclDataGridViewTextBoxColumn,
            this.cntrslDataGridViewTextBoxColumn,
            this.cntrfromDataGridViewTextBoxColumn,
            this.cntrtoDataGridViewTextBoxColumn,
            this.cntrprepayDataGridViewTextBoxColumn,
            this.cntrinfoDataGridViewTextBoxColumn,
            this.caridDataGridViewTextBoxColumn,
            this.clidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contractsCarClBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1013, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_search_frm_car
            // 
            this.button_search_frm_car.BackColor = System.Drawing.Color.CadetBlue;
            this.button_search_frm_car.ForeColor = System.Drawing.Color.Black;
            this.button_search_frm_car.Location = new System.Drawing.Point(785, 57);
            this.button_search_frm_car.Name = "button_search_frm_car";
            this.button_search_frm_car.Size = new System.Drawing.Size(167, 131);
            this.button_search_frm_car.TabIndex = 3;
            this.button_search_frm_car.Text = "Search";
            this.button_search_frm_car.UseVisualStyleBackColor = false;
            this.button_search_frm_car.Click += new System.EventHandler(this.button_search_frm_car_Click);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(256, 57);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(342, 31);
            this.textBoxNum.TabIndex = 4;
            // 
            // textBoxPassp
            // 
            this.textBoxPassp.Location = new System.Drawing.Point(256, 227);
            this.textBoxPassp.Name = "textBoxPassp";
            this.textBoxPassp.Size = new System.Drawing.Size(342, 31);
            this.textBoxPassp.TabIndex = 5;
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(256, 141);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(342, 31);
            this.textBoxCar.TabIndex = 6;
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Location = new System.Drawing.Point(64, 63);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(140, 25);
            this.labelNum.TabIndex = 7;
            this.labelNum.Text = "Contract num";
            // 
            // labelCar
            // 
            this.labelCar.AutoSize = true;
            this.labelCar.Location = new System.Drawing.Point(64, 147);
            this.labelCar.Name = "labelCar";
            this.labelCar.Size = new System.Drawing.Size(93, 25);
            this.labelCar.TabIndex = 8;
            this.labelCar.Text = "Car num";
            // 
            // labelCl
            // 
            this.labelCl.AutoSize = true;
            this.labelCl.Location = new System.Drawing.Point(64, 233);
            this.labelCl.Name = "labelCl";
            this.labelCl.Size = new System.Drawing.Size(171, 25);
            this.labelCl.TabIndex = 9;
            this.labelCl.Text = "Client\'s passport";
            // 
            // cntridDataGridViewTextBoxColumn
            // 
            this.cntridDataGridViewTextBoxColumn.DataPropertyName = "cntr_id";
            this.cntridDataGridViewTextBoxColumn.HeaderText = "cntr_id";
            this.cntridDataGridViewTextBoxColumn.Name = "cntridDataGridViewTextBoxColumn";
            this.cntridDataGridViewTextBoxColumn.ReadOnly = true;
            this.cntridDataGridViewTextBoxColumn.Visible = false;
            // 
            // cntrnumDataGridViewTextBoxColumn
            // 
            this.cntrnumDataGridViewTextBoxColumn.DataPropertyName = "cntr_num";
            this.cntrnumDataGridViewTextBoxColumn.HeaderText = "Contract Num";
            this.cntrnumDataGridViewTextBoxColumn.Name = "cntrnumDataGridViewTextBoxColumn";
            // 
            // cntrcarDataGridViewTextBoxColumn
            // 
            this.cntrcarDataGridViewTextBoxColumn.DataPropertyName = "cntr_car";
            this.cntrcarDataGridViewTextBoxColumn.HeaderText = "cntr_car";
            this.cntrcarDataGridViewTextBoxColumn.Name = "cntrcarDataGridViewTextBoxColumn";
            this.cntrcarDataGridViewTextBoxColumn.Visible = false;
            // 
            // carnumDataGridViewTextBoxColumn
            // 
            this.carnumDataGridViewTextBoxColumn.DataPropertyName = "car_num";
            this.carnumDataGridViewTextBoxColumn.HeaderText = "Car";
            this.carnumDataGridViewTextBoxColumn.Name = "carnumDataGridViewTextBoxColumn";
            // 
            // clpassportDataGridViewTextBoxColumn
            // 
            this.clpassportDataGridViewTextBoxColumn.DataPropertyName = "cl_passport";
            this.clpassportDataGridViewTextBoxColumn.HeaderText = "Client";
            this.clpassportDataGridViewTextBoxColumn.Name = "clpassportDataGridViewTextBoxColumn";
            // 
            // cntrclDataGridViewTextBoxColumn
            // 
            this.cntrclDataGridViewTextBoxColumn.DataPropertyName = "cntr_cl";
            this.cntrclDataGridViewTextBoxColumn.HeaderText = "cntr_cl";
            this.cntrclDataGridViewTextBoxColumn.Name = "cntrclDataGridViewTextBoxColumn";
            this.cntrclDataGridViewTextBoxColumn.Visible = false;
            // 
            // cntrslDataGridViewTextBoxColumn
            // 
            this.cntrslDataGridViewTextBoxColumn.DataPropertyName = "cntr_sl";
            this.cntrslDataGridViewTextBoxColumn.HeaderText = "cntr_sl";
            this.cntrslDataGridViewTextBoxColumn.Name = "cntrslDataGridViewTextBoxColumn";
            this.cntrslDataGridViewTextBoxColumn.Visible = false;
            // 
            // cntrfromDataGridViewTextBoxColumn
            // 
            this.cntrfromDataGridViewTextBoxColumn.DataPropertyName = "cntr_from";
            this.cntrfromDataGridViewTextBoxColumn.HeaderText = "From";
            this.cntrfromDataGridViewTextBoxColumn.Name = "cntrfromDataGridViewTextBoxColumn";
            // 
            // cntrtoDataGridViewTextBoxColumn
            // 
            this.cntrtoDataGridViewTextBoxColumn.DataPropertyName = "cntr_to";
            this.cntrtoDataGridViewTextBoxColumn.HeaderText = "To";
            this.cntrtoDataGridViewTextBoxColumn.Name = "cntrtoDataGridViewTextBoxColumn";
            // 
            // cntrprepayDataGridViewTextBoxColumn
            // 
            this.cntrprepayDataGridViewTextBoxColumn.DataPropertyName = "cntr_prepay";
            this.cntrprepayDataGridViewTextBoxColumn.HeaderText = "Prepay";
            this.cntrprepayDataGridViewTextBoxColumn.Name = "cntrprepayDataGridViewTextBoxColumn";
            // 
            // cntrinfoDataGridViewTextBoxColumn
            // 
            this.cntrinfoDataGridViewTextBoxColumn.DataPropertyName = "cntr_info";
            this.cntrinfoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.cntrinfoDataGridViewTextBoxColumn.Name = "cntrinfoDataGridViewTextBoxColumn";
            // 
            // caridDataGridViewTextBoxColumn
            // 
            this.caridDataGridViewTextBoxColumn.DataPropertyName = "car_id";
            this.caridDataGridViewTextBoxColumn.HeaderText = "car_id";
            this.caridDataGridViewTextBoxColumn.Name = "caridDataGridViewTextBoxColumn";
            this.caridDataGridViewTextBoxColumn.ReadOnly = true;
            this.caridDataGridViewTextBoxColumn.Visible = false;
            // 
            // clidDataGridViewTextBoxColumn
            // 
            this.clidDataGridViewTextBoxColumn.DataPropertyName = "cl_id";
            this.clidDataGridViewTextBoxColumn.HeaderText = "cl_id";
            this.clidDataGridViewTextBoxColumn.Name = "clidDataGridViewTextBoxColumn";
            this.clidDataGridViewTextBoxColumn.ReadOnly = true;
            this.clidDataGridViewTextBoxColumn.Visible = false;
            // 
            // contractsCarClBindingSource
            // 
            this.contractsCarClBindingSource.DataMember = "ContractsCarCl";
            this.contractsCarClBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractsCarClTableAdapter
            // 
            this.contractsCarClTableAdapter.ClearBeforeFill = true;
            // 
            // FrmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1125, 1017);
            this.Controls.Add(this.labelCl);
            this.Controls.Add(this.labelCar);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.textBoxPassp);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.button_search_frm_car);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmContracts";
            this.Text = "ContractsSearch";
            this.Load += new System.EventHandler(this.FrmContracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractsCarClBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_search_frm_car;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource contractsCarClBindingSource;
        private DataSetRentalCarsTableAdapters.ContractsCarClTableAdapter contractsCarClTableAdapter;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxPassp;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.Label labelCar;
        private System.Windows.Forms.Label labelCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrcarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrclDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrfromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrprepayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntrinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
    }
}