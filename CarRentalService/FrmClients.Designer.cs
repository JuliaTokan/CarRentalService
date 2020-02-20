namespace Lab1RentalCars
{
    partial class FrmClients
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
            this.clidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpassportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentalCars = new Lab1RentalCars.DataSetRentalCars();
            this.textBoxPassport = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelPassport = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.button_search_frm_client = new System.Windows.Forms.Button();
            this.clientsTableAdapter = new Lab1RentalCars.DataSetRentalCarsTableAdapters.ClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
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
            this.clidDataGridViewTextBoxColumn,
            this.clpassportDataGridViewTextBoxColumn,
            this.clnameDataGridViewTextBoxColumn,
            this.clsurnameDataGridViewTextBoxColumn,
            this.clinfoDataGridViewTextBoxColumn,
            this.clphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 322);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(873, 534);
            this.dataGridView1.TabIndex = 0;
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
            this.clpassportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.clpassportDataGridViewTextBoxColumn.Name = "clpassportDataGridViewTextBoxColumn";
            // 
            // clnameDataGridViewTextBoxColumn
            // 
            this.clnameDataGridViewTextBoxColumn.DataPropertyName = "cl_name";
            this.clnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.clnameDataGridViewTextBoxColumn.Name = "clnameDataGridViewTextBoxColumn";
            // 
            // clsurnameDataGridViewTextBoxColumn
            // 
            this.clsurnameDataGridViewTextBoxColumn.DataPropertyName = "cl_surname";
            this.clsurnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.clsurnameDataGridViewTextBoxColumn.Name = "clsurnameDataGridViewTextBoxColumn";
            // 
            // clinfoDataGridViewTextBoxColumn
            // 
            this.clinfoDataGridViewTextBoxColumn.DataPropertyName = "cl_info";
            this.clinfoDataGridViewTextBoxColumn.HeaderText = "Info";
            this.clinfoDataGridViewTextBoxColumn.Name = "clinfoDataGridViewTextBoxColumn";
            // 
            // clphoneDataGridViewTextBoxColumn
            // 
            this.clphoneDataGridViewTextBoxColumn.DataPropertyName = "cl_phone";
            this.clphoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.clphoneDataGridViewTextBoxColumn.Name = "clphoneDataGridViewTextBoxColumn";
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
            // textBoxPassport
            // 
            this.textBoxPassport.Location = new System.Drawing.Point(206, 43);
            this.textBoxPassport.Name = "textBoxPassport";
            this.textBoxPassport.Size = new System.Drawing.Size(344, 31);
            this.textBoxPassport.TabIndex = 1;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(206, 225);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(344, 31);
            this.textBoxTel.TabIndex = 2;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(206, 135);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(344, 31);
            this.textBoxSurname.TabIndex = 3;
            // 
            // labelPassport
            // 
            this.labelPassport.AutoSize = true;
            this.labelPassport.Location = new System.Drawing.Point(90, 49);
            this.labelPassport.Name = "labelPassport";
            this.labelPassport.Size = new System.Drawing.Size(97, 25);
            this.labelPassport.TabIndex = 4;
            this.labelPassport.Text = "Passport";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(89, 141);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(98, 25);
            this.labelSurname.TabIndex = 5;
            this.labelSurname.Text = "Surname";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(73, 231);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(114, 25);
            this.labelTel.TabIndex = 6;
            this.labelTel.Text = "Telephone";
            // 
            // button_search_frm_client
            // 
            this.button_search_frm_client.BackColor = System.Drawing.Color.CadetBlue;
            this.button_search_frm_client.Location = new System.Drawing.Point(682, 88);
            this.button_search_frm_client.Name = "button_search_frm_client";
            this.button_search_frm_client.Size = new System.Drawing.Size(167, 131);
            this.button_search_frm_client.TabIndex = 7;
            this.button_search_frm_client.Text = "Search";
            this.button_search_frm_client.UseVisualStyleBackColor = false;
            this.button_search_frm_client.Click += new System.EventHandler(this.button_search_frm_client_Click);
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(983, 939);
            this.Controls.Add(this.button_search_frm_client);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelPassport);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.textBoxPassport);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmClients";
            this.Text = "ClientsSearch";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentalCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxPassport;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelPassport;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Button button_search_frm_client;
        private DataSetRentalCars dataSetRentalCars;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DataSetRentalCarsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpassportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clphoneDataGridViewTextBoxColumn;
    }
}