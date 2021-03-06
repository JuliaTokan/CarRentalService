﻿namespace Lab1RentalCars
{
    partial class ClientsByClient
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
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.clientsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.ClientsTableAdapter();
            this.Find = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1075, 621);
            this.dataGridView1.TabIndex = 0;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.dataSetRentalCars;
            // 
            // dataSetRentalCars
            // 
            this.dataSetRentalCars.DataSetName = "DataSetRentalCars";
            this.dataSetRentalCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.DataSource = this.clientsBindingSource;
            this.comboBoxClient.DisplayMember = "cl_surname";
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(373, 132);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(379, 33);
            this.comboBoxClient.TabIndex = 1;
            this.comboBoxClient.ValueMember = "cl_id";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Find
            // 
            this.Find.BackColor = System.Drawing.Color.CadetBlue;
            this.Find.Location = new System.Drawing.Point(853, 85);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(215, 118);
            this.Find.TabIndex = 2;
            this.Find.Text = "Find";
            this.Find.UseVisualStyleBackColor = false;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = " Знайти клієнтів, що принаймі орендували ті ж авто що і клієнт:";
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
            // ClientsByClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1161, 906);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientsByClient";
            this.Text = "ClientsByClient";
            this.Load += new System.EventHandler(this.ClientsByClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DataSetRentalCarsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clphoneDataGridViewTextBoxColumn;
    }
}