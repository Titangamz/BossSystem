
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
            this.dgvsalesview = new System.Windows.Forms.DataGridView();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salebkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.salebkTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.SalebkTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salebkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvsalesview
            // 
            this.dgvsalesview.AutoGenerateColumns = false;
            this.dgvsalesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.partNoDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.itemTotalDataGridViewTextBoxColumn,
            this.orderTotalDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.dgvsalesview.DataSource = this.salebkBindingSource;
            this.dgvsalesview.Location = new System.Drawing.Point(6, 108);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.RowHeadersWidth = 51;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.Size = new System.Drawing.Size(1300, 275);
            this.dgvsalesview.TabIndex = 0;
            this.dgvsalesview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsalesview_CellContentClick);
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // partNoDataGridViewTextBoxColumn
            // 
            this.partNoDataGridViewTextBoxColumn.DataPropertyName = "PartNo";
            this.partNoDataGridViewTextBoxColumn.HeaderText = "PartNo";
            this.partNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.partNoDataGridViewTextBoxColumn.Name = "partNoDataGridViewTextBoxColumn";
            this.partNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentTypeDataGridViewTextBoxColumn
            // 
            this.paymentTypeDataGridViewTextBoxColumn.DataPropertyName = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.HeaderText = "PaymentType";
            this.paymentTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentTypeDataGridViewTextBoxColumn.Name = "paymentTypeDataGridViewTextBoxColumn";
            this.paymentTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // itemTotalDataGridViewTextBoxColumn
            // 
            this.itemTotalDataGridViewTextBoxColumn.DataPropertyName = "ItemTotal";
            this.itemTotalDataGridViewTextBoxColumn.HeaderText = "ItemTotal";
            this.itemTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemTotalDataGridViewTextBoxColumn.Name = "itemTotalDataGridViewTextBoxColumn";
            this.itemTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderTotalDataGridViewTextBoxColumn
            // 
            this.orderTotalDataGridViewTextBoxColumn.DataPropertyName = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.HeaderText = "OrderTotal";
            this.orderTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderTotalDataGridViewTextBoxColumn.Name = "orderTotalDataGridViewTextBoxColumn";
            this.orderTotalDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountPaidDataGridViewTextBoxColumn
            // 
            this.amountPaidDataGridViewTextBoxColumn.DataPropertyName = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.HeaderText = "AmountPaid";
            this.amountPaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountPaidDataGridViewTextBoxColumn.Name = "amountPaidDataGridViewTextBoxColumn";
            this.amountPaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // salebkBindingSource
            // 
            this.salebkBindingSource.DataMember = "Salebk";
            this.salebkBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // salebkTableAdapter
            // 
            this.salebkTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dgvsalesview);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(1312, 439);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a date and all the sales for that day will be displayed";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Payment Date and Amount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "(To add payment details Change the relevant details in the table\r\n and click \"Add" +
    " Payment Date and Amount\")\r\n*Note: You only need to fill 1 row,\r\n it will autofi" +
    "ll rows of the same InvoiceNo*";
            // 
            // viewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 590);
            this.Controls.Add(this.groupBox1);
            this.Name = "viewSales";
            this.Text = "viewSales";
            this.Load += new System.EventHandler(this.viewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salebkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsalesview;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource salebkBindingSource;
        private G13Wst2024DataSetTableAdapters.SalebkTableAdapter salebkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}