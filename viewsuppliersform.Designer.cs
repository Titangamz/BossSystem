
namespace bosssystem1
{
    partial class viewsuppliersform
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
            this.dataSetInvoice1 = new bosssystem1.DataSetInvoice();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.supplierTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.SupplierTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.suppsearchtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuppIDtxt = new System.Windows.Forms.TextBox();
            this.SuppNametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuppNumtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuppMailtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuppAddtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetInvoice1
            // 
            this.dataSetInvoice1.DataSetName = "DataSetInvoice";
            this.dataSetInvoice1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.supplierNumberDataGridViewTextBoxColumn,
            this.supplierEmailDataGridViewTextBoxColumn,
            this.supplierAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1312, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNumberDataGridViewTextBoxColumn
            // 
            this.supplierNumberDataGridViewTextBoxColumn.DataPropertyName = "SupplierNumber";
            this.supplierNumberDataGridViewTextBoxColumn.HeaderText = "SupplierNumber";
            this.supplierNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNumberDataGridViewTextBoxColumn.Name = "supplierNumberDataGridViewTextBoxColumn";
            this.supplierNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierEmailDataGridViewTextBoxColumn
            // 
            this.supplierEmailDataGridViewTextBoxColumn.DataPropertyName = "SupplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.HeaderText = "SupplierEmail";
            this.supplierEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierEmailDataGridViewTextBoxColumn.Name = "supplierEmailDataGridViewTextBoxColumn";
            this.supplierEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierAddressDataGridViewTextBoxColumn
            // 
            this.supplierAddressDataGridViewTextBoxColumn.DataPropertyName = "SupplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.HeaderText = "SupplierAddress";
            this.supplierAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierAddressDataGridViewTextBoxColumn.Name = "supplierAddressDataGridViewTextBoxColumn";
            this.supplierAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search For Supplier Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // suppsearchtxt
            // 
            this.suppsearchtxt.Location = new System.Drawing.Point(404, 35);
            this.suppsearchtxt.Name = "suppsearchtxt";
            this.suppsearchtxt.Size = new System.Drawing.Size(156, 22);
            this.suppsearchtxt.TabIndex = 2;
            this.suppsearchtxt.TextChanged += new System.EventHandler(this.suppsearchtxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Supplier ID";
            // 
            // SuppIDtxt
            // 
            this.SuppIDtxt.Location = new System.Drawing.Point(118, 476);
            this.SuppIDtxt.Name = "SuppIDtxt";
            this.SuppIDtxt.Size = new System.Drawing.Size(201, 22);
            this.SuppIDtxt.TabIndex = 4;
            // 
            // SuppNametxt
            // 
            this.SuppNametxt.Location = new System.Drawing.Point(517, 476);
            this.SuppNametxt.Name = "SuppNametxt";
            this.SuppNametxt.Size = new System.Drawing.Size(201, 22);
            this.SuppNametxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier Name";
            // 
            // SuppNumtxt
            // 
            this.SuppNumtxt.Location = new System.Drawing.Point(957, 478);
            this.SuppNumtxt.Name = "SuppNumtxt";
            this.SuppNumtxt.Size = new System.Drawing.Size(201, 22);
            this.SuppNumtxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(837, 483);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Supplier Number";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SuppMailtxt
            // 
            this.SuppMailtxt.Location = new System.Drawing.Point(118, 565);
            this.SuppMailtxt.Name = "SuppMailtxt";
            this.SuppMailtxt.Size = new System.Drawing.Size(201, 22);
            this.SuppMailtxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 570);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Supplier Email";
            // 
            // SuppAddtxt
            // 
            this.SuppAddtxt.Location = new System.Drawing.Point(517, 565);
            this.SuppAddtxt.Name = "SuppAddtxt";
            this.SuppAddtxt.Size = new System.Drawing.Size(201, 22);
            this.SuppAddtxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 570);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Supplier Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Supplier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1027, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Update Supplier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "SUPPLIERS";
            // 
            // viewsuppliersform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 669);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SuppAddtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SuppMailtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SuppNumtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SuppNametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SuppIDtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.suppsearchtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "viewsuppliersform";
            this.Text = "SUPPLIERS";
            this.Load += new System.EventHandler(this.viewsuppliersform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetInvoice dataSetInvoice1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private G13Wst2024DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox suppsearchtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SuppIDtxt;
        private System.Windows.Forms.TextBox SuppNametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SuppNumtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SuppMailtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SuppAddtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}