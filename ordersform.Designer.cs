
namespace bosssystem1
{
    partial class ordersform
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.empidtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.partnotxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.unitPricetxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.temPurchasesInvBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetInvoice = new bosssystem1.DataSetInvoice();
            this.temPurchasesInvTableAdapter = new bosssystem1.DataSetInvoiceTableAdapters.TemPurchasesInvTableAdapter();
            this.ordersTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.OrdersTableAdapter();
            this.itemOrderTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.ItemOrderTableAdapter();
            this.g13Wst2024DataSet1 = new bosssystem1.G13Wst2024DataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemOrderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemOrderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.unitPriceDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temPurchasesInvBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PURCHASES FORM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.supplierNameDataGridViewTextBoxColumn,
            this.employeeIDDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 30);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1311, 231);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier Name";
            // 
            // empidtxt
            // 
            this.empidtxt.Location = new System.Drawing.Point(125, 114);
            this.empidtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empidtxt.Name = "empidtxt";
            this.empidtxt.ReadOnly = true;
            this.empidtxt.Size = new System.Drawing.Size(180, 22);
            this.empidtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "EmployeeID:";
            // 
            // partnotxt
            // 
            this.partnotxt.Location = new System.Drawing.Point(520, 57);
            this.partnotxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.partnotxt.Name = "partnotxt";
            this.partnotxt.Size = new System.Drawing.Size(180, 22);
            this.partnotxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "PartNo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(979, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.unitPricetxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.quantitytxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.partnotxt);
            this.groupBox1.Controls.Add(this.empidtxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(15, 434);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1309, 245);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input all details to record purchases from suppliers";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.supplierBindingSource;
            this.comboBox1.DisplayMember = "SupplierName";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(208, 197);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Clear Fields";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 197);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add To Invoice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // unitPricetxt
            // 
            this.unitPricetxt.Location = new System.Drawing.Point(900, 60);
            this.unitPricetxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.unitPricetxt.Name = "unitPricetxt";
            this.unitPricetxt.Size = new System.Drawing.Size(180, 22);
            this.unitPricetxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(825, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Unit Price";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(520, 121);
            this.quantitytxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(180, 22);
            this.quantitytxt.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // temPurchasesInvBindingSource
            // 
            this.temPurchasesInvBindingSource.DataMember = "TemPurchasesInv";
            this.temPurchasesInvBindingSource.DataSource = this.dataSetInvoice;
            // 
            // dataSetInvoice
            // 
            this.dataSetInvoice.DataSetName = "DataSetInvoice";
            this.dataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // temPurchasesInvTableAdapter
            // 
            this.temPurchasesInvTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // itemOrderTableAdapter
            // 
            this.itemOrderTableAdapter.ClearBeforeFill = true;
            // 
            // g13Wst2024DataSet1
            // 
            this.g13Wst2024DataSet1.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.linePriceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemOrderBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(13, 267);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1311, 138);
            this.dataGridView2.TabIndex = 15;
            // 
            // orderIDDataGridViewTextBoxColumn1
            // 
            this.orderIDDataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn1.Name = "orderIDDataGridViewTextBoxColumn1";
            this.orderIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PartNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "PartNo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // linePriceDataGridViewTextBoxColumn
            // 
            this.linePriceDataGridViewTextBoxColumn.DataPropertyName = "LinePrice";
            this.linePriceDataGridViewTextBoxColumn.HeaderText = "LinePrice";
            this.linePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linePriceDataGridViewTextBoxColumn.Name = "linePriceDataGridViewTextBoxColumn";
            this.linePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemOrderBindingSource2
            // 
            this.itemOrderBindingSource2.DataMember = "ItemOrder";
            this.itemOrderBindingSource2.DataSource = this.g13Wst2024DataSet;
            // 
            // itemOrderBindingSource
            // 
            this.itemOrderBindingSource.DataMember = "ItemOrder";
            this.itemOrderBindingSource.DataSource = this.g13Wst2024DataSet1;
            // 
            // itemOrderBindingSource1
            // 
            this.itemOrderBindingSource1.DataMember = "ItemOrder";
            this.itemOrderBindingSource1.DataSource = this.g13Wst2024DataSet;
            // 
            // unitPriceDataGridViewTextBoxColumn2
            // 
            this.unitPriceDataGridViewTextBoxColumn2.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn2.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.unitPriceDataGridViewTextBoxColumn2.Name = "unitPriceDataGridViewTextBoxColumn2";
            this.unitPriceDataGridViewTextBoxColumn2.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn2
            // 
            this.quantityDataGridViewTextBoxColumn2.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn2.Name = "quantityDataGridViewTextBoxColumn2";
            this.quantityDataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PartNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "PartNo";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.quantityDataGridViewTextBoxColumn2,
            this.unitPriceDataGridViewTextBoxColumn2,
            this.supplierNameDataGridViewTextBoxColumn1,
            this.employeeIDDataGridViewTextBoxColumn2,
            this.lineTotalDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.temPurchasesInvBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 686);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(1304, 185);
            this.dataGridView3.TabIndex = 14;
            // 
            // supplierNameDataGridViewTextBoxColumn1
            // 
            this.supplierNameDataGridViewTextBoxColumn1.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn1.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.supplierNameDataGridViewTextBoxColumn1.Name = "supplierNameDataGridViewTextBoxColumn1";
            this.supplierNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // employeeIDDataGridViewTextBoxColumn2
            // 
            this.employeeIDDataGridViewTextBoxColumn2.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn2.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.employeeIDDataGridViewTextBoxColumn2.Name = "employeeIDDataGridViewTextBoxColumn2";
            this.employeeIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // lineTotalDataGridViewTextBoxColumn
            // 
            this.lineTotalDataGridViewTextBoxColumn.DataPropertyName = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.HeaderText = "LineTotal";
            this.lineTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineTotalDataGridViewTextBoxColumn.Name = "lineTotalDataGridViewTextBoxColumn";
            this.lineTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // ordersform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 930);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ordersform";
            this.Text = "ordersform";
            this.Load += new System.EventHandler(this.ordersform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temPurchasesInvBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox empidtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox partnotxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private G13Wst2024DataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private G13Wst2024DataSetTableAdapters.ItemOrderTableAdapter itemOrderTableAdapter;
        private System.Windows.Forms.TextBox unitPricetxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn linePriceDataGridViewTextBoxColumn1;
        private DataSetInvoice dataSetInvoice;
        private System.Windows.Forms.BindingSource temPurchasesInvBindingSource;
        private DataSetInvoiceTableAdapters.TemPurchasesInvTableAdapter temPurchasesInvTableAdapter;
        private System.Windows.Forms.Button button2;
        private G13Wst2024DataSet g13Wst2024DataSet1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemOrderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemOrderBindingSource1;
        private System.Windows.Forms.BindingSource itemOrderBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private G13Wst2024DataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
    }
}