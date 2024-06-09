
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
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.salebkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salebkTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.SalebkTableAdapter();
            this.invoiceNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountPaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salebkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvsalesview
            // 
            this.dgvsalesview.AutoGenerateColumns = false;
            this.dgvsalesview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsalesview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceNoDataGridViewTextBoxColumn,
            this.partNoDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.paymentTypeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentDateDataGridViewTextBoxColumn,
            this.amountPaidDataGridViewTextBoxColumn});
            this.dgvsalesview.DataSource = this.salebkBindingSource;
            this.dgvsalesview.Location = new System.Drawing.Point(12, 81);
            this.dgvsalesview.Name = "dgvsalesview";
            this.dgvsalesview.RowHeadersWidth = 51;
            this.dgvsalesview.RowTemplate.Height = 24;
            this.dgvsalesview.Size = new System.Drawing.Size(1312, 180);
            this.dgvsalesview.TabIndex = 0;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salebkBindingSource
            // 
            this.salebkBindingSource.DataMember = "Salebk";
            this.salebkBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // salebkTableAdapter
            // 
            this.salebkTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceNoDataGridViewTextBoxColumn
            // 
            this.invoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo";
            this.invoiceNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceNoDataGridViewTextBoxColumn.Name = "invoiceNoDataGridViewTextBoxColumn";
            this.invoiceNoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Width = 125;
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
            // viewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 590);
            this.Controls.Add(this.dgvsalesview);
            this.Name = "viewSales";
            this.Text = "viewSales";
            this.Load += new System.EventHandler(this.viewSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsalesview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salebkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvsalesview;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource salebkBindingSource;
        private G13Wst2024DataSetTableAdapters.SalebkTableAdapter salebkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountPaidDataGridViewTextBoxColumn;
    }
}