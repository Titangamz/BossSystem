
namespace bosssystem1
{
    partial class webcustomer
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
            this.custIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custFNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.g13Wst2024DataSet = new bosssystem1.G13Wst2024DataSet();
            this.customerDBTableAdapter = new bosssystem1.G13Wst2024DataSetTableAdapters.CustomerDBTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custIDDataGridViewTextBoxColumn,
            this.custFNameDataGridViewTextBoxColumn,
            this.custEmailDataGridViewTextBoxColumn,
            this.custUserIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1517, 506);
            this.dataGridView1.TabIndex = 0;
            // 
            // custIDDataGridViewTextBoxColumn
            // 
            this.custIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID";
            this.custIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custIDDataGridViewTextBoxColumn.Name = "custIDDataGridViewTextBoxColumn";
            this.custIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.custIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // custFNameDataGridViewTextBoxColumn
            // 
            this.custFNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_FName";
            this.custFNameDataGridViewTextBoxColumn.HeaderText = "Cust_FName";
            this.custFNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custFNameDataGridViewTextBoxColumn.Name = "custFNameDataGridViewTextBoxColumn";
            this.custFNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // custEmailDataGridViewTextBoxColumn
            // 
            this.custEmailDataGridViewTextBoxColumn.DataPropertyName = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.HeaderText = "Cust_Email";
            this.custEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custEmailDataGridViewTextBoxColumn.Name = "custEmailDataGridViewTextBoxColumn";
            this.custEmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // custUserIDDataGridViewTextBoxColumn
            // 
            this.custUserIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_UserID";
            this.custUserIDDataGridViewTextBoxColumn.HeaderText = "Cust_UserID";
            this.custUserIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.custUserIDDataGridViewTextBoxColumn.Name = "custUserIDDataGridViewTextBoxColumn";
            this.custUserIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerDBBindingSource
            // 
            this.customerDBBindingSource.DataMember = "CustomerDB";
            this.customerDBBindingSource.DataSource = this.g13Wst2024DataSet;
            // 
            // g13Wst2024DataSet
            // 
            this.g13Wst2024DataSet.DataSetName = "G13Wst2024DataSet";
            this.g13Wst2024DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerDBTableAdapter
            // 
            this.customerDBTableAdapter.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(41, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 30);
            this.label10.TabIndex = 8;
            this.label10.Text = "Website Customers";
            // 
            // webcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 572);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "webcustomer";
            this.Text = "webcustomer";
            this.Load += new System.EventHandler(this.webcustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g13Wst2024DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private G13Wst2024DataSet g13Wst2024DataSet;
        private System.Windows.Forms.BindingSource customerDBBindingSource;
        private G13Wst2024DataSetTableAdapters.CustomerDBTableAdapter customerDBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn custIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custFNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label10;
    }
}