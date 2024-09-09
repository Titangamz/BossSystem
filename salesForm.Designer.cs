
namespace bosssystem1
{
    partial class salesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.saledatagrid = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInvoice = new bosssystem1.DataSetInvoice();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.custdatagrid = new System.Windows.Forms.DataGridView();
            this.invdatagrid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.ordtotaltxt = new System.Windows.Forms.TextBox();
            this.deleterowsbtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.saleorderTableAdapter = new bosssystem1.DataSetInvoiceTableAdapters.saleorderTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerSurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemVatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.PartsTableTableAdapter();
            this.customerTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.CustomerTableAdapter();
            this.salebkTableAdapter1 = new bosssystem1.G13Wst2024DataSetTableAdapters.SalebkTableAdapter();
            this.overallsalesTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.OverallsalesTableAdapter();
            this.itemSaleTableAdapter1 = new bosssystem1.G13Wst2024DataSetTableAdapters.ItemSaleTableAdapter();
            this.custPaymentsTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.CustPaymentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saledatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleorderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALES";
            // 
            // saledatagrid
            // 
            this.saledatagrid.AutoGenerateColumns = false;
            this.saledatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saledatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn1,
            this.partNoDataGridViewTextBoxColumn1,
            this.itemNameDataGridViewTextBoxColumn1,
            this.unitPriceDataGridViewTextBoxColumn,
            this.Quantity,
            this.RowTotal});
            this.saledatagrid.DataSource = this.saleorderBindingSource;
            this.saledatagrid.Location = new System.Drawing.Point(12, 404);
            this.saledatagrid.Name = "saledatagrid";
            this.saledatagrid.RowHeadersWidth = 51;
            this.saledatagrid.RowTemplate.Height = 24;
            this.saledatagrid.Size = new System.Drawing.Size(1312, 184);
            this.saledatagrid.TabIndex = 1;
            this.saledatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saledatagrid_CellContentClick);
            this.saledatagrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.saledatagrid_CellValueChanged);
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            this.customerNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // partNoDataGridViewTextBoxColumn1
            // 
            this.partNoDataGridViewTextBoxColumn1.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn1.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn1.Name = "partNoDataGridViewTextBoxColumn1";
            this.partNoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn1
            // 
            this.itemNameDataGridViewTextBoxColumn1.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn1.Name = "itemNameDataGridViewTextBoxColumn1";
            this.itemNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // RowTotal
            // 
            this.RowTotal.HeaderText = "RowTotal";
            this.RowTotal.MinimumWidth = 6;
            this.RowTotal.Name = "RowTotal";
            this.RowTotal.ReadOnly = true;
            this.RowTotal.Width = 125;
            // 
            // saleorderBindingSource
            // 
            this.saleorderBindingSource.DataMember = "saleorder";
            this.saleorderBindingSource.DataSource = this.dataSetInvoice;
            // 
            // dataSetInvoice
            // 
            this.dataSetInvoice.DataSetName = "DataSetInvoice";
            this.dataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.custdatagrid);
            this.groupBox1.Controls.Add(this.invdatagrid);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1312, 369);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click on the rows to add a customer and parts to the sale";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(582, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add Details to invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // custdatagrid
            // 
            this.custdatagrid.AutoGenerateColumns = false;
            this.custdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerSurnameDataGridViewTextBoxColumn,
            this.customerPhoneNumberDataGridViewTextBoxColumn,
            this.customerAddressDataGridViewTextBoxColumn});
            this.custdatagrid.DataSource = this.customerBindingSource;
            this.custdatagrid.Location = new System.Drawing.Point(0, 21);
            this.custdatagrid.Name = "custdatagrid";
            this.custdatagrid.RowHeadersWidth = 51;
            this.custdatagrid.RowTemplate.Height = 24;
            this.custdatagrid.Size = new System.Drawing.Size(649, 285);
            this.custdatagrid.TabIndex = 1;
            this.custdatagrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.custdatagrid_RowHeaderMouseDoubleClick);
            // 
            // invdatagrid
            // 
            this.invdatagrid.AutoGenerateColumns = false;
            this.invdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partNoDataGridViewTextBoxColumn,
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.dateReceivedDataGridViewTextBoxColumn,
            this.itemVatDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn});
            this.invdatagrid.DataSource = this.partsTableBindingSource;
            this.invdatagrid.Location = new System.Drawing.Point(661, 21);
            this.invdatagrid.Name = "invdatagrid";
            this.invdatagrid.RowHeadersWidth = 51;
            this.invdatagrid.RowTemplate.Height = 24;
            this.invdatagrid.Size = new System.Drawing.Size(645, 285);
            this.invdatagrid.TabIndex = 0;
            this.invdatagrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invdatagrid_RowHeaderMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Order Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordtotaltxt
            // 
            this.ordtotaltxt.Location = new System.Drawing.Point(667, 627);
            this.ordtotaltxt.Name = "ordtotaltxt";
            this.ordtotaltxt.ReadOnly = true;
            this.ordtotaltxt.Size = new System.Drawing.Size(153, 22);
            this.ordtotaltxt.TabIndex = 6;
            // 
            // deleterowsbtn
            // 
            this.deleterowsbtn.Location = new System.Drawing.Point(49, 619);
            this.deleterowsbtn.Name = "deleterowsbtn";
            this.deleterowsbtn.Size = new System.Drawing.Size(135, 38);
            this.deleterowsbtn.TabIndex = 7;
            this.deleterowsbtn.Text = "Clear Table";
            this.deleterowsbtn.UseVisualStyleBackColor = true;
            this.deleterowsbtn.Click += new System.EventHandler(this.deleterowsbtn_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1088, 619);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 8;
            this.button3.Text = "Confirm Order";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // saleorderTableAdapter
            // 
            this.saleorderTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 623);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 34);
            this.label2.TabIndex = 9;
            this.label2.Text = "(Only 1 customer can be added to the table. \r\nClear table to change the customer)" +
    "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit"});
            this.comboBox1.Location = new System.Drawing.Point(865, 627);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 24);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(871, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Payment Type:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // customerIDDataGridViewTextBoxColumn1
            // 
            this.customerIDDataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn1.Name = "customerIDDataGridViewTextBoxColumn1";
            this.customerIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerSurnameDataGridViewTextBoxColumn
            // 
            this.customerSurnameDataGridViewTextBoxColumn.DataPropertyName = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.HeaderText = "CustomerSurname";
            this.customerSurnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerSurnameDataGridViewTextBoxColumn.Name = "customerSurnameDataGridViewTextBoxColumn";
            this.customerSurnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerPhoneNumberDataGridViewTextBoxColumn
            // 
            this.customerPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.HeaderText = "CustomerPhoneNumber";
            this.customerPhoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerPhoneNumberDataGridViewTextBoxColumn.Name = "customerPhoneNumberDataGridViewTextBoxColumn";
            this.customerPhoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerAddressDataGridViewTextBoxColumn
            // 
            this.customerAddressDataGridViewTextBoxColumn.DataPropertyName = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.HeaderText = "CustomerAddress";
            this.customerAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerAddressDataGridViewTextBoxColumn.Name = "customerAddressDataGridViewTextBoxColumn";
            this.customerAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription";
            this.itemDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            this.itemQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            this.itemPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            this.dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.HeaderText = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            this.dateReceivedDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemVatDataGridViewTextBoxColumn
            // 
            this.itemVatDataGridViewTextBoxColumn.DataPropertyName = "ItemVat";
            this.itemVatDataGridViewTextBoxColumn.HeaderText = "ItemVat";
            this.itemVatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemVatDataGridViewTextBoxColumn.Name = "itemVatDataGridViewTextBoxColumn";
            this.itemVatDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // partsTableBindingSource
            // 
            this.partsTableBindingSource.DataMember = "PartsTable";
            this.partsTableBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // partsTableTableAdapter
            // 
            this.partsTableTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // salebkTableAdapter1
            // 
            this.salebkTableAdapter1.ClearBeforeFill = true;
            // 
            // overallsalesTableAdapter
            // 
            this.overallsalesTableAdapter.ClearBeforeFill = true;
            // 
            // itemSaleTableAdapter1
            // 
            this.itemSaleTableAdapter1.ClearBeforeFill = true;
            // 
            // custPaymentsTableAdapter
            // 
            this.custPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 669);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.deleterowsbtn);
            this.Controls.Add(this.ordtotaltxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saledatagrid);
            this.Controls.Add(this.label1);
            this.Name = "salesForm";
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.invoiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saledatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleorderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.custdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView saledatagrid;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView invdatagrid;
        private System.Windows.Forms.BindingSource partsTableBindingSource;
        private G13Wst2024DataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter;
        private System.Windows.Forms.DataGridView custdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemVatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private G13Wst2024DataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerSurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerAddressDataGridViewTextBoxColumn;
       
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ordtotaltxt;
        private DataSetInvoice dataSetInvoice;
        private System.Windows.Forms.BindingSource saleorderBindingSource;
        private DataSetInvoiceTableAdapters.saleorderTableAdapter saleorderTableAdapter;
        private System.Windows.Forms.Button deleterowsbtn;
        private System.Windows.Forms.Button button3;
        private G13Wst2024DataSetTableAdapters.SalebkTableAdapter salebkTableAdapter1;
        private System.Windows.Forms.Label label2;
        private G13Wst2024DataSetTableAdapters.OverallsalesTableAdapter overallsalesTableAdapter;
        private G13Wst2024DataSetTableAdapters.ItemSaleTableAdapter itemSaleTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private G13Wst2024DataSetTableAdapters.CustPaymentsTableAdapter custPaymentsTableAdapter;
    }
}