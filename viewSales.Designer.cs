
namespace bosssystem1
{
    partial class viewSales
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.invoiceNumberDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastPaymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOutstandingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custPaymentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.invoiceNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.invoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfSaleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overallsalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.custPaymentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.overallsalesTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.OverallsalesTableAdapter();
            this.itemSaleTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.ItemSaleTableAdapter();
            this.customerIDTypeTableAdapter1 = new bosssystem1.G13Wst2024DataSetTableAdapters.CustomerIDTypeTableAdapter();
            this.custPaymentsTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.CustPaymentsTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPaymentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallsalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPaymentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(447, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1402, 895);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(13, 555);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1356, 313);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payments";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(719, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(434, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Invoice No";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(434, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount Owing";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(133, 224);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(128, 22);
            this.maskedTextBox1.TabIndex = 12;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount Paid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payment Date";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNumberDataGridViewTextBoxColumn2,
            this.lastPaymentDateDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.amountOutstandingDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.custPaymentsBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(6, 32);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1275, 150);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // invoiceNumberDataGridViewTextBoxColumn2
            // 
            this.invoiceNumberDataGridViewTextBoxColumn2.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn2.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.invoiceNumberDataGridViewTextBoxColumn2.Name = "invoiceNumberDataGridViewTextBoxColumn2";
            this.invoiceNumberDataGridViewTextBoxColumn2.Width = 125;
            // 
            // lastPaymentDateDataGridViewTextBoxColumn
            // 
            this.lastPaymentDateDataGridViewTextBoxColumn.DataPropertyName = "LastPaymentDate";
            this.lastPaymentDateDataGridViewTextBoxColumn.HeaderText = "LastPaymentDate";
            this.lastPaymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastPaymentDateDataGridViewTextBoxColumn.Name = "lastPaymentDateDataGridViewTextBoxColumn";
            this.lastPaymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AmountPaid";
            this.dataGridViewTextBoxColumn1.HeaderText = "AmountPaid";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // amountOutstandingDataGridViewTextBoxColumn
            // 
            this.amountOutstandingDataGridViewTextBoxColumn.DataPropertyName = "AmountOutstanding";
            this.amountOutstandingDataGridViewTextBoxColumn.HeaderText = "AmountOutstanding";
            this.amountOutstandingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountOutstandingDataGridViewTextBoxColumn.Name = "amountOutstandingDataGridViewTextBoxColumn";
            this.amountOutstandingDataGridViewTextBoxColumn.Width = 150;
            // 
            // custPaymentsBindingSource1
            // 
            this.custPaymentsBindingSource1.DataMember = "CustPayments";
            this.custPaymentsBindingSource1.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(925, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(7, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1371, 204);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itemized details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNumberDataGridViewTextBoxColumn1,
            this.partNoDataGridViewTextBoxColumn,
            this.partQuantityDataGridViewTextBoxColumn,
            this.itemTotalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemSaleBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1281, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseDoubleClick);
            // 
            // invoiceNumberDataGridViewTextBoxColumn1
            // 
            this.invoiceNumberDataGridViewTextBoxColumn1.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn1.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.invoiceNumberDataGridViewTextBoxColumn1.Name = "invoiceNumberDataGridViewTextBoxColumn1";
            this.invoiceNumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // partQuantityDataGridViewTextBoxColumn
            // 
            this.partQuantityDataGridViewTextBoxColumn.DataPropertyName = "PartQuantity";
            this.partQuantityDataGridViewTextBoxColumn.HeaderText = "PartQuantity";
            this.partQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partQuantityDataGridViewTextBoxColumn.Name = "partQuantityDataGridViewTextBoxColumn";
            this.partQuantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTotalDataGridViewTextBoxColumn
            // 
            this.itemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal";
            this.itemTotalDataGridViewTextBoxColumn.HeaderText = "ItemTotal";
            this.itemTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTotalDataGridViewTextBoxColumn.Name = "itemTotalDataGridViewTextBoxColumn";
            this.itemTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemSaleBindingSource
            // 
            this.itemSaleBindingSource.DataMember = "ItemSale";
            this.itemSaleBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNumberDataGridViewTextBoxColumn,
            this.customerIdDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.dateOfSaleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.overallsalesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1287, 171);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // invoiceNumberDataGridViewTextBoxColumn
            // 
            this.invoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.HeaderText = "InvoiceNumber";
            this.invoiceNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceNumberDataGridViewTextBoxColumn.Name = "invoiceNumberDataGridViewTextBoxColumn";
            this.invoiceNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            this.customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            this.customerIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            this.customerIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfSaleDataGridViewTextBoxColumn
            // 
            this.dateOfSaleDataGridViewTextBoxColumn.DataPropertyName = "DateOfSale";
            this.dateOfSaleDataGridViewTextBoxColumn.HeaderText = "DateOfSale";
            this.dateOfSaleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateOfSaleDataGridViewTextBoxColumn.Name = "dateOfSaleDataGridViewTextBoxColumn";
            this.dateOfSaleDataGridViewTextBoxColumn.Width = 125;
            // 
            // overallsalesBindingSource
            // 
            this.overallsalesBindingSource.DataMember = "Overallsales";
            this.overallsalesBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // custPaymentsBindingSource
            // 
            this.custPaymentsBindingSource.DataMember = "CustPayments";
            this.custPaymentsBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // overallsalesTableAdapter
            // 
            this.overallsalesTableAdapter.ClearBeforeFill = true;
            // 
            // itemSaleTableAdapter
            // 
            this.itemSaleTableAdapter.ClearBeforeFill = true;
            // 
            // customerIDTypeTableAdapter1
            // 
            this.customerIDTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // custPaymentsTableAdapter
            // 
            this.custPaymentsTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sales Record";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select a date to filter sales:";
            // 
            // viewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 919);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewSales";
            this.Text = "viewSales";
            this.Load += new System.EventHandler(this.viewSales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPaymentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overallsalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custPaymentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource overallsalesBindingSource;
        private G13Wst2024DataSetTableAdapters.OverallsalesTableAdapter overallsalesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfSaleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemSaleBindingSource;
        private G13Wst2024DataSetTableAdapters.ItemSaleTableAdapter itemSaleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource custPaymentsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNumberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastPaymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOutstandingDataGridViewTextBoxColumn;
        private G13Wst2024DataSetTableAdapters.CustomerIDTypeTableAdapter customerIDTypeTableAdapter1;
        private System.Windows.Forms.BindingSource custPaymentsBindingSource1;
        private G13Wst2024DataSetTableAdapters.CustPaymentsTableAdapter custPaymentsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}